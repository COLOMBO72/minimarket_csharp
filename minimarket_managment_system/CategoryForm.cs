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
            }
            catch(Exception ex)
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
    }
}
