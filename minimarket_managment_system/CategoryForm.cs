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

namespace minimarket_managment_system
{
    public partial class CategoryForm : Form
    {
        DBConnect dbconn = new DBConnect();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void GetTable()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery,dbconn.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_category.DataSource = table;
        }

        private void btnC_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Category VALUES(" + textBoxC_id.Text + ",'" + textBoxC_name.Text + "','" + textBoxC_descr.Text + "') ";
                SqlCommand command = new SqlCommand(insertQuery,dbconn.GetCon());
                dbconn.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Категория добавлена успешно.");
                dbconn.CloseCon();
                GetTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }
        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void btnC_update_Click(object sender, EventArgs e)
        {
            try 
            {
                if (textBoxC_id.Text == "" || textBoxC_name.Text == "" || textBoxC_descr.Text == "")
                {
                    MessageBox.Show("Заполните пустые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Category SET Category_Name='" + textBoxC_name.Text + "', Category_Descr='" + textBoxC_descr.Text + "'WHERE Category_Id=" + textBoxC_id.Text + "";
                    SqlCommand command = new SqlCommand(updateQuery, dbconn.GetCon());
                    dbconn.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Категория изменена успешно.");
                    dbconn.CloseCon();
                    GetTable();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_category_Click(object sender, EventArgs e)
        {
            textBoxC_id.Text = dataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            textBoxC_name.Text = dataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
            textBoxC_descr.Text = dataGridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }
        private void clear()
        {
            textBoxC_descr.Clear();
            textBoxC_id.Clear();
            textBoxC_name.Clear();
        }

        private void btnC_del_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteQuery = "DELETE FROM Category WHERE Category_Id=" + textBoxC_id.Text + "";
                SqlCommand command = new SqlCommand(deleteQuery,dbconn.GetCon());
                dbconn.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Категория удалена.");
                dbconn.CloseCon();
                GetTable();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnC_logout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnC_products_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }
    }
}
