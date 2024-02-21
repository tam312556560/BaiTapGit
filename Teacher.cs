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


namespace TranChiTam
{
    public partial class Teacher : Form
    {
        SqlConnection conn = new
                SqlConnection(Properties.Settings.Default.cnnStr);
        public Teacher()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT*FROM HocSinh");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                dataGridView1.DataSource = dtSinhVien;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally { conn.Close(); }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {

                // Ket noi

                conn.Open();

                string sqlStr = string.Format("INSERT INTO Teacher(HovaTen, CMND, DiaChi, Ngaythangnamsinh) VALUES ('{0}', '{1}', '{2}', '{3}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)

                    MessageBox.Show("them thanh cong");

            }

            catch (Exception ex)

            {

                MessageBox.Show("them that bai" + ex);

            }

            finally

            {

                conn.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try

            {

                // Ket noi

                conn.Open();

                string sqlStr = string.Format("UPDATE HocSinh SET HovaTen = '{0}', DiaChi = '{1}' WHERE cmnd = {2}", textBox1, textBox2, textBox3, textBox4);

                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)

                    MessageBox.Show("them thanh cong");

            }

            catch (Exception ex)

            {

                MessageBox.Show("them that bai" + ex);

            }

            finally

            {

                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try

            {

                // Ket noi

                conn.Open();

                string sqlStr = string.Format("DELETE FROM HocSinh WHERE cmnd = ‘{0}’)", textBox2.Text);

                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)

                    MessageBox.Show("Xoa thanh cong");

            }

            catch (Exception ex)

            {

                MessageBox.Show("xoa that bai" + ex);

            }

            finally

            {

                conn.Close();
            }
        }
    }
}

