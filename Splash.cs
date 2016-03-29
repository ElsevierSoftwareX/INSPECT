using SampleWizard.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SampleWizard
{
    public partial class Splash : Form
    {
        int ticks = 0;
        public Splash()
        {
            InitializeComponent();

        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            // Ask user to agree on licenses 
            if (!settings.idarc_lic)
            {
                IDARC_LIC id = new IDARC_LIC();
                id.ShowDialog();
            }
            if (!settings.inspect_lic)
            {
                INSPECT_LIC id = new INSPECT_LIC();
                id.ShowDialog();
            }
            // check licenses 
            settings.Reload();
            if (!settings.idarc_lic)
            {
                Application.Exit();
                return;
            }
            if (!settings.inspect_lic)
            {
                Application.Exit();
                return;
            }
            timer1.Enabled = true;
            txt_version.Text = Application.ProductVersion;
            txt_cp.Text = DateTime.Now.Year.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if(ticks==100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                timer1.Dispose();
                try
                {
                    if (Limits.LastDay == DateTime.MaxValue)
                    {
                        Limits.CurrentDay = DateTime.Now;
                    }
                    else
                    {
                        Limits.CurrentDay = NtpClient.GetNetworkTime();
                    }
                    if (Limits.CurrentDay == null)
                    {
                        MessageBox.Show("You have to be connected to the internet to run this evaluation version of the software");
                        Application.Exit();
                    }
                    else if (Limits.CurrentDay.CompareTo(Limits.LastDay) > 0)
                    {
                        MessageBox.Show("Evaluation version expired");
                        Application.Exit();
                    }
                    else
                    {
                        //ProgramMode MainForm = new ProgramMode();
                       // MainForm.Text = " INSPECT";
                        //MainForm.Show();
                        Form1 f1 = new Form1();
                        f1.Show();
                    }
                }
                catch
                {
                    MessageBox.Show("You have to be connected to the internet to run this evaluation version of the software");
                    Application.Exit();
                }
              
                this.Dispose(false);
                return;
            }
            pb_loading.Value = ticks;
            ticks++;

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
