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
    public partial class LoginForm : Form
    {
        DBConnect dbconn = new DBConnect();
        public static string sellerName;
        public LoginForm()
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
        private void Clear()
        {
            textBox_name.Clear();
            textBox_pass.Clear();
        }

        private void button_join_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_pass.Text == "")
            {
                MessageBox.Show("Не введены данные", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_role.SelectedItem.ToString() == "Админ")
                {
                    if (textBox_name.Text == "admin" || textBox_pass.Text == "admin12")
                    {
                        ProductForm product = new ProductForm();
                        product.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неправильное имя или пароль", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    string selectQuery = "SELECT * FROM Seller WHERE Seller_Name='" + textBox_name.Text + "' AND Seller_Password='" + textBox_pass.Text + "'";
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, dbconn.GetCon());
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        sellerName = textBox_name.Text;
                        SellerForm seller = new SellerForm();
                        seller.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неправильное имя или пароль", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
