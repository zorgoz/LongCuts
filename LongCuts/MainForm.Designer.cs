namespace LongCuts
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tryIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.tryMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LongCutList = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.ReloadButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.Debounce = new System.Windows.Forms.NumericUpDown();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tryMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.LongCutList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Debounce)).BeginInit();
			this.SuspendLayout();
			// 
			// tryIcon
			// 
			this.tryIcon.ContextMenuStrip = this.tryMenu;
			this.tryIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("tryIcon.Icon")));
			this.tryIcon.Text = "LongCuts";
			this.tryIcon.Visible = true;
			this.tryIcon.DoubleClick += new System.EventHandler(this.OpenEditorToolStripMenuItem_Click);
			// 
			// tryMenu
			// 
			this.tryMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tryMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.openEditorToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
			this.tryMenu.Name = "tryMenu";
			this.tryMenu.Size = new System.Drawing.Size(166, 94);
			// 
			// openEditorToolStripMenuItem
			// 
			this.openEditorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.openEditorToolStripMenuItem.Name = "openEditorToolStripMenuItem";
			this.openEditorToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
			this.openEditorToolStripMenuItem.Text = "&Open editor";
			this.openEditorToolStripMenuItem.Click += new System.EventHandler(this.OpenEditorToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(214, 28);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// LongCutList
			// 
			this.LongCutList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LongCutList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.LongCutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.LongCutList.Location = new System.Drawing.Point(12, 29);
			this.LongCutList.Name = "LongCutList";
			this.LongCutList.RowTemplate.Height = 24;
			this.LongCutList.Size = new System.Drawing.Size(752, 296);
			this.LongCutList.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Shortcuts:";
			// 
			// ReloadButton
			// 
			this.ReloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ReloadButton.Location = new System.Drawing.Point(9, 405);
			this.ReloadButton.Name = "ReloadButton";
			this.ReloadButton.Size = new System.Drawing.Size(75, 31);
			this.ReloadButton.TabIndex = 3;
			this.ReloadButton.Text = "Reload";
			this.ReloadButton.UseVisualStyleBackColor = true;
			this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(551, 405);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(203, 31);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Save, apply and close";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 356);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(157, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Debounce milliseconds:";
			// 
			// Debounce
			// 
			this.Debounce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Debounce.Location = new System.Drawing.Point(178, 354);
			this.Debounce.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.Debounce.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.Debounce.Name = "Debounce";
			this.Debounce.Size = new System.Drawing.Size(77, 22);
			this.Debounce.TabIndex = 6;
			this.Debounce.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Segoe Script", 9F);
			this.toolStripMenuItem2.Image = global::LongCuts.Properties.Resources.longcuts;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(214, 28);
			this.toolStripMenuItem2.Text = "LongCuts";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(776, 448);
			this.Controls.Add(this.Debounce);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.ReloadButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.LongCutList);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.ShowInTaskbar = false;
			this.Text = "LongCuts";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
			this.tryMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.LongCutList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Debounce)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NotifyIcon tryIcon;
		private System.Windows.Forms.ContextMenuStrip tryMenu;
		private System.Windows.Forms.ToolStripMenuItem openEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.DataGridView LongCutList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button ReloadButton;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown Debounce;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
	}
}

