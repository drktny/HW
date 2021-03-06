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

            //Branches to combobox
            SqlCommand commandBranch = new SqlCommand("Select BranchName from Tbll_Branches", connect.connection());
            SqlDataReader dr1 = commandBranch.ExecuteReader();
            while (dr1.Read())
            {
                cmbBranch.Items.Add(dr1[0]);
            }
            connect.connection().Close();

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

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoctor.Items.Clear();

            SqlCommand command = new SqlCommand("Select (DoctorName + ' ' + DoctorSurname) from Tbll_Doctors where DoctorBranch=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbDoctor.Items.Add(dataReader[0]);
            }
            connect.connection().Close();

            #region Alternative
            /*
             cmbDoctor.Items.Clear();

            SqlCommand command = new SqlCommand("Select DoctorName,DoctorSurname from Tbll_Doctors where DoctorBranch=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", cmbBranch.Text);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbDoctor.Items.Add(dataReader[0] + ' ' + dataReader[1]);
            }
            connect.connection().Close();
             */
            #endregion
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbl_Announcements (Announcement) values (@d1)", connect.connection());
            command.Parameters.AddWithValue("@d1", rchAnnouncement.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("New announcement is added to db..", "Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoctorPanel_Click(object sender, EventArgs e)
        {
            FrmDoctorPanel drFrm = new FrmDoctorPanel();
            drFrm.Show();
        }

        private void btnBranchPanel_Click(object sender, EventArgs e)
        {
            FrmBranchPanel brFrm = new FrmBranchPanel();
            brFrm.Show();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            FrmAppointmentList appFrm = new FrmAppointmentList();
            appFrm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Appointments set AppointmentDate=@a2,AppointmentHour=@a3,AppointmentBranch=@a4,AppointmentDoctor=@a5,AppointmentStatus=@a6,PatientTC=@a7 where AppointmentId=@a1", connect.connection());
            command.Parameters.AddWithValue("@a1", Convert.ToInt32(txtId.Text));
            command.Parameters.AddWithValue("@a2", mskDate.Text);
            command.Parameters.AddWithValue("@a3", mskHour.Text);
            command.Parameters.AddWithValue("@a4", cmbBranch.Text);
            command.Parameters.AddWithValue("@a5", cmbDoctor.Text);
            command.Parameters.AddWithValue("@a6", chkStatus.Checked ? true : false);
            command.Parameters.AddWithValue("@a7", mskPatientTC.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Selected appointment is updated", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            connect.connection().Close();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements frm = new FrmAnnouncements();
            frm.Show();
        }
    }
}
