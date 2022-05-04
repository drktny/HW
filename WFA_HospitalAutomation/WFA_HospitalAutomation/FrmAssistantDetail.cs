using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_HospitalAutomation
{
    public partial class FrmAssistantDetail : Form
    {
        public FrmAssistantDetail()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlConnect connect = new SqlConnect();
        private void FrmAssistantDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCno;
            //NameSurname query
            SqlCommand command = new SqlCommand("Select AssistantNameSurname from Tbl_Assistants where AssistantTC=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0].ToString();
            }
            connect.connection().Close();

            //pulling branch datas to datagridview

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbll_Branches", connect.connection());
            da1.Fill(dt1);
            dtBranches.DataSource = dt1;

            //Fill Doctor Table
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoctorName + ' ' + DoctorSurname) as Doctor, DoctorBranch as Branch from Tbll_Doctors", connect.connection());
            da2.Fill(dt2);
            dtDoctors.DataSource = dt2;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand commandSave = new SqlCommand("insert into Tbl_Appointments (AppointmentDate,AppointmentHour,AppointmentBranch,AppointmentDoctor) values (@a1,@a2,@a3,@a4)", connect.connection());
            commandSave.Parameters.AddWithValue("@a1", mskDate.Text);
            commandSave.Parameters.AddWithValue("@a2", mskHour.Text);
            commandSave.Parameters.AddWithValue("@a3", cmbBranch.Text);
            commandSave.Parameters.AddWithValue("@a4", cmbDoctor.Text);
            commandSave.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Appointment is succesfully added to db.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
