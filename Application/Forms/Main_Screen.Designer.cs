
namespace AutoShutdown
{
    partial class Main_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Screen));
            this.userControl22 = new AutoControlLibrary2.UserControl2();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.userControl14 = new AutoControlLibrary1.UserControl1();
            this.userControl15 = new AutoControlLibrary1.UserControl1();
            this.userControl16 = new AutoControlLibrary1.UserControl1();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // userControl22
            // 
            this.userControl22.BorderColor = System.Drawing.Color.SandyBrown;
            this.userControl22.ButtonColor = System.Drawing.Color.Peru;
            this.userControl22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userControl22.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.userControl22.ForeColor = System.Drawing.Color.Orange;
            this.userControl22.Location = new System.Drawing.Point(174, 313);
            this.userControl22.Name = "userControl22";
            this.userControl22.OnHoverBorderColor = System.Drawing.Color.Gold;
            this.userControl22.OnHoverButtonColor = System.Drawing.Color.DarkOrange;
            this.userControl22.OnHoverTextColor = System.Drawing.Color.Black;
            this.userControl22.Size = new System.Drawing.Size(126, 54);
            this.userControl22.TabIndex = 0;
            this.userControl22.Text = "Start/Stop";
            this.userControl22.TextColor = System.Drawing.SystemColors.WindowFrame;
            this.userControl22.UseVisualStyleBackColor = true;
            this.userControl22.Click += new System.EventHandler(this.userControl22_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "İlerleme:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(88, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "0%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 344);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(156, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // userControl14
            // 
            this.userControl14.BackColor = System.Drawing.Color.Orange;
            this.userControl14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userControl14.BottomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl14.BottomBorderFocusColor = System.Drawing.Color.Gold;
            this.userControl14.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.userControl14.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userControl14.Location = new System.Drawing.Point(12, 216);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(78, 27);
            this.userControl14.TabIndex = 5;
            this.userControl14.Text = "Dakika";
            this.userControl14.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userControl14_MouseClick);
            this.userControl14.TextChanged += new System.EventHandler(this.userControl14_TextChanged);
            this.userControl14.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userControl14_KeyPress);
            // 
            // userControl15
            // 
            this.userControl15.BackColor = System.Drawing.Color.Orange;
            this.userControl15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userControl15.BottomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl15.BottomBorderFocusColor = System.Drawing.Color.Gold;
            this.userControl15.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.userControl15.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userControl15.Location = new System.Drawing.Point(108, 216);
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(78, 27);
            this.userControl15.TabIndex = 6;
            this.userControl15.Text = "Saat";
            this.userControl15.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userControl15_MouseClick);
            this.userControl15.TextChanged += new System.EventHandler(this.userControl15_TextChanged);
            this.userControl15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userControl15_KeyPress);
            // 
            // userControl16
            // 
            this.userControl16.BackColor = System.Drawing.Color.Orange;
            this.userControl16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userControl16.BottomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.userControl16.BottomBorderFocusColor = System.Drawing.Color.Gold;
            this.userControl16.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.userControl16.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.userControl16.Location = new System.Drawing.Point(207, 216);
            this.userControl16.Name = "userControl16";
            this.userControl16.Size = new System.Drawing.Size(78, 27);
            this.userControl16.TabIndex = 7;
            this.userControl16.Text = "Yıl";
            this.userControl16.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userControl16_MouseClick);
            this.userControl16.TextChanged += new System.EventHandler(this.userControl16_TextChanged);
            this.userControl16.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userControl16_KeyPress);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox6.Location = new System.Drawing.Point(9, 259);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(73, 25);
            this.checkBox6.TabIndex = 8;
            this.checkBox6.Text = "Kapat";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox5.Location = new System.Drawing.Point(150, 259);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(69, 25);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Uyku";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox4.Location = new System.Drawing.Point(9, 290);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(141, 25);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Yeniden Başlat";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(275, -1);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 35);
            this.button3.TabIndex = 17;
            this.button3.Tag = "";
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox2.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 35);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseMove);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(202, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 35);
            this.button1.TabIndex = 19;
            this.button1.Tag = "";
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(186, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label4.Location = new System.Drawing.Point(88, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "/";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(238, -1);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 35);
            this.button2.TabIndex = 23;
            this.button2.Tag = "";
            this.button2.Text = "O";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Main_Screen
            // 
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(312, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.userControl16);
            this.Controls.Add(this.userControl15);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControl22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Screen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Main_Screen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AutoControlLibrary2.UserControl2 userControl22;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private AutoControlLibrary1.UserControl1 userControl14;
        private AutoControlLibrary1.UserControl1 userControl15;
        private AutoControlLibrary1.UserControl1 userControl16;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

