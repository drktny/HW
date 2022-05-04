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
    public partial class FrmAssistantLogin : Form
    {
        public FrmAssistantLogin()
        {
            InitializeComponent();
        }
        SqlConnect connect = new SqlConnect();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from Tbl_Assistants where AssistantTC=@p1 and AssistantPassword=@p2", connect.connection());
            command.Parameters.AddWithValue("@p1", mskTC.Text);
            command.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmAssistantDetail frm = new FrmAssistantDetail();
                frm.TCno = mskTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong TC or password", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
