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
    public partial class FrmPatientLogin : Form
    {
        public FrmPatientLogin()
        {
            InitializeComponent();
        }

        SqlConnect cnt = new SqlConnect();
        private void lnkSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmPatientSignIn frm = new FrmPatientSignIn();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1 and PatientPassword=@p2", cnt.connection());
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmPatientDetail frm = new FrmPatientDetail();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TC or Password!");
            }
            cnt.connection().Close();
        }
    }
}
