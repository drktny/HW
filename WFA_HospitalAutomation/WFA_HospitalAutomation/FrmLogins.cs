using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HospitalAutomation
{
    public partial class FrmLogins : Form
    {
        public FrmLogins()
        {
            InitializeComponent();
        }

        private void btnPatientLogin_Click(object sender, EventArgs e)
        {
            FrmPatientLogin frm = new FrmPatientLogin();
            frm.Show();
            this.Hide();
        }

        private void btnDoctorLogin_Click(object sender, EventArgs e)
        {
            FrmDoctorLogin frm = new FrmDoctorLogin();
            frm.Show();
            this.Hide();
        }

        private void btnAssistantLogin_Click(object sender, EventArgs e)
        {
            FrmAssistantLogin frm = new FrmAssistantLogin();
            frm.Show();
            this.Hide();
        }
    }
}
