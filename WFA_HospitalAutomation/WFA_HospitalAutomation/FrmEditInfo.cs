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
    public partial class FrmEditInfo : Form
    {
        public FrmEditInfo()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlConnect connect = new SqlConnect();
        private void FrmEditInfo_Load(object sender, EventArgs e)
        {
            mskTC.Text = TCno;
            SqlCommand command = new SqlCommand("Select * from Tbl_Patients where PatientTC=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtName.Text = dr[1].ToString();
                txtSurname.Text = dr[2].ToString();
                mskPhone.Text = dr[4].ToString();
                txtPassword.Text = dr[5].ToString();
                if(dr[6].ToString() == "Male")
                {
                    rdMale.Checked = true;
                }
                else
                {
                    rdFemale.Checked = true;
                }

                connect.connection().Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command1 = new SqlCommand("Update Tbl_Patients set PatientName=@p1,PatientSurname=@p2,PatientPhone=@p3,PatientPassword=@p4,PatientGender=@p5 where PatientTC=@p6",connect.connection());
            command1.Parameters.AddWithValue("@p1", txtName.Text);
            command1.Parameters.AddWithValue("@p2", txtSurname.Text);
            command1.Parameters.AddWithValue("@p3", mskPhone.Text);
            command1.Parameters.AddWithValue("@p4", txtPassword.Text);
            command1.Parameters.AddWithValue("@p5", rdMale.Checked ? "Male" : "Fmale");
            command1.Parameters.AddWithValue("@p6", mskTC.Text);
            command1.ExecuteNonQuery(); //for insert,update & delete processes
            connect.connection().Close();
            MessageBox.Show("Your informations are succesfully update!", "Info",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
