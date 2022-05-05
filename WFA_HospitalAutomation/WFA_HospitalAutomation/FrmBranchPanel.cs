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
    public partial class FrmBranchPanel : Form
    {
        public FrmBranchPanel()
        {
            InitializeComponent();
        }

        SqlConnect connect = new SqlConnect();

        void FillBranchTable()
        {
            dtBranch.Controls.Clear();

            DataTable branchTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbll_Branches", connect.connection());
            da.Fill(branchTable);
            dtBranch.DataSource = branchTable;
        }
        private void FrmBranchPanel_Load(object sender, EventArgs e)
        {
            FillBranchTable();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Tbll_Branches (BranchName) values (@b1)", connect.connection());
            command.Parameters.AddWithValue("@b1", txtBranchName.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("New branch is added to db", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillBranchTable();
            connect.connection().Close();
        }

        private void dtBranch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dtBranch.SelectedCells[0].RowIndex;
            txtBranchId.Text = dtBranch.Rows[selected].Cells[0].Value.ToString();
            txtBranchName.Text = dtBranch.Rows[selected].Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete from Tbll_Branches where BranchId=@b1", connect.connection());
            command.Parameters.AddWithValue("@b1", Convert.ToByte(txtBranchId.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Selected branch is deleted from db", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillBranchTable();
            connect.connection().Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbll_Branches set BranchName=@b1 where BranchId=@b2", connect.connection());
            command.Parameters.AddWithValue("@b1", txtBranchName.Text);
            command.Parameters.AddWithValue("@b2", Convert.ToByte(txtBranchId.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Selected branch is updated", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillBranchTable();
            connect.connection().Close();
        }
    }
}
