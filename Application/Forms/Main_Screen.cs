using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace AutoShutdown
{
    public partial class Main_Screen : Form
    {
        int checkbox_no = 0; bool cıkıs; bool move; int mouse_x, mouse_y;
        public Main_Screen()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }
        private void Main_Screen_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            progressBar1.Visible = false;
        }
        public void form_kilitle(bool deger)
        {
            userControl14.Enabled = deger;
            userControl15.Enabled = deger;
            userControl16.Enabled = deger;
            checkBox4.Enabled = deger;
            checkBox5.Enabled = deger;
            checkBox6.Enabled = deger;
        }
        private void userControl22_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                if (checkbox_no != 0)
                {
                    if (userControl14.Text != string.Empty || userControl15.Text != string.Empty || userControl16.Text != string.Empty)
                    {
                        DialogResult dialogResult = MessageBox.Show("Sayacı Başlatmak İstediğinize Eminmisiniz?", "AutoShotDown", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            if (int.TryParse(userControl14.Text, out _) != true && userControl14.Text != string.Empty)
                                userControl14.Text = string.Empty;
                            if (int.TryParse(userControl15.Text, out _) != true && userControl15.Text != string.Empty)
                                userControl15.Text = string.Empty;
                            if (int.TryParse(userControl16.Text, out _) != true && userControl16.Text != string.Empty)
                                userControl16.Text = string.Empty;
                            label2.Text = "0%";
                            progressBar1.Value = 0;
                            label1.Visible = true;
                            label2.Visible = true;
                            progressBar1.SetState(1);
                            progressBar1.Visible = true;
                            //kilitleme işlemi
                            form_kilitle(false);
                            //----
                            backgroundWorker1.RunWorkerAsync();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen AutoSutdown İçin Zaman Giriniz!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Yapılacak İşlemi Seçiniz!!!");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Sayacı iptal etmek istediğinize emin misiniz?", "AutoShotDown", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (backgroundWorker1.WorkerSupportsCancellation == true)
                    {
                        backgroundWorker1.CancelAsync();
                        MessageBox.Show("Geri Sayım İptal Edildi!!!", "AutoShotDown", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Environment.Exit(1);
                    }
                }
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            int tut = 0;
            if (userControl14.Text != string.Empty)
            {
                tut += Convert.ToInt32(userControl14.Text) * 60; // dakika dan saniye x * 60
            }
            if (userControl15.Text != string.Empty)
            {
                tut += Convert.ToInt32(userControl15.Text) * 60 * 60; // saat ten saniye x * 60 * 60
            }
            if (userControl16.Text != string.Empty)
            {
                tut += Convert.ToInt32(userControl16.Text) * 60 * 60 * 24; // gün den saniye x * 60 * 60 * 24
            }

            if (tut != 0)
            {
                try
                {
                    tut = tut / 20;
                    int time;
                    for (int j = 1; j <= 20; j++)
                    {
                        if (worker.CancellationPending == true)
                        {
                            e.Cancel = true;
                            break;
                        }
                        else
                        {
                            int i = tut;
                            while (true)
                            {
                                if (i > 0)
                                {
                                    if (worker.CancellationPending == true)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        if (i >= 5)
                                        {
                                            i = i - 5;
                                            time = 5;
                                        }
                                        else
                                        {
                                            time = i;
                                            i = 0;
                                        }
                                        System.Threading.Thread.Sleep((time * 1000));
                                        worker.ReportProgress(j * 5);
                                    }
                                }
                                else
                                    break;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Hata!!!");
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Hata!!! süre 0 değerinde");
                e.Cancel = true;
            }
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label2.Text = (e.ProgressPercentage.ToString() + "%");
            progressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                progressBar1.SetState(2);
                label2.Text = "Stopped";
                form_kilitle(true);
                MessageBox.Show("acıldı");
            }
            else
            {
                MessageBox.Show("Kpandı");
                /*
                label2.Text = "Done";
                try
                {
                    if (checkbox_no == 1)
                    {
                        System.Diagnostics.Process.Start("Shutdown.exe", "-s");
                    }
                    else if (checkbox_no == 2)
                    {
                        System.Diagnostics.Process.Start("Shutdown.exe", "-r");
                    }
                    else
                    {
                        Application.SetSuspendState(PowerState.Hibernate, true, true);
                    }
                }
                catch (Exception) {}
                Environment.Exit(1);
                */
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox5.Checked = false;
                checkBox4.Checked = false;
                checkbox_no = 1;
            }
            else
                checkbox_no = 0;
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox6.Checked = false;
                checkBox4.Checked = false;
                checkbox_no = 2;
            }
            else
                checkbox_no = 0;
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox6.Checked = false;
                checkBox5.Checked = false;
                checkbox_no = 3;
            }
            else
                checkbox_no = 0;
        }
        void only_numbers_on_textbox(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        private void userControl14_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_numbers_on_textbox(sender, e);
        }
        private void userControl15_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_numbers_on_textbox(sender, e);
        }
        private void userControl16_KeyPress(object sender, KeyPressEventArgs e)
        {
            only_numbers_on_textbox(sender, e);
        }
        private void userControl14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(userControl14.Text) > 60)
                {
                    userControl14.Text = "60";
                }
            }
            catch (Exception)
            {
                userControl14.Text = string.Empty;
            }
        }
        private void userControl15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(userControl15.Text) > 24)
                {
                    userControl15.Text = "24";
                }
            }
            catch (Exception)
            {
                userControl15.Text = string.Empty;
            }
        }
        private void userControl16_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(userControl16.TextLength) > 4)
                {
                    userControl16.Text = "9999";
                }
            }
            catch (Exception)
            {
                userControl16.Text = string.Empty;
            }
        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "AutoShutDown";
            notifyIcon1.BalloonTipTitle = "AutoShutDown uygulaması arka planda çalışıyor";
            notifyIcon1.BalloonTipText = "Program sağ alt köşede konumlandı.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(1500);
            notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void userControl14_MouseClick(object sender, MouseEventArgs e)
        {
            userControl14.Text = string.Empty;
        }

        private void userControl15_MouseClick(object sender, MouseEventArgs e)
        {
            userControl15.Text = string.Empty;
        }

        private void userControl16_MouseClick(object sender, MouseEventArgs e)
        {
            userControl16.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cıkıs = true;
            }
            if (cıkıs == true)
                Environment.Exit(1);
        }
    }
}
