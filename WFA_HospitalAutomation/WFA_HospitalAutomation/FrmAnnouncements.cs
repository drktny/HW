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
    public partial class FrmAnnouncements : Form
    {
        public FrmAnnouncements()
        {
            InitializeComponent();
        }
        SqlConnect connect = new SqlConnect();

        void FillAnnouncementTable()
        {
            dtAnnouncements.Controls.Clear();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Announcements", connect.connection());
            da.Fill(dt);
            dtAnnouncements.DataSource = dt;
        }
        private void FrmAnnouncements_Load(object sender, EventArgs e)
        {
            FillAnnouncementTable();
            connect.connection().Close();
        }
    }
}
