using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFA_HospitalAutomation
{
    public partial class FrmDoctorLogin : Form
    {
        public FrmDoctorLogin()
        {
            InitializeComponent();
        }
        SqlConnect connect = new SqlConnect();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbll_Doctors where DoctorTC=@d1 and DoctorPassword=@d2", connect.connection());
            command.Parameters.AddWithValue("@d1", mskTC.Text);
            command.Parameters.AddWithValue("@d2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmDoctorDetail frm = new FrmDoctorDetail();
                frm.TCno = mskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TC or password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
