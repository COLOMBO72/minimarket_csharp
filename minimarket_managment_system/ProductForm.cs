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
    public partial class ProductForm : Form
        
    {
        DBConnect dbconn = new DBConnect();
        public ProductForm()
        {
            InitializeComponent();
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

        private void btnP_category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetTable();
            GetCategory();
        }
        private void GetCategory()
        {
            string selectQuery = "SELECT * FROM Category";
            SqlCommand command = new SqlCommand(selectQuery,dbconn.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            comboBoxP_category.DataSource = table;
            comboBoxP_category.ValueMember = "Category_Name";
            comboBoxP_search.DataSource = table;
            comboBoxP_search.ValueMember = "Category_Name";
        }
        private void GetTable()
        {
            string selectQuery = "SELECT * FROM Product";
            SqlCommand command = new SqlCommand(selectQuery, dbconn.GetCon());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView_product.DataSource = table;
        }
        private void Clear()
        {
            textBoxP_id.Clear();
            textBoxP_name.Clear();
            textBoxP_price.Clear();
            textBoxP_quanity.Clear();
            comboBoxP_category.SelectedIndex = 0;
        }

        private void btnP_add_Click(object sender, EventArgs e)
        {
            try 
            {
                string insertQuery = "INSERT INTO Product VALUES(" + textBoxP_id.Text + ",'" + textBoxP_name.Text + "','" + textBoxP_price.Text + "','" + textBoxP_quanity.Text + "','"+comboBoxP_category.Text+"')";
                SqlCommand command = new SqlCommand(insertQuery, dbconn.GetCon());
                dbconn.OpenCon();
                command.ExecuteNonQuery();
                MessageBox.Show("Продукт добавлен успешно.");
                dbconn.CloseCon();
                GetTable();
                Clear();
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnP_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxP_id.Text == "" || textBoxP_name.Text == "" || textBoxP_price.Text == "" || textBoxP_quanity.Text == "" || comboBoxP_category.SelectedIndex == 0)
                {
                    MessageBox.Show("Заполните пустые поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string updateQuery = "UPDATE Product SET Product_Name='" + textBoxP_name.Text + "',Product_Price='" + textBoxP_price.Text + "',Product_Qty='" + textBoxP_quanity.Text + "',Product_Category='" + comboBoxP_category.Text + "'WHERE Product_Id="+textBoxP_id.Text+"";
                    SqlCommand command = new SqlCommand(updateQuery, dbconn.GetCon());
                    dbconn.OpenCon();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Продукт изменен успешно.", "Изменение информации",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    dbconn.CloseCon();
                    GetTable();
                    Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView_product_Click(object sender, EventArgs e)
        {
            textBoxP_id.Text = dataGridView_product.SelectedRows[0].Cells[0].Value.ToString();
            textBoxP_name.Text = dataGridView_product.SelectedRows[0].Cells[1].Value.ToString();
            textBoxP_price.Text = dataGridView_product.SelectedRows[0].Cells[2].Value.ToString();
            textBoxP_quanity.Text = dataGridView_product.SelectedRows[0].Cells[3].Value.ToString();
            comboBoxP_category.SelectedValue = dataGridView_product.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
