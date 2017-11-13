namespace btGIGSv2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelMainPage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxFPS = new System.Windows.Forms.TextBox();
            this.textBoxResolution = new System.Windows.Forms.TextBox();
            this.textBoxBitrateVideo = new System.Windows.Forms.TextBox();
            this.textBoxVideoCodec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Video = new System.Windows.Forms.ComboBox();
            this.comboBox_Audio = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxLng1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLng2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAudio2 = new System.Windows.Forms.ComboBox();
            this.comboBoxAudio1 = new System.Windows.Forms.ComboBox();
            this.comboBoxSubtitle = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelMainPage);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelMainPage
            // 
            this.labelMainPage.AutoSize = true;
            this.labelMainPage.Location = new System.Drawing.Point(18, 98);
            this.labelMainPage.Name = "labelMainPage";
            this.labelMainPage.Size = new System.Drawing.Size(0, 13);
            this.labelMainPage.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxSubtitle);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboBoxAudio2);
            this.tabPage2.Controls.Add(this.comboBoxAudio1);
            this.tabPage2.Controls.Add(this.comboBoxLng2);
            this.tabPage2.Controls.Add(this.comboBoxLng1);
            this.tabPage2.Controls.Add(this.textBoxTime);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxFPS);
            this.tabPage2.Controls.Add(this.textBoxResolution);
            this.tabPage2.Controls.Add(this.textBoxBitrateVideo);
            this.tabPage2.Controls.Add(this.textBoxVideoCodec);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.comboBox_Video);
            this.tabPage2.Controls.Add(this.comboBox_Audio);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.textBoxName);
            this.tabPage2.Controls.Add(this.labelName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Info";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxFPS
            // 
            this.textBoxFPS.Location = new System.Drawing.Point(104, 325);
            this.textBoxFPS.Name = "textBoxFPS";
            this.textBoxFPS.Size = new System.Drawing.Size(154, 20);
            this.textBoxFPS.TabIndex = 49;
            // 
            // textBoxResolution
            // 
            this.textBoxResolution.Location = new System.Drawing.Point(104, 289);
            this.textBoxResolution.Name = "textBoxResolution";
            this.textBoxResolution.Size = new System.Drawing.Size(154, 20);
            this.textBoxResolution.TabIndex = 47;
            // 
            // textBoxBitrateVideo
            // 
            this.textBoxBitrateVideo.Location = new System.Drawing.Point(104, 253);
            this.textBoxBitrateVideo.Name = "textBoxBitrateVideo";
            this.textBoxBitrateVideo.Size = new System.Drawing.Size(154, 20);
            this.textBoxBitrateVideo.TabIndex = 45;
            // 
            // textBoxVideoCodec
            // 
            this.textBoxVideoCodec.Location = new System.Drawing.Point(104, 218);
            this.textBoxVideoCodec.Name = "textBoxVideoCodec";
            this.textBoxVideoCodec.Size = new System.Drawing.Size(154, 20);
            this.textBoxVideoCodec.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Frame rate:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Resolution:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Bit rate video:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Video codec:";
            // 
            // comboBox_Video
            // 
            this.comboBox_Video.FormattingEnabled = true;
            this.comboBox_Video.Location = new System.Drawing.Point(104, 140);
            this.comboBox_Video.Name = "comboBox_Video";
            this.comboBox_Video.Size = new System.Drawing.Size(154, 21);
            this.comboBox_Video.TabIndex = 41;
            // 
            // comboBox_Audio
            // 
            this.comboBox_Audio.FormattingEnabled = true;
            this.comboBox_Audio.Location = new System.Drawing.Point(389, 142);
            this.comboBox_Audio.Name = "comboBox_Audio";
            this.comboBox_Audio.Size = new System.Drawing.Size(154, 21);
            this.comboBox_Audio.TabIndex = 40;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(309, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "Audio:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Video:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(18, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "RELEASE  SPECIFICATION";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 68);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 20);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Release Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(17, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "SOURCE";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(61, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(481, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(17, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name:";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 468);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Web";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(626, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Other";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(626, 468);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Code";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(104, 440);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(154, 20);
            this.textBoxTime.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Time";
            // 
            // comboBoxLng1
            // 
            this.comboBoxLng1.FormattingEnabled = true;
            this.comboBoxLng1.Items.AddRange(new object[] {
            "1: Language",
            "2: Language",
            "3: Language"});
            this.comboBoxLng1.Location = new System.Drawing.Point(300, 248);
            this.comboBoxLng1.Name = "comboBoxLng1";
            this.comboBoxLng1.Size = new System.Drawing.Size(83, 21);
            this.comboBoxLng1.TabIndex = 52;
            // 
            // comboBoxLng2
            // 
            this.comboBoxLng2.FormattingEnabled = true;
            this.comboBoxLng2.Location = new System.Drawing.Point(389, 248);
            this.comboBoxLng2.Name = "comboBoxLng2";
            this.comboBoxLng2.Size = new System.Drawing.Size(154, 21);
            this.comboBoxLng2.TabIndex = 53;
            // 
            // comboBoxAudio2
            // 
            this.comboBoxAudio2.FormattingEnabled = true;
            this.comboBoxAudio2.Location = new System.Drawing.Point(388, 217);
            this.comboBoxAudio2.Name = "comboBoxAudio2";
            this.comboBoxAudio2.Size = new System.Drawing.Size(154, 21);
            this.comboBoxAudio2.TabIndex = 55;
            // 
            // comboBoxAudio1
            // 
            this.comboBoxAudio1.FormattingEnabled = true;
            this.comboBoxAudio1.Items.AddRange(new object[] {
            "1: Audio",
            "2: Audio"});
            this.comboBoxAudio1.Location = new System.Drawing.Point(299, 217);
            this.comboBoxAudio1.Name = "comboBoxAudio1";
            this.comboBoxAudio1.Size = new System.Drawing.Size(83, 21);
            this.comboBoxAudio1.TabIndex = 54;
            // 
            // comboBoxSubtitle
            // 
            this.comboBoxSubtitle.FormattingEnabled = true;
            this.comboBoxSubtitle.Location = new System.Drawing.Point(388, 292);
            this.comboBoxSubtitle.Name = "comboBoxSubtitle";
            this.comboBoxSubtitle.Size = new System.Drawing.Size(154, 21);
            this.comboBoxSubtitle.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Subtitle:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 495);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMainPage;
        private System.Windows.Forms.ComboBox comboBox_Video;
        private System.Windows.Forms.ComboBox comboBox_Audio;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBoxFPS;
        private System.Windows.Forms.TextBox textBoxResolution;
        private System.Windows.Forms.TextBox textBoxBitrateVideo;
        private System.Windows.Forms.TextBox textBoxVideoCodec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxLng1;
        private System.Windows.Forms.ComboBox comboBoxLng2;
        private System.Windows.Forms.ComboBox comboBoxAudio2;
        private System.Windows.Forms.ComboBox comboBoxAudio1;
        private System.Windows.Forms.ComboBox comboBoxSubtitle;
        private System.Windows.Forms.Label label12;
    }
}

