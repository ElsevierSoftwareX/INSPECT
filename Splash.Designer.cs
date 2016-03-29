namespace SampleWizard
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pb_loading = new ColorProgressBar.ColorProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_version = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_cp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pb_loading
            // 
            this.pb_loading.BackColor = System.Drawing.SystemColors.Control;
            this.pb_loading.BarColor = System.Drawing.Color.LightSkyBlue;
            this.pb_loading.BorderColor = System.Drawing.Color.Black;
            this.pb_loading.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Dashed;
            this.pb_loading.Location = new System.Drawing.Point(-3, 322);
            this.pb_loading.Maximum = 100;
            this.pb_loading.Minimum = 0;
            this.pb_loading.Name = "pb_loading";
            this.pb_loading.Size = new System.Drawing.Size(526, 12);
            this.pb_loading.Step = 10;
            this.pb_loading.TabIndex = 1;
            this.pb_loading.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Version : ";
            // 
            // txt_version
            // 
            this.txt_version.AutoSize = true;
            this.txt_version.BackColor = System.Drawing.Color.Transparent;
            this.txt_version.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_version.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_version.Location = new System.Drawing.Point(84, 434);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(26, 17);
            this.txt_version.TabIndex = 3;
            this.txt_version.Text = "1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(263, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "All rights reserved © 2014 - ";
            // 
            // txt_cp
            // 
            this.txt_cp.AutoSize = true;
            this.txt_cp.BackColor = System.Drawing.Color.Transparent;
            this.txt_cp.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_cp.Location = new System.Drawing.Point(431, 434);
            this.txt_cp.Name = "txt_cp";
            this.txt_cp.Size = new System.Drawing.Size(36, 17);
            this.txt_cp.TabIndex = 5;
            this.txt_cp.Text = "2015";
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 476);
            this.Controls.Add(this.txt_cp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_version);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Splash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ColorProgressBar.ColorProgressBar pb_loading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_cp;
    }
}