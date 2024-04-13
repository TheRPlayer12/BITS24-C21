namespace BITS24_C21
{
    partial class RainVine
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RainVine));
            pictureBox1 = new PictureBox();
            CityNameTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            CityNameLbl = new Label();
            label4 = new Label();
            SubmitBtn = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            HumidLbl = new Label();
            WindSpLbl = new Label();
            TempLbl = new Label();
            WeatherLbl = new Label();
            FeelsLikeLbl = new Label();
            label9 = new Label();
            SunriseLbl = new Label();
            label10 = new Label();
            label11 = new Label();
            SunsetLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._4b8fa90b8cabcd4a0ec4f82122913da1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // CityNameTxt
            // 
            CityNameTxt.BackColor = Color.FromArgb(64, 64, 64);
            CityNameTxt.BorderStyle = BorderStyle.None;
            CityNameTxt.Font = new Font("Segoe UI", 12F);
            CityNameTxt.ForeColor = SystemColors.Window;
            CityNameTxt.Location = new Point(572, 118);
            CityNameTxt.Name = "CityNameTxt";
            CityNameTxt.Size = new Size(216, 22);
            CityNameTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(168, 12);
            label1.Name = "label1";
            label1.Size = new Size(159, 46);
            label1.TabIndex = 2;
            label1.Text = "Rain Vine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(168, 58);
            label2.Name = "label2";
            label2.Size = new Size(436, 28);
            label2.TabIndex = 3;
            label2.Text = "Accurate weather information at your finger tips!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(168, 119);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 4;
            label3.Text = "Current City :";
            // 
            // CityNameLbl
            // 
            CityNameLbl.AutoSize = true;
            CityNameLbl.Font = new Font("Segoe UI", 12F);
            CityNameLbl.ForeColor = Color.FromArgb(255, 128, 0);
            CityNameLbl.Location = new Point(275, 119);
            CityNameLbl.Name = "CityNameLbl";
            CityNameLbl.Size = new Size(80, 21);
            CityNameLbl.TabIndex = 5;
            CityNameLbl.Text = "City name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(572, 100);
            label4.Name = "label4";
            label4.Size = new Size(112, 15);
            label4.TabIndex = 6;
            label4.Text = "Enter you city name";
            // 
            // SubmitBtn
            // 
            SubmitBtn.BackColor = Color.Black;
            SubmitBtn.FlatAppearance.BorderSize = 0;
            SubmitBtn.ForeColor = SystemColors.Window;
            SubmitBtn.Location = new Point(275, 162);
            SubmitBtn.Name = "SubmitBtn";
            SubmitBtn.Size = new Size(251, 41);
            SubmitBtn.TabIndex = 7;
            SubmitBtn.Text = "Get Weather Information";
            SubmitBtn.UseVisualStyleBackColor = false;
            SubmitBtn.Click += SubmitBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(525, 291);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 8;
            label5.Text = "Temperature";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 312);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 9;
            label6.Text = "Wind Speed";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 281);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 10;
            label7.Text = "Humidity";
            // 
            // HumidLbl
            // 
            HumidLbl.AutoSize = true;
            HumidLbl.Font = new Font("Segoe UI", 12F);
            HumidLbl.ForeColor = Color.FromArgb(255, 128, 0);
            HumidLbl.Location = new Point(137, 281);
            HumidLbl.Name = "HumidLbl";
            HumidLbl.Size = new Size(74, 21);
            HumidLbl.TabIndex = 13;
            HumidLbl.Text = "Humidity";
            // 
            // WindSpLbl
            // 
            WindSpLbl.AutoSize = true;
            WindSpLbl.Font = new Font("Segoe UI", 12F);
            WindSpLbl.ForeColor = Color.FromArgb(255, 128, 0);
            WindSpLbl.Location = new Point(137, 312);
            WindSpLbl.Name = "WindSpLbl";
            WindSpLbl.Size = new Size(94, 21);
            WindSpLbl.TabIndex = 12;
            WindSpLbl.Text = "Wind Speed";
            // 
            // TempLbl
            // 
            TempLbl.Font = new Font("Segoe UI", 35F);
            TempLbl.ForeColor = Color.FromArgb(255, 128, 0);
            TempLbl.Location = new Point(484, 322);
            TempLbl.Name = "TempLbl";
            TempLbl.Size = new Size(200, 62);
            TempLbl.TabIndex = 11;
            TempLbl.Text = "0°C";
            TempLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WeatherLbl
            // 
            WeatherLbl.Font = new Font("Segoe UI", 15F);
            WeatherLbl.Location = new Point(214, 220);
            WeatherLbl.Name = "WeatherLbl";
            WeatherLbl.Size = new Size(377, 28);
            WeatherLbl.TabIndex = 14;
            WeatherLbl.Text = "It is currently weather in city";
            WeatherLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FeelsLikeLbl
            // 
            FeelsLikeLbl.Font = new Font("Segoe UI", 12F);
            FeelsLikeLbl.ForeColor = Color.FromArgb(255, 128, 0);
            FeelsLikeLbl.Location = new Point(597, 395);
            FeelsLikeLbl.Name = "FeelsLikeLbl";
            FeelsLikeLbl.Size = new Size(77, 21);
            FeelsLikeLbl.TabIndex = 16;
            FeelsLikeLbl.Text = "0°C";
            FeelsLikeLbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(514, 395);
            label9.Name = "label9";
            label9.Size = new Size(77, 21);
            label9.TabIndex = 15;
            label9.Text = "Feels Like";
            // 
            // SunriseLbl
            // 
            SunriseLbl.AutoSize = true;
            SunriseLbl.Font = new Font("Segoe UI", 12F);
            SunriseLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SunriseLbl.Location = new Point(137, 343);
            SunriseLbl.Name = "SunriseLbl";
            SunriseLbl.Size = new Size(60, 21);
            SunriseLbl.TabIndex = 18;
            SunriseLbl.Text = "sunrise";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(12, 343);
            label10.Name = "label10";
            label10.Size = new Size(62, 21);
            label10.TabIndex = 17;
            label10.Text = "Sunrise";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(12, 373);
            label11.Name = "label11";
            label11.Size = new Size(57, 21);
            label11.TabIndex = 19;
            label11.Text = "Sunset";
            // 
            // SunsetLbl
            // 
            SunsetLbl.AutoSize = true;
            SunsetLbl.Font = new Font("Segoe UI", 12F);
            SunsetLbl.ForeColor = Color.FromArgb(255, 128, 0);
            SunsetLbl.Location = new Point(137, 373);
            SunsetLbl.Name = "SunsetLbl";
            SunsetLbl.Size = new Size(55, 21);
            SunsetLbl.TabIndex = 20;
            SunsetLbl.Text = "sunset";
            // 
            // RainVine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(SunsetLbl);
            Controls.Add(label11);
            Controls.Add(SunriseLbl);
            Controls.Add(label10);
            Controls.Add(FeelsLikeLbl);
            Controls.Add(label9);
            Controls.Add(WeatherLbl);
            Controls.Add(HumidLbl);
            Controls.Add(WindSpLbl);
            Controls.Add(TempLbl);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(SubmitBtn);
            Controls.Add(label4);
            Controls.Add(CityNameLbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CityNameTxt);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RainVine";
            Text = "Rain Vine";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox CityNameTxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label CityNameLbl;
        private Label label4;
        private Button SubmitBtn;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label HumidLbl;
        private Label WindSpLbl;
        private Label TempLbl;
        private Label WeatherLbl;
        private Label FeelsLikeLbl;
        private Label label9;
        private Label SunriseLbl;
        private Label label10;
        private Label label11;
        private Label SunsetLbl;
    }
}
