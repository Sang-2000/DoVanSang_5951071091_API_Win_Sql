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

namespace DoVanSang_5951071091_API_Win_Sql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getStudentRecord();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        // kết nối Database 
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-LDKJOLM\SQLEXPRESS;Initial Catalog=demoCRUD;User ID=sa;Password=123");


        private void getStudentRecord()
        {
            
            // Truy vấn Dâtbase
            SqlCommand cmd = new SqlCommand("SELECT * FROM StudentTb", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            StudentRecortData.DataSource = dt;

        }

        private bool IsValidData()
        {
            if (txtName.Text == string.Empty
                || txtFatherName.Text == string.Empty
                || txtAddress.Text == string.Empty
                || string.IsNullOrEmpty(txtMobile.Text)
                || string.IsNullOrEmpty(txtRollNumber.Text)
                )
            {
                MessageBox.Show("Có lõi chưa nhập liệu !!!", "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void StudentRecortData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = Convert.ToInt32(StudentRecortData.Rows[0].Cells[0].Value);
            txtName.Text = StudentRecortData.Rows[0].Cells[1].Value.ToString();
            txtFatherName.Text = StudentRecortData.Rows[0].Cells[2].Value.ToString();
            txtRollNumber.Text = StudentRecortData.Rows[0].Cells[3].Value.ToString();
            txtAddress.Text = StudentRecortData.Rows[0].Cells[4].Value.ToString();
            txtMobile.Text = StudentRecortData.Rows[0].Cells[5].Value.ToString();
        }

        private void ResetData()
        {
            txtName.Text = "";
            txtFatherName.Text = "";
            txtRollNumber.Text = "";
            txtAddress.Text = "";
            txtMobile.Text = "";
        }


        int ID;

        private void btbThem_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO StudentTb VALUES " +
                    "(@Name, @FatherName, @RollNumber, @Address, @Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                getStudentRecord();
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand(
                    "UPDATE StudentTb " +
                    "SET Name = @Name, Father = @FartherName, RollNumber =  @RollNumber, Address = @Address, Mobile = @Mobile)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtFatherName.Text);
                cmd.Parameters.AddWithValue("@RollNumber", txtRollNumber.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Mobile", txtMobile.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                getStudentRecord();
                ResetData();
            }
            else
            {
                MessageBox.Show("Cập nhật dữ liệu bị lỗi !!!", "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void bbtnXoa_Click(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                SqlCommand cmd = new SqlCommand(
                    "DELETE FROM StudentTb WHERE StudentID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", this.ID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                getStudentRecord();
                ResetData();
            }
            else
            {
                MessageBox.Show("Xóa dữ liệu bị lỗi !!!", "Lỗi dữ liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
