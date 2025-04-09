namespace Weather_App
{
    partial class WeatherControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CurrentWeatherStats = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.labelDay1 = new System.Windows.Forms.Label();
            this.labelDay2 = new System.Windows.Forms.Label();
            this.labelDay3 = new System.Windows.Forms.Label();
            this.labelDay4 = new System.Windows.Forms.Label();
            this.labelDay5 = new System.Windows.Forms.Label();
            this.labelDay6 = new System.Windows.Forms.Label();
            this.labelDay7 = new System.Windows.Forms.Label();
            this.labelStat1 = new System.Windows.Forms.Label();
            this.labelStat2 = new System.Windows.Forms.Label();
            this.labelStat3 = new System.Windows.Forms.Label();
            this.labelStat4 = new System.Windows.Forms.Label();
            this.labelStat5 = new System.Windows.Forms.Label();
            this.labelStat6 = new System.Windows.Forms.Label();
            this.labelStat7 = new System.Windows.Forms.Label();
            this.pictureDay1 = new System.Windows.Forms.PictureBox();
            this.pictureDay2 = new System.Windows.Forms.PictureBox();
            this.pictureDay3 = new System.Windows.Forms.PictureBox();
            this.pictureDay4 = new System.Windows.Forms.PictureBox();
            this.pictureDay5 = new System.Windows.Forms.PictureBox();
            this.pictureDay6 = new System.Windows.Forms.PictureBox();
            this.pictureDay7 = new System.Windows.Forms.PictureBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            this.labelSearchError = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay7)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentWeatherStats
            // 
            this.CurrentWeatherStats.AutoSize = true;
            this.CurrentWeatherStats.Font = new System.Drawing.Font("MS PGothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentWeatherStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CurrentWeatherStats.Location = new System.Drawing.Point(3, 0);
            this.CurrentWeatherStats.Name = "CurrentWeatherStats";
            this.CurrentWeatherStats.Size = new System.Drawing.Size(278, 66);
            this.CurrentWeatherStats.TabIndex = 0;
            this.CurrentWeatherStats.Text = "LOCATION_NAME\r\nTEMP°C";
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("MS PGothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelTime.Location = new System.Drawing.Point(615, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(278, 44);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00 AM";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 50;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // labelDay1
            // 
            this.labelDay1.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay1.ForeColor = System.Drawing.Color.White;
            this.labelDay1.Location = new System.Drawing.Point(6, 134);
            this.labelDay1.Name = "labelDay1";
            this.labelDay1.Size = new System.Drawing.Size(147, 42);
            this.labelDay1.TabIndex = 2;
            this.labelDay1.Text = "DAY";
            this.labelDay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay2
            // 
            this.labelDay2.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay2.ForeColor = System.Drawing.Color.White;
            this.labelDay2.Location = new System.Drawing.Point(143, 134);
            this.labelDay2.Name = "labelDay2";
            this.labelDay2.Size = new System.Drawing.Size(147, 42);
            this.labelDay2.TabIndex = 3;
            this.labelDay2.Text = "DAY";
            this.labelDay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay3
            // 
            this.labelDay3.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay3.ForeColor = System.Drawing.Color.White;
            this.labelDay3.Location = new System.Drawing.Point(282, 134);
            this.labelDay3.Name = "labelDay3";
            this.labelDay3.Size = new System.Drawing.Size(147, 42);
            this.labelDay3.TabIndex = 4;
            this.labelDay3.Text = "DAY";
            this.labelDay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay4
            // 
            this.labelDay4.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay4.ForeColor = System.Drawing.Color.White;
            this.labelDay4.Location = new System.Drawing.Point(419, 134);
            this.labelDay4.Name = "labelDay4";
            this.labelDay4.Size = new System.Drawing.Size(147, 42);
            this.labelDay4.TabIndex = 5;
            this.labelDay4.Text = "DAY";
            this.labelDay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay5
            // 
            this.labelDay5.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay5.ForeColor = System.Drawing.Color.White;
            this.labelDay5.Location = new System.Drawing.Point(560, 134);
            this.labelDay5.Name = "labelDay5";
            this.labelDay5.Size = new System.Drawing.Size(147, 42);
            this.labelDay5.TabIndex = 6;
            this.labelDay5.Text = "DAY";
            this.labelDay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay6
            // 
            this.labelDay6.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay6.ForeColor = System.Drawing.Color.White;
            this.labelDay6.Location = new System.Drawing.Point(699, 134);
            this.labelDay6.Name = "labelDay6";
            this.labelDay6.Size = new System.Drawing.Size(147, 42);
            this.labelDay6.TabIndex = 7;
            this.labelDay6.Text = "DAY";
            this.labelDay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDay7
            // 
            this.labelDay7.BackColor = System.Drawing.Color.SkyBlue;
            this.labelDay7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDay7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay7.ForeColor = System.Drawing.Color.White;
            this.labelDay7.Location = new System.Drawing.Point(821, 134);
            this.labelDay7.Name = "labelDay7";
            this.labelDay7.Size = new System.Drawing.Size(147, 42);
            this.labelDay7.TabIndex = 8;
            this.labelDay7.Text = "DAY";
            this.labelDay7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStat1
            // 
            this.labelStat1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStat1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat1.ForeColor = System.Drawing.Color.White;
            this.labelStat1.Location = new System.Drawing.Point(6, 176);
            this.labelStat1.Name = "labelStat1";
            this.labelStat1.Size = new System.Drawing.Size(147, 254);
            this.labelStat1.TabIndex = 9;
            this.labelStat1.Text = "HIGHTEMP\r\nLOWTEMP\r\n\r\nCONDITIONS\r\nHUMIDITY";
            this.labelStat1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelStat1.Paint += new System.Windows.Forms.PaintEventHandler(this.labelStat1_Paint);
            this.labelStat1.Resize += new System.EventHandler(this.labelStat1_Resize);
            // 
            // labelStat2
            // 
            this.labelStat2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStat2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat2.ForeColor = System.Drawing.Color.White;
            this.labelStat2.Location = new System.Drawing.Point(143, 176);
            this.labelStat2.Name = "labelStat2";
            this.labelStat2.Size = new System.Drawing.Size(147, 254);
            this.labelStat2.TabIndex = 10;
            this.labelStat2.Text = "HIGHTEMP\r\nLOWTEMP\r\n\r\nCONDITIONS\r\nHUMIDITY";
            this.labelStat2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStat3
            // 
            this.labelStat3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStat3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat3.ForeColor = System.Drawing.Color.White;
            this.labelStat3.Location = new System.Drawing.Point(282, 176);
            this.labelStat3.Name = "labelStat3";
            this.labelStat3.Size = new System.Drawing.Size(147, 254);
            this.labelStat3.TabIndex = 11;
            this.labelStat3.Text = "HIGHTEMP\r\nLOWTEMP\r\n\r\nCONDITIONS\r\nHUMIDITY";
            this.labelStat3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStat4
            // 
            this.labelStat4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStat4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat4.ForeColor = System.Drawing.Color.White;
            this.labelStat4.Location = new System.Drawing.Point(419, 176);
            this.labelStat4.Name = "labelStat4";
            this.labelStat4.Size = new System.Drawing.Size(147, 254);
            this.labelStat4.TabIndex = 12;
            this.labelStat4.Text = "HIGHTEMP\r\nLOWTEMP\r\n\r\nCONDITIONS\r\nHUMIDITY";
            this.labelStat4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStat5
            // 
            this.labelStat5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStat5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat5.ForeColor = System.Drawing.Color.White;
            this.labelStat5.Location = new System.Drawing.Point(560, 176);
            this.labelStat5.Name = "labelStat5";
            this.labelStat5.Size = new System.Drawing.Size(147, 254);
            this.labelStat5.TabIndex = 13;
            this.labelStat5.Text = "HIGHTEMP\r\nLOWTEMP\r\n\r\nCONDITIONS\r\nHUMIDITY";
            this.labelStat5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStat6
            // 
            this.labelStat6.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStat6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat6.ForeColor = System.Drawing.Color.White;
            this.labelStat6.Location = new System.Drawing.Point(699, 176);
            this.labelStat6.Name = "labelStat6";
            this.labelStat6.Size = new System.Drawing.Size(147, 254);
            this.labelStat6.TabIndex = 14;
            this.labelStat6.Text = "HIGHTEMP\r\nLOWTEMP\r\n\r\nCONDITIONS\r\nHUMIDITY";
            this.labelStat6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStat7
            // 
            this.labelStat7.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.labelStat7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStat7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStat7.ForeColor = System.Drawing.Color.White;
            this.labelStat7.Location = new System.Drawing.Point(821, 176);
            this.labelStat7.Name = "labelStat7";
            this.labelStat7.Size = new System.Drawing.Size(147, 254);
            this.labelStat7.TabIndex = 15;
            this.labelStat7.Text = "HIGHTEMP\r\nLOWTEMP\r\n\r\nCONDITIONS\r\nHUMIDITY";
            this.labelStat7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureDay1
            // 
            this.pictureDay1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureDay1.Location = new System.Drawing.Point(3, 424);
            this.pictureDay1.Name = "pictureDay1";
            this.pictureDay1.Size = new System.Drawing.Size(144, 135);
            this.pictureDay1.TabIndex = 16;
            this.pictureDay1.TabStop = false;
            // 
            // pictureDay2
            // 
            this.pictureDay2.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureDay2.Location = new System.Drawing.Point(146, 424);
            this.pictureDay2.Name = "pictureDay2";
            this.pictureDay2.Size = new System.Drawing.Size(144, 135);
            this.pictureDay2.TabIndex = 17;
            this.pictureDay2.TabStop = false;
            // 
            // pictureDay3
            // 
            this.pictureDay3.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureDay3.Location = new System.Drawing.Point(285, 424);
            this.pictureDay3.Name = "pictureDay3";
            this.pictureDay3.Size = new System.Drawing.Size(144, 135);
            this.pictureDay3.TabIndex = 18;
            this.pictureDay3.TabStop = false;
            // 
            // pictureDay4
            // 
            this.pictureDay4.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureDay4.Location = new System.Drawing.Point(423, 424);
            this.pictureDay4.Name = "pictureDay4";
            this.pictureDay4.Size = new System.Drawing.Size(144, 135);
            this.pictureDay4.TabIndex = 19;
            this.pictureDay4.TabStop = false;
            // 
            // pictureDay5
            // 
            this.pictureDay5.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureDay5.Location = new System.Drawing.Point(563, 424);
            this.pictureDay5.Name = "pictureDay5";
            this.pictureDay5.Size = new System.Drawing.Size(144, 135);
            this.pictureDay5.TabIndex = 20;
            this.pictureDay5.TabStop = false;
            // 
            // pictureDay6
            // 
            this.pictureDay6.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureDay6.Location = new System.Drawing.Point(702, 424);
            this.pictureDay6.Name = "pictureDay6";
            this.pictureDay6.Size = new System.Drawing.Size(144, 135);
            this.pictureDay6.TabIndex = 21;
            this.pictureDay6.TabStop = false;
            // 
            // pictureDay7
            // 
            this.pictureDay7.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureDay7.Location = new System.Drawing.Point(839, 424);
            this.pictureDay7.Name = "pictureDay7";
            this.pictureDay7.Size = new System.Drawing.Size(144, 135);
            this.pictureDay7.TabIndex = 22;
            this.pictureDay7.TabStop = false;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityTextBox.Location = new System.Drawing.Point(324, 12);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(285, 40);
            this.cityTextBox.TabIndex = 23;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Font = new System.Drawing.Font("MS PGothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelRange.Location = new System.Drawing.Point(6, 77);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(143, 23);
            this.labelRange.TabIndex = 24;
            this.labelRange.Text = "LOW - HIGH";
            // 
            // labelSearchError
            // 
            this.labelSearchError.Font = new System.Drawing.Font("MS PGothic", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchError.ForeColor = System.Drawing.Color.Red;
            this.labelSearchError.Location = new System.Drawing.Point(324, 55);
            this.labelSearchError.Name = "labelSearchError";
            this.labelSearchError.Size = new System.Drawing.Size(285, 25);
            this.labelSearchError.TabIndex = 25;
            this.labelSearchError.Text = "LOCATION NOT FOUND!";
            this.labelSearchError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::Weather_App.Properties.Resources.icon;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSearch.Location = new System.Drawing.Point(615, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(43, 40);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseClick);
            // 
            // WeatherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelSearchError);
            this.Controls.Add(this.labelRange);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.pictureDay7);
            this.Controls.Add(this.pictureDay6);
            this.Controls.Add(this.pictureDay5);
            this.Controls.Add(this.pictureDay4);
            this.Controls.Add(this.pictureDay3);
            this.Controls.Add(this.pictureDay2);
            this.Controls.Add(this.pictureDay1);
            this.Controls.Add(this.labelStat7);
            this.Controls.Add(this.labelStat6);
            this.Controls.Add(this.labelStat5);
            this.Controls.Add(this.labelStat4);
            this.Controls.Add(this.labelStat3);
            this.Controls.Add(this.labelStat2);
            this.Controls.Add(this.labelStat1);
            this.Controls.Add(this.labelDay7);
            this.Controls.Add(this.labelDay6);
            this.Controls.Add(this.labelDay5);
            this.Controls.Add(this.labelDay4);
            this.Controls.Add(this.labelDay3);
            this.Controls.Add(this.labelDay2);
            this.Controls.Add(this.labelDay1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.CurrentWeatherStats);
            this.Name = "WeatherControl";
            this.Size = new System.Drawing.Size(891, 585);
            this.Load += new System.EventHandler(this.WeatherControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDay7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentWeatherStats;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Label labelDay1;
        private System.Windows.Forms.Label labelDay2;
        private System.Windows.Forms.Label labelDay3;
        private System.Windows.Forms.Label labelDay4;
        private System.Windows.Forms.Label labelDay5;
        private System.Windows.Forms.Label labelDay6;
        private System.Windows.Forms.Label labelDay7;
        private System.Windows.Forms.Label labelStat1;
        private System.Windows.Forms.Label labelStat2;
        private System.Windows.Forms.Label labelStat3;
        private System.Windows.Forms.Label labelStat4;
        private System.Windows.Forms.Label labelStat5;
        private System.Windows.Forms.Label labelStat6;
        private System.Windows.Forms.Label labelStat7;
        private System.Windows.Forms.PictureBox pictureDay1;
        private System.Windows.Forms.PictureBox pictureDay2;
        private System.Windows.Forms.PictureBox pictureDay3;
        private System.Windows.Forms.PictureBox pictureDay4;
        private System.Windows.Forms.PictureBox pictureDay5;
        private System.Windows.Forms.PictureBox pictureDay6;
        private System.Windows.Forms.PictureBox pictureDay7;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label labelRange;
        private System.Windows.Forms.Label labelSearchError;
        private System.Windows.Forms.Button buttonSearch;
    }
}
