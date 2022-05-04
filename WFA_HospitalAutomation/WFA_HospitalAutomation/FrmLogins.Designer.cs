
namespace WFA_HospitalAutomation
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.btnPatientLogin = new System.Windows.Forms.Button();
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.btnAssistantLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatientLogin
            // 
            this.btnPatientLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPatientLogin.BackgroundImage")));
            this.btnPatientLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatientLogin.Location = new System.Drawing.Point(84, 383);
            this.btnPatientLogin.Name = "btnPatientLogin";
            this.btnPatientLogin.Size = new System.Drawing.Size(283, 229);
            this.btnPatientLogin.TabIndex = 0;
            this.btnPatientLogin.UseVisualStyleBackColor = true;
            this.btnPatientLogin.Click += new System.EventHandler(this.btnPatientLogin_Click);
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoctorLogin.BackgroundImage")));
            this.btnDoctorLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctorLogin.Location = new System.Drawing.Point(442, 383);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(283, 229);
            this.btnDoctorLogin.TabIndex = 0;
            this.btnDoctorLogin.UseVisualStyleBackColor = true;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // btnAssistantLogin
            // 
            this.btnAssistantLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssistantLogin.BackgroundImage")));
            this.btnAssistantLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssistantLogin.Location = new System.Drawing.Point(812, 383);
            this.btnAssistantLogin.Name = "btnAssistantLogin";
            this.btnAssistantLogin.Size = new System.Drawing.Size(283, 229);
            this.btnAssistantLogin.TabIndex = 0;
            this.btnAssistantLogin.UseVisualStyleBackColor = true;
            this.btnAssistantLogin.Click += new System.EventHandler(this.btnAssistantLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 635);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(900, 635);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Assistant";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 51);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tonya Hospital";
            // 
            // FrmLogins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1204, 686);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAssistantLogin);
            this.Controls.Add(this.btnDoctorLogin);
            this.Controls.Add(this.btnPatientLogin);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmLogins";
            this.Text = "Tonya Hospital Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientLogin;
        private System.Windows.Forms.Button btnDoctorLogin;
        private System.Windows.Forms.Button btnAssistantLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

