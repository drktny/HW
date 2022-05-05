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
    public partial class FrmAppointmentList : Form
    {
        public FrmAppointmentList()
        {
            InitializeComponent();
        }
        SqlConnect connect = new SqlConnect();
        private void FrmAppointmentList_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Appointments", connect.connection());
            da.Fill(dt);
            dtAppointmentList.DataSource = dt;
            connect.connection().Close();
        }
        //Cancel
        public int selectedAppointment;
        private void dtAppointmentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedAppointment = dtAppointmentList.SelectedCells[0].RowIndex;
        }
    }
}
