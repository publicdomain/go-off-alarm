
namespace GoOffAlarm
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.activeTimer = new System.Windows.Forms.Timer(this.components);
			this.goOffInLabel = new System.Windows.Forms.Label();
			this.elapsedTextLabel = new System.Windows.Forms.Label();
			this.elapsedLabel = new System.Windows.Forms.Label();
			this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.startStopButton = new System.Windows.Forms.Button();
			this.minutesNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.timeLeftToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.timeLeftTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loopSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.setSoundFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.originalThreadRedditcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.mainTableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).BeginInit();
			this.mainStatusStrip.SuspendLayout();
			this.mainMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// activeTimer
			// 
			this.activeTimer.Interval = 50;
			this.activeTimer.Tick += new System.EventHandler(this.OnActiveTimerTick);
			// 
			// goOffInLabel
			// 
			this.goOffInLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.goOffInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.goOffInLabel.Location = new System.Drawing.Point(3, 0);
			this.goOffInLabel.Name = "goOffInLabel";
			this.goOffInLabel.Size = new System.Drawing.Size(120, 40);
			this.goOffInLabel.TabIndex = 0;
			this.goOffInLabel.Text = "&Go off in:";
			this.goOffInLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// elapsedTextLabel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.elapsedTextLabel, 2);
			this.elapsedTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elapsedTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elapsedTextLabel.Location = new System.Drawing.Point(3, 40);
			this.elapsedTextLabel.Name = "elapsedTextLabel";
			this.elapsedTextLabel.Size = new System.Drawing.Size(246, 30);
			this.elapsedTextLabel.TabIndex = 2;
			this.elapsedTextLabel.Text = "&Elapsed:";
			this.elapsedTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// elapsedLabel
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.elapsedLabel, 2);
			this.elapsedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elapsedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.elapsedLabel.Location = new System.Drawing.Point(3, 70);
			this.elapsedLabel.Name = "elapsedLabel";
			this.elapsedLabel.Size = new System.Drawing.Size(246, 56);
			this.elapsedLabel.TabIndex = 3;
			this.elapsedLabel.Text = "00:00:00";
			this.elapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mainTableLayoutPanel
			// 
			this.mainTableLayoutPanel.ColumnCount = 2;
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainTableLayoutPanel.Controls.Add(this.goOffInLabel, 0, 0);
			this.mainTableLayoutPanel.Controls.Add(this.elapsedTextLabel, 0, 1);
			this.mainTableLayoutPanel.Controls.Add(this.elapsedLabel, 0, 2);
			this.mainTableLayoutPanel.Controls.Add(this.startStopButton, 0, 3);
			this.mainTableLayoutPanel.Controls.Add(this.minutesNumericUpDown, 1, 0);
			this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
			this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
			this.mainTableLayoutPanel.RowCount = 4;
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.mainTableLayoutPanel.Size = new System.Drawing.Size(252, 176);
			this.mainTableLayoutPanel.TabIndex = 57;
			// 
			// startStopButton
			// 
			this.mainTableLayoutPanel.SetColumnSpan(this.startStopButton, 2);
			this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startStopButton.ForeColor = System.Drawing.Color.DarkGreen;
			this.startStopButton.Location = new System.Drawing.Point(3, 129);
			this.startStopButton.Name = "startStopButton";
			this.startStopButton.Size = new System.Drawing.Size(246, 44);
			this.startStopButton.TabIndex = 4;
			this.startStopButton.Text = "&Start";
			this.startStopButton.UseVisualStyleBackColor = true;
			this.startStopButton.Click += new System.EventHandler(this.OnStartStopButtonClick);
			// 
			// minutesNumericUpDown
			// 
			this.minutesNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.minutesNumericUpDown.Location = new System.Drawing.Point(129, 3);
			this.minutesNumericUpDown.Maximum = new decimal(new int[] {
									1440,
									0,
									0,
									0});
			this.minutesNumericUpDown.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.minutesNumericUpDown.Name = "minutesNumericUpDown";
			this.minutesNumericUpDown.Size = new System.Drawing.Size(120, 31);
			this.minutesNumericUpDown.TabIndex = 5;
			this.minutesNumericUpDown.Value = new decimal(new int[] {
									20,
									0,
									0,
									0});
			// 
			// timeLeftToolStripStatusLabel
			// 
			this.timeLeftToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.timeLeftToolStripStatusLabel.Name = "timeLeftToolStripStatusLabel";
			this.timeLeftToolStripStatusLabel.Size = new System.Drawing.Size(55, 17);
			this.timeLeftToolStripStatusLabel.Text = "00:00:00";
			// 
			// timeLeftTextToolStripStatusLabel
			// 
			this.timeLeftTextToolStripStatusLabel.Name = "timeLeftTextToolStripStatusLabel";
			this.timeLeftTextToolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
			this.timeLeftTextToolStripStatusLabel.Text = "Time left:";
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.timeLeftTextToolStripStatusLabel,
									this.timeLeftToolStripStatusLabel});
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 200);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(252, 22);
			this.mainStatusStrip.SizingGrip = false;
			this.mainStatusStrip.TabIndex = 55;
			// 
			// optionsToolStripMenuItem1
			// 
			this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.alwaysOnTopToolStripMenuItem,
									this.loopSoundToolStripMenuItem});
			this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
			this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(130, 22);
			this.optionsToolStripMenuItem1.Text = "&Options";
			this.optionsToolStripMenuItem1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
			// 
			// alwaysOnTopToolStripMenuItem
			// 
			this.alwaysOnTopToolStripMenuItem.Checked = true;
			this.alwaysOnTopToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
			this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
			// 
			// loopSoundToolStripMenuItem
			// 
			this.loopSoundToolStripMenuItem.Checked = true;
			this.loopSoundToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.loopSoundToolStripMenuItem.Name = "loopSoundToolStripMenuItem";
			this.loopSoundToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.loopSoundToolStripMenuItem.Text = "&Loop sound";
			// 
			// customizeToolStripMenuItem
			// 
			this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.setSoundFileToolStripMenuItem});
			this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
			this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
			this.customizeToolStripMenuItem.Text = "&Customize";
			// 
			// setSoundFileToolStripMenuItem
			// 
			this.setSoundFileToolStripMenuItem.Name = "setSoundFileToolStripMenuItem";
			this.setSoundFileToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
			this.setSoundFileToolStripMenuItem.Text = "&Set sound file";
			this.setSoundFileToolStripMenuItem.Click += new System.EventHandler(this.OnSetSoundFileToolStripMenuItemClick);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem1,
									this.toolsToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(252, 24);
			this.mainMenuStrip.TabIndex = 56;
			// 
			// fileToolStripMenuItem1
			// 
			this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.toolStripSeparator3,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
			this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem1.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.customizeToolStripMenuItem,
									this.optionsToolStripMenuItem1});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.toolsToolStripMenuItem.Text = "&Tools";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.freeReleasesPublicDomainisToolStripMenuItem,
									this.originalThreadRedditcomToolStripMenuItem,
									this.sourceCodeGithubcomToolStripMenuItem,
									this.toolStripSeparator2,
									this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// freeReleasesPublicDomainisToolStripMenuItem
			// 
			this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
			this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
			this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
			// 
			// originalThreadRedditcomToolStripMenuItem
			// 
			this.originalThreadRedditcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadRedditcomToolStripMenuItem.Image")));
			this.originalThreadRedditcomToolStripMenuItem.Name = "originalThreadRedditcomToolStripMenuItem";
			this.originalThreadRedditcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.originalThreadRedditcomToolStripMenuItem.Text = "Original thread @ Reddit.com";
			this.originalThreadRedditcomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadRedditcomToolStripMenuItemClick);
			// 
			// sourceCodeGithubcomToolStripMenuItem
			// 
			this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
			this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
			this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
			this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(243, 6);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(246, 22);
			this.aboutToolStripMenuItem.Text = "&About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "wav";
			this.openFileDialog.Filter = "WAV files (*.wav)|*.wav|All files (*.*)|*.*";
			// 
			// MainForm
			// 
			this.AcceptButton = this.startStopButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(252, 222);
			this.Controls.Add(this.mainTableLayoutPanel);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.mainMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GoOffAlarm";
			this.TopMost = true;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
			this.Load += new System.EventHandler(this.OnMainFormLoad);
			this.mainTableLayoutPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.minutesNumericUpDown)).EndInit();
			this.mainStatusStrip.ResumeLayout(false);
			this.mainStatusStrip.PerformLayout();
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem setSoundFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loopSoundToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown minutesNumericUpDown;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem originalThreadRedditcomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.ToolStripStatusLabel timeLeftTextToolStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel timeLeftToolStripStatusLabel;
		private System.Windows.Forms.Button startStopButton;
		private System.Windows.Forms.Label elapsedLabel;
		private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
		private System.Windows.Forms.Label elapsedTextLabel;
		private System.Windows.Forms.Label goOffInLabel;
		private System.Windows.Forms.Timer activeTimer;
	}
}
