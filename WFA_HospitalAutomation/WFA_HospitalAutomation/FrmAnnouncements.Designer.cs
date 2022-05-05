
namespace WFA_HospitalAutomation
{
    partial class FrmAnnouncements
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
            this.dtAnnouncements = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtAnnouncements)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAnnouncements
            // 
            this.dtAnnouncements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAnnouncements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtAnnouncements.Location = new System.Drawing.Point(0, 0);
            this.dtAnnouncements.Name = "dtAnnouncements";
            this.dtAnnouncements.RowHeadersWidth = 51;
            this.dtAnnouncements.RowTemplate.Height = 24;
            this.dtAnnouncements.Size = new System.Drawing.Size(907, 481);
            this.dtAnnouncements.TabIndex = 0;
            // 
            // FrmAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 481);
            this.Controls.Add(this.dtAnnouncements);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAnnouncements";
            this.Text = "FrmAnnouncements";
            this.Load += new System.EventHandler(this.FrmAnnouncements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAnnouncements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtAnnouncements;
    }
}