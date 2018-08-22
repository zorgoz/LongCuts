using LongCuts.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace LongCuts
{
	internal class ShortCutStore : BindingList<StoreItem>
	{
		private readonly Settings original;

		public ShortCutStore(Settings settings)
		{
			original = settings;

			Load();

			RaiseListChangedEvents = true;
		}

		public void Save(int debounce)
		{
			try
			{
				var values = Utf8Json.JsonSerializer.ToJsonString<BindingList<StoreItem>>(this);

				original.Shortcuts = values;
				original.DebounceMilliseconds = debounce;

				Settings.Default.Shortcuts = values;
				Settings.Default.DebounceMilliseconds = debounce;

				Settings.Default.Save();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Could not save settings:\n\n" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		public void Load()
		{
			try
			{
				Clear();

				foreach (var item in Utf8Json.JsonSerializer.Deserialize<List<StoreItem>>(original.Shortcuts))
				{
					Add(item);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Could not read settings:\n\n" + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}

	public class StoreItem : INotifyPropertyChanged
	{
		private string _shortCut;
		private string _text;

		public event PropertyChangedEventHandler PropertyChanged;

		[DisplayName("Keyboard shortcut")]
		public string ShortCut
		{
			get { return _shortCut; }
			set { _shortCut = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ShortCut))); }
		}

		[DisplayName("Keyboard text to send")]
		public string Text
		{
			get { return _text; }
			set { _text = value; PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text))); }
		}
	}
}
