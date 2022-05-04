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
    public partial class FrmPatientSignIn : Form
    {
        public FrmPatientSignIn()
        {
            InitializeComponent();
        }

        SqlConnect cnt = new SqlConnect();

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Patients (PatientName,PatientSurname,PatientTC,PatientPhone,PatientPassword,PatientGender) values (@p1,@p2,@p3,@p4,@p5,@p6)", cnt.connection());
            command.Parameters.AddWithValue("@p1", txtName.Text);
            command.Parameters.AddWithValue("@p2", txtSurname.Text);
            command.Parameters.AddWithValue("@p3", mskTC.Text);
            command.Parameters.AddWithValue("@p4", mskPhone.Text);
            command.Parameters.AddWithValue("@p5", txtPassword.Text);
            command.Parameters.AddWithValue("@p6", rdMale.Checked ? "Male" : "Fmale");
            command.ExecuteNonQuery();
            cnt.connection().Close();
            MessageBox.Show("You are succesfully signed in. Your password: " + txtPassword.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
