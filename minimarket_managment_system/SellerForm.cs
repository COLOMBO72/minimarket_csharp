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
    public partial class SellerForm : Form
    {
        DBConnect dbconn = new DBConnect();
        public SellerForm()
        {
            InitializeComponent();
        }

        private void GetTable()
        {
            string selectQuery = "SELECT * FROM Seller";
            SqlCommand command = new SqlCommand(selectQuery,dbconn.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_seller.DataSource = table;
        }


        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_close_MouseHover(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            GetTable();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertQuery = "INSERT INTO Seller VALUES(" + textBox_id.Text + ",'" + textBox_name.Text + "','" + textBox_mail.Text + "','"+textBox_number.Text+"','"+textBox_password.Text+"') ";
                SqlCommand command = new SqlCommand(insertQuery, dbconn.GetCon());
                dbconn.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Продавец добавлен успешно.");
                dbconn.CloseCon();
                GetTable();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Clear()
        {
            textBox_id.Clear();
            textBox_mail.Clear();
            textBox_name.Clear();
            textBox_number.Clear();
        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void btn_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }
    }
}
