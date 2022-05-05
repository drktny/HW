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
    public partial class FrmDoctorPanel : Form
    {
        public FrmDoctorPanel()
        {
            InitializeComponent();
        }
        SqlConnect connect = new SqlConnect();

        void FillDocTable()
        {
            dtDoctors.Controls.Clear();
            //

            DataTable docTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbll_Doctors", connect.connection());
            da.Fill(docTable);
            dtDoctors.DataSource = docTable;
        }
        private void FrmDoctorPanel_Load(object sender, EventArgs e)
        {
            FillDocTable();

            SqlCommand command = new SqlCommand("Select BranchName from Tbll_Branches", connect.connection());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                cmbBranch.Items.Add(dr[0]);
            }

            connect.connection().Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbll_Doctors (DoctorName,DoctorSurname,DoctorBranch,DoctorTC,DoctorPassword) values (@d1,@d2,@d3,@d4,@d5)", connect.connection());
            command.Parameters.AddWithValue("@d1", txtName.Text);
            command.Parameters.AddWithValue("@d2", txtSurname.Text);
            command.Parameters.AddWithValue("@d3", cmbBranch.Text);
            command.Parameters.AddWithValue("@d4", mskDoctorTC.Text);
            command.Parameters.AddWithValue("@d5", txtPassword.Text);
            command.ExecuteNonQuery();
            connect.connection().Close();
            MessageBox.Show("Doctor is added to db", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillDocTable();
        }


        private void dtDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dtDoctors.SelectedCells[0].RowIndex;
            txtName.Text = dtDoctors.Rows[selected].Cells[1].Value.ToString();
            txtSurname.Text = dtDoctors.Rows[selected].Cells[2].Value.ToString();
            cmbBranch.Text = dtDoctors.Rows[selected].Cells[3].Value.ToString();
            mskDoctorTC.Text = dtDoctors.Rows[selected].Cells[4].Value.ToString();
            txtPassword.Text = dtDoctors.Rows[selected].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbll_Doctors where DoctorTC=@p1",connect.connection());
            command.Parameters.AddWithValue("@p1", mskDoctorTC.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Selected doctor is succesfully removed from db", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillDocTable();

            connect.connection().Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbll_Doctors set DoctorName=@d1,DoctorSurname=@d2,DoctorBranch=@d3,DoctorPassword=@d5 where DoctorTC=@d4", connect.connection());
            command.Parameters.AddWithValue("@d1", txtName.Text);
            command.Parameters.AddWithValue("@d2", txtSurname.Text);
            command.Parameters.AddWithValue("@d3", cmbBranch.Text);
            command.Parameters.AddWithValue("@d4", mskDoctorTC.Text);
            command.Parameters.AddWithValue("@d5", txtPassword.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Selected doctor datas are succesfully updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            FillDocTable();
            connect.connection().Close();
        }
    }
}
