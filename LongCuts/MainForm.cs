using Open.WinKeyboardHook;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Windows.Forms;

namespace LongCuts
{
	public partial class MainForm : Form
	{
		private readonly ShortCutStore Store;
		private readonly Properties.Settings settings = new Properties.Settings();
		private readonly IKeyboardInterceptor interceptor = new KeyboardInterceptor();
		private readonly IObservable<char> keysource;
		private Subject<IObservable<IList<char>>> sequences = new Subject<IObservable<IList<char>>>();
		private bool allowVisible;
		private bool allowClose;

		public MainForm()
		{
			InitializeComponent();

			Store = new ShortCutStore(settings);
			Debounce.Value = settings.DebounceMilliseconds;

			LongCutList.DataSource = new BindingSource { DataSource = Store };

			keysource = Observable.FromEventPattern<KeyPressEventArgs>
				(
					x => interceptor.KeyPress+=x,
					x => interceptor.KeyPress-=x
				)
				.Select(x => x.EventArgs.KeyChar)
				;

			interceptor.StartCapturing();

			sequences
				.Switch()
				.Where(x => x.Count > 0)
				.ObserveOn(this)
				.Subscribe(Process)
				;

			EmitSource();

			VisibleChanged += (s, e) =>
				{
					if (Visible)
					{
						interceptor.StopCapturing();
					}
					else
					{
						interceptor.StartCapturing();
					}
				};
		}

		private void Process(IList<char> chars)
		{
			var found = Store.FirstOrDefault(x => x.ShortCut.Equals(new string(chars.ToArray()), StringComparison.CurrentCultureIgnoreCase));

			if (found != null)
			{
				var bs = new StringBuilder().Insert(0, "{BS}", chars.Count).ToString();
				SendKeys.Send(bs + found.Text);
			}
		}

		private void EmitSource()
		{
			sequences.OnNext(keysource.Buffer(keysource.Throttle(TimeSpan.FromMilliseconds((int)Debounce.Value))));
		}

		protected override void SetVisibleCore(bool value)
		{
			if (!allowVisible)
			{
				value = false;
				if (!IsHandleCreated) CreateHandle();
			}
			base.SetVisibleCore(value);
		}

		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			if (!allowClose)
			{
				Hide();
				e.Cancel = true;
			}
			base.OnFormClosing(e);
		}

		private void OpenEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			allowVisible = true;
			Show();
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Store.Save((int)Debounce.Value);

			EmitSource();

			Close();
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			allowClose = true;
			Application.Exit();
		}

		private void ReloadButton_Click(object sender, EventArgs e)
		{
			Store.Load();
		}

		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			interceptor.StopCapturing();
		}
	}
}
