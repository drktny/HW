
namespace WFA_HospitalAutomation
{
    partial class FrmAppointmentList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAppointmentList));
            this.dtAppointmentList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtAppointmentList
            // 
            this.dtAppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtAppointmentList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtAppointmentList.Location = new System.Drawing.Point(0, 0);
            this.dtAppointmentList.Name = "dtAppointmentList";
            this.dtAppointmentList.RowHeadersWidth = 51;
            this.dtAppointmentList.RowTemplate.Height = 24;
            this.dtAppointmentList.Size = new System.Drawing.Size(1190, 688);
            this.dtAppointmentList.TabIndex = 0;
            this.dtAppointmentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtAppointmentList_CellDoubleClick);
            // 
            // FrmAppointmentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1190, 688);
            this.Controls.Add(this.dtAppointmentList);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmAppointmentList";
            this.Text = "Appointment List";
            this.Load += new System.EventHandler(this.FrmAppointmentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtAppointmentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtAppointmentList;
    }
}