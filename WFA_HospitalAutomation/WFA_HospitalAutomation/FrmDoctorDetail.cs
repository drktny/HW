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
    public partial class FrmDoctorDetail : Form
    {
        public FrmDoctorDetail()
        {
            InitializeComponent();
        }
        public string TCno;
        SqlConnect connect = new SqlConnect();
        private void FrmDoctorDetail_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCno;
            SqlCommand command = new SqlCommand("Select DoctorName, DoctorSurname from Tbll_Doctors where DoctorTC=@p1", connect.connection());
            command.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblNameSurname.Text = dr[0] + " " + dr[1];
            }

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments where AppointmentDoctor='" + lblNameSurname.Text + "'", connect.connection());
            da.Fill(dt);
            dtAppointments.DataSource = dt;
            connect.connection().Close();

        }

        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            FrmDoctorEditInfo frm = new FrmDoctorEditInfo();
            frm.TCNo = TCno;
            frm.Show();
        }

        private void btnAnnouncements_Click(object sender, EventArgs e)
        {
            FrmAnnouncements frAnn = new FrmAnnouncements();
            frAnn.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dtAppointments.SelectedCells[0].RowIndex;
            rchComplaint.Text = dtAppointments.Rows[selected].Cells[7].Value.ToString();
        }
    }
}
