// <copyright file="MainForm.cs" company="PublicDomain.is">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
namespace GoOffAlarm
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Media;
    using System.Reflection;
    using System.Windows.Forms;
    using System.Xml.Serialization;
    using PublicDomain;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// The sound player.
        /// </summary>
        private SoundPlayer soundPlayer = null;

        /// <summary>
        /// The settings data.
        /// </summary>
        private SettingsData settingsData = new SettingsData();

        /// <summary>
        /// The settings data path.
        /// </summary>
        private string settingsDataPath = $"{Application.ProductName}-SettingsData.txt";

        /// <summary>
        /// The stopwatch.
        /// </summary>
        Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// The left time span.
        /// </summary>
        TimeSpan leftTimeSpan;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:GoOffAlarm.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            /* Set icons */

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set PublicDomain.is tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();


            /* Settings data */

            // Check for settings file
            if (!File.Exists(this.settingsDataPath))
            {
                // Create new settings file
                this.SaveSettingsFile(this.settingsDataPath, new SettingsData());
            }

            // Load settings from disk
            this.settingsData = this.LoadSettingsFile(this.settingsDataPath);

            // Set values
            this.alwaysOnTopToolStripMenuItem.Checked = this.settingsData.AlwaysOnTop;
            this.loopSoundToolStripMenuItem.Checked = this.settingsData.LoopSound;
            this.minutesNumericUpDown.Value = this.settingsData.Minutes;
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Reset the player
            this.ResetSoundPlayer();

            // Stopwatch
            this.stopwatch.Stop();
            this.stopwatch.Reset();

            // Stop timer
            this.activeTimer.Stop();

            // Reset to start
            this.startStopButton.Text = "&Start";
            this.startStopButton.ForeColor = Color.DarkGreen;

            // Reset labels
            this.ResetLabels();

            // Focus 
            this.minutesNumericUpDown.Focus();
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set tool strip menu item
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)e.ClickedItem;

            // Toggle checked
            toolStripMenuItem.Checked = !toolStripMenuItem.Checked;

            // Set topmost by check box
            this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the set sound file tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSetSoundFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Show open file dialog
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set sound file path
                this.settingsData.SoundFilePath = this.openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread redditcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadRedditcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open original thread
            Process.Start("https://www.reddit.com/r/software/comments/uqfsmv/looking_for_a_good_timer_program_that_actually/");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the start stop button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnStartStopButtonClick(object sender, EventArgs e)
        {
            // Check start/stop/silence
            switch (this.startStopButton.Text)
            {
                case "&Start":

                    // Set timespan from minutes
                    this.leftTimeSpan = TimeSpan.FromMinutes((Double)this.minutesNumericUpDown.Value);

                    // Restart stopwatch
                    this.stopwatch.Restart();

                    // Start timer
                    this.activeTimer.Start();

                    // Change to stop
                    this.startStopButton.Text = "&Stop";
                    this.startStopButton.ForeColor = Color.Red;

                    break;

                case "&Stop":

                    // Stop stopwatch
                    this.stopwatch.Stop();

                    // Stop timer
                    this.activeTimer.Stop();

                    // Reset to start
                    this.startStopButton.Text = "&Start";
                    this.startStopButton.ForeColor = Color.DarkGreen;

                    break;

                case "&Silence":

                    // Reset the player
                    this.ResetSoundPlayer();

                    // Reset to start
                    this.startStopButton.Text = "&Start";
                    this.startStopButton.ForeColor = Color.DarkGreen;

                    break;
            }
        }

        /// <summary>
        /// Plays the passed sound file.
        /// </summary>
        /// <param name="filePath">File path.</param>
        /// <param name="loop">If set to <c>true</c> loop.</param>
        private void PlaySoundFile(string filePath, bool loop)
        {
            // Reset the player
            this.ResetSoundPlayer();

            // Set instance player afresh
            this.soundPlayer = new SoundPlayer(filePath);

            // Play the passed file
            if (loop)
            {
                this.soundPlayer.PlayLooping();
            }
            else
            {
                this.soundPlayer.Play();
            }
        }

        /// <summary>
        /// Resets the sound player.
        /// </summary>
        private void ResetSoundPlayer()
        {
            // Check for previous player
            if (this.soundPlayer != null)
            {
                // Stop it
                this.soundPlayer.Stop();

                // Dispose of it
                this.soundPlayer.Dispose();

                // Reset instance variable
                this.soundPlayer = null;
            }
        }

        /// <summary>
        /// Handles the main form load.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormLoad(object sender, EventArgs e)
        {
            // Set topmost
            this.TopMost = this.settingsData.AlwaysOnTop;
        }

        /// <summary>
        /// Handles the main form form closing.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMainFormFormClosing(object sender, FormClosingEventArgs e)
        {
            /* Settings data */

            // ALways on top
            this.settingsData.AlwaysOnTop = this.alwaysOnTopToolStripMenuItem.Checked;

            // Loop
            this.settingsData.LoopSound = this.loopSoundToolStripMenuItem.Checked;

            // Minutes
            this.settingsData.Minutes = this.minutesNumericUpDown.Value;

            // Save settings data to disk
            this.SaveSettingsFile(this.settingsDataPath, this.settingsData);
        }

        /// <summary>
        /// Loads the settings file.
        /// </summary>
        /// <returns>The settings file.</returns>
        /// <param name="settingsFilePath">Settings file path.</param>
        private SettingsData LoadSettingsFile(string settingsFilePath)
        {
            // Use file stream
            using (FileStream fileStream = File.OpenRead(settingsFilePath))
            {
                // Set xml serialzer
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                // Return populated settings data
                return xmlSerializer.Deserialize(fileStream) as SettingsData;
            }
        }

        /// <summary>
        /// Saves the settings file.
        /// </summary>
        /// <param name="settingsFilePath">Settings file path.</param>
        /// <param name="settingsDataParam">Settings data parameter.</param>
        private void SaveSettingsFile(string settingsFilePath, SettingsData settingsDataParam)
        {
            try
            {
                // Use stream writer
                using (StreamWriter streamWriter = new StreamWriter(settingsFilePath, false))
                {
                    // Set xml serialzer
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(SettingsData));

                    // Serialize settings data
                    xmlSerializer.Serialize(streamWriter, settingsDataParam);
                }
            }
            catch (Exception exception)
            {
                // Advise user
                MessageBox.Show($"Error saving settings file.{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{exception.Message}", "File error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Handles the active timer tick.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnActiveTimerTick(object sender, EventArgs e)
        {
            // Set alarm timestamp
            var alarmTimeSpan = this.leftTimeSpan.Subtract(this.stopwatch.Elapsed);

            if (TimeSpan.Compare(alarmTimeSpan.Add(this.leftTimeSpan), this.leftTimeSpan) < 0)
            {
                // Disable timer
                this.activeTimer.Stop();

                // Reset labels
                this.ResetLabels();

                // Change button label to silence
                this.startStopButton.Text = "&Silence";

                // Focus silence button
                this.startStopButton.Focus();

                // Play sound file
                this.PlaySoundFile(this.settingsData.SoundFilePath, this.loopSoundToolStripMenuItem.Checked);

                // Halt flow
                return;
            }

            // Show elapsed time
            this.elapsedLabel.Text = this.stopwatch.Elapsed.ToString(@"hh\:mm\:ss");

            // Show time left
            this.timeLeftToolStripStatusLabel.Text = alarmTimeSpan.ToString(@"hh\:mm\:ss");
        }

        /// <summary>
        /// Resets the labels.
        /// </summary>
        private void ResetLabels()
        {
            // Show elapsed time
            this.elapsedLabel.Text = "00:00:00";

            // Show time left
            this.timeLeftToolStripStatusLabel.Text = "00:00:00";
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
