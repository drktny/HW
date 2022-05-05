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
    public partial class FrmDoctorEditInfo : Form
    {

        public FrmDoctorEditInfo()
        {
            InitializeComponent();
        }
        SqlConnect connect = new SqlConnect();
        public string TCNo;

        private void FrmDoctorEditInfo_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCNo;
            SqlCommand command = new SqlCommand("Select * from Tbll_Doctors where DoctorTC='" + mskTC.Text + "'", connect.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                cmbBranch.Text = dr[3].ToString();
                txtPassword.Text = dr[5].ToString();
            }
            connect.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbll_Doctors set DoctorName=@d2,DoctorSurname=@d3,DoctorBranch=@d4,DoctorPassword=@d5 where DoctorTC=@d1", connect.connection());
            command.Parameters.AddWithValue("@d1", mskTC.Text);
            command.Parameters.AddWithValue("@d2", txtName.Text);
            command.Parameters.AddWithValue("@d3", txtSurname.Text);
            command.Parameters.AddWithValue("@d4", cmbBranch.Text);
            command.Parameters.AddWithValue("@d5", txtPassword.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Infos are succesfully updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
