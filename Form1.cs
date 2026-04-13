using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace frmbkavhome
{
    public partial class Form1 : Form
    {
        private int countdownSeconds = 5;
        private System.Windows.Forms.Timer countdownTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lấy ngày giờ hệ thống
            this.Text = "BKAV Home Uninstaller Support Tool - " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //phát hiện bkav home đã cài đặt chưa

            if (File.Exists(@"C:\Program Files (x86)\BkavHome\BkavHome.exe"))
            {
                label1.Text = "BKAV Home version is installed";
                btnremove.Enabled = true;
            }
            else
            {
                label1.Text = "BKAV Home version is not installed.";
                btnremove.Enabled = false;
                StartCountdown();
            }

            try
            {
                string r = "";
                using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem"))
                {
                    ManagementObjectCollection information = searcher.Get();
                    if (information != null)
                    {
                        foreach (ManagementObject obj in information)
                        {
                            r = obj["Caption"].ToString() + " - " + obj["OSArchitecture"].ToString();
                        }
                    }
                    r = r.Replace("NT 5.1.2600", "XP");
                    r = r.Replace("NT 5.2.3790", "Server 2003");
                    lblsys.Text = r;
                }
            }
            catch (Exception ex)
            {
                lblsys.Text = "Unable to retrieve OS information: " + ex.Message;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            if (countdownTimer != null)
            {
                countdownTimer.Stop();
                countdownTimer.Dispose();
            }
        }

        private void StartCountdown()
        {
            countdownSeconds = 5;
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdownSeconds > 0)
            {
                label1.Text = $"BKAV Home version is not installed. Auto exit in {countdownSeconds} seconds...";
                countdownSeconds--;
            }
            else
            {
                countdownTimer.Stop();
                countdownTimer.Dispose();
                Application.Exit();
            }
        }

        private void btnesc_Click(object sender, EventArgs e)
        {
            //thoát
            Application.Exit();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Program Files (x86)\BkavHome\BkavHomeUnst.exe";
            if (File.Exists(dir))
            {
                try
                {
                    Process process = Process.Start(dir);
                    process.WaitForExit();
                    MessageBox.Show("BKAV Home uninstalled successfully. Please click Delete Leftover Button.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("BKAV Home version is not installed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmdonate frmdonate = new frmdonate();
            frmdonate.Show();
        }
    }
}
