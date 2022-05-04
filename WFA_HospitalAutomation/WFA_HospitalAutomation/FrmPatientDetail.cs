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
    public partial class FrmPatientDetail : Form
    {
        public FrmPatientDetail()
        {
            InitializeComponent();
        }
        public string tc;

        SqlConnect connect = new SqlConnect();
        private void FrmPatientDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            //getting Patient's Name and Surname from db where Ids are match.
            SqlCommand command = new SqlCommand("Select PatientName, PatientSurname from Tbl_Patients where PatientTc = @p1",connect.connection());
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0] + " " + dr[1];
            }
            connect.connection().Close();

            //Appointment History
            //For filling dataGridview, it's not necessary opening or closing db connection.
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where PatientTC=" +tc,connect.connection());
            da.Fill(dt);
            dtAppointmentHistory.DataSource = dt;

            //Pulling existed Branches
            SqlCommand command1 = new SqlCommand("Select BranchName from Tbll_Branches", connect.connection());
            SqlDataReader dr1 = command1.ExecuteReader();
            while (dr1.Read())
            {
                cmbBranch.Items.Add(dr1[0]);
            }
            connect.connection().Close();
        }
    }
}
