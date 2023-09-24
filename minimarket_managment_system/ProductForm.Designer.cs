namespace minimarket_managment_system
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnP_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxP_search = new System.Windows.Forms.ComboBox();
            this.btnP_update = new Guna.UI2.WinForms.Guna2Button();
            this.btnP_del = new Guna.UI2.WinForms.Guna2Button();
            this.btnP_add = new Guna.UI2.WinForms.Guna2Button();
            this.comboBoxP_category = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxP_price = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxP_quanity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxP_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBoxP_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_close = new System.Windows.Forms.Label();
            this.btnP_seller = new Guna.UI2.WinForms.Guna2Button();
            this.btnP_selling = new Guna.UI2.WinForms.Guna2Button();
            this.btnP_category = new Guna.UI2.WinForms.Guna2Button();
            this.btnP_logout = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_product = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.dataGridView_product);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnP_refresh);
            this.panel1.Controls.Add(this.comboBoxP_search);
            this.panel1.Controls.Add(this.btnP_update);
            this.panel1.Controls.Add(this.btnP_del);
            this.panel1.Controls.Add(this.btnP_add);
            this.panel1.Controls.Add(this.comboBoxP_category);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxP_price);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxP_quanity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxP_name);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.textBoxP_id);
            this.panel1.Location = new System.Drawing.Point(229, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 584);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "УПРАВЛЕНИЕ ПРОДУКТАМИ";
            // 
            // btnP_refresh
            // 
            this.btnP_refresh.BackColor = System.Drawing.Color.LimeGreen;
            this.btnP_refresh.BorderRadius = 10;
            this.btnP_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_refresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_refresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_refresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_refresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_refresh.FillColor = System.Drawing.Color.Transparent;
            this.btnP_refresh.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnP_refresh.ForeColor = System.Drawing.Color.White;
            this.btnP_refresh.Location = new System.Drawing.Point(609, 10);
            this.btnP_refresh.Name = "btnP_refresh";
            this.btnP_refresh.Size = new System.Drawing.Size(84, 40);
            this.btnP_refresh.TabIndex = 14;
            this.btnP_refresh.Text = "Обновить";
            // 
            // comboBoxP_search
            // 
            this.comboBoxP_search.FormattingEnabled = true;
            this.comboBoxP_search.Location = new System.Drawing.Point(457, 18);
            this.comboBoxP_search.Name = "comboBoxP_search";
            this.comboBoxP_search.Size = new System.Drawing.Size(146, 27);
            this.comboBoxP_search.TabIndex = 13;
            this.comboBoxP_search.Text = "Не выбрано";
            // 
            // btnP_update
            // 
            this.btnP_update.BorderRadius = 8;
            this.btnP_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_update.FillColor = System.Drawing.Color.LightYellow;
            this.btnP_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP_update.ForeColor = System.Drawing.Color.Black;
            this.btnP_update.Location = new System.Drawing.Point(96, 239);
            this.btnP_update.Name = "btnP_update";
            this.btnP_update.Size = new System.Drawing.Size(84, 40);
            this.btnP_update.TabIndex = 12;
            this.btnP_update.Text = "Обновить";
            this.btnP_update.Click += new System.EventHandler(this.btnP_update_Click);
            // 
            // btnP_del
            // 
            this.btnP_del.BorderRadius = 8;
            this.btnP_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_del.FillColor = System.Drawing.Color.Coral;
            this.btnP_del.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP_del.ForeColor = System.Drawing.Color.White;
            this.btnP_del.Location = new System.Drawing.Point(186, 239);
            this.btnP_del.Name = "btnP_del";
            this.btnP_del.Size = new System.Drawing.Size(84, 40);
            this.btnP_del.TabIndex = 11;
            this.btnP_del.Text = "Удалить";
            // 
            // btnP_add
            // 
            this.btnP_add.BorderRadius = 8;
            this.btnP_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_add.FillColor = System.Drawing.Color.PaleGreen;
            this.btnP_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnP_add.ForeColor = System.Drawing.Color.Black;
            this.btnP_add.Location = new System.Drawing.Point(6, 239);
            this.btnP_add.Name = "btnP_add";
            this.btnP_add.Size = new System.Drawing.Size(84, 40);
            this.btnP_add.TabIndex = 10;
            this.btnP_add.Text = "Добавить";
            this.btnP_add.Click += new System.EventHandler(this.btnP_add_Click);
            // 
            // comboBoxP_category
            // 
            this.comboBoxP_category.FormattingEnabled = true;
            this.comboBoxP_category.Location = new System.Drawing.Point(115, 194);
            this.comboBoxP_category.Name = "comboBoxP_category";
            this.comboBoxP_category.Size = new System.Drawing.Size(146, 27);
            this.comboBoxP_category.TabIndex = 9;
            this.comboBoxP_category.Text = "Не выбрано";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // textBoxP_price
            // 
            this.textBoxP_price.BorderRadius = 8;
            this.textBoxP_price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxP_price.DefaultText = "";
            this.textBoxP_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxP_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxP_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxP_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_price.Location = new System.Drawing.Point(115, 158);
            this.textBoxP_price.Name = "textBoxP_price";
            this.textBoxP_price.PasswordChar = '\0';
            this.textBoxP_price.PlaceholderText = "459";
            this.textBoxP_price.SelectedText = "";
            this.textBoxP_price.Size = new System.Drawing.Size(146, 30);
            this.textBoxP_price.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество";
            // 
            // textBoxP_quanity
            // 
            this.textBoxP_quanity.BorderRadius = 8;
            this.textBoxP_quanity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxP_quanity.DefaultText = "";
            this.textBoxP_quanity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxP_quanity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxP_quanity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_quanity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_quanity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_quanity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxP_quanity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_quanity.Location = new System.Drawing.Point(115, 122);
            this.textBoxP_quanity.Name = "textBoxP_quanity";
            this.textBoxP_quanity.PasswordChar = '\0';
            this.textBoxP_quanity.PlaceholderText = "80";
            this.textBoxP_quanity.SelectedText = "";
            this.textBoxP_quanity.Size = new System.Drawing.Size(146, 30);
            this.textBoxP_quanity.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // textBoxP_name
            // 
            this.textBoxP_name.BorderRadius = 8;
            this.textBoxP_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxP_name.DefaultText = "";
            this.textBoxP_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxP_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxP_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxP_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_name.Location = new System.Drawing.Point(115, 86);
            this.textBoxP_name.Name = "textBoxP_name";
            this.textBoxP_name.PasswordChar = '\0';
            this.textBoxP_name.PlaceholderText = "Персик";
            this.textBoxP_name.SelectedText = "";
            this.textBoxP_name.Size = new System.Drawing.Size(146, 30);
            this.textBoxP_name.TabIndex = 3;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(15, 55);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(23, 19);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // textBoxP_id
            // 
            this.textBoxP_id.BorderRadius = 8;
            this.textBoxP_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxP_id.DefaultText = "";
            this.textBoxP_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxP_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxP_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxP_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxP_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxP_id.Location = new System.Drawing.Point(115, 50);
            this.textBoxP_id.Name = "textBoxP_id";
            this.textBoxP_id.PasswordChar = '\0';
            this.textBoxP_id.PlaceholderText = "ID продукта";
            this.textBoxP_id.SelectedText = "";
            this.textBoxP_id.Size = new System.Drawing.Size(146, 30);
            this.textBoxP_id.TabIndex = 1;
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Location = new System.Drawing.Point(1071, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(17, 19);
            this.label_close.TabIndex = 11;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // btnP_seller
            // 
            this.btnP_seller.BorderRadius = 10;
            this.btnP_seller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_seller.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_seller.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_seller.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_seller.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_seller.FillColor = System.Drawing.Color.RosyBrown;
            this.btnP_seller.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnP_seller.ForeColor = System.Drawing.Color.White;
            this.btnP_seller.Location = new System.Drawing.Point(22, 54);
            this.btnP_seller.Name = "btnP_seller";
            this.btnP_seller.Size = new System.Drawing.Size(180, 45);
            this.btnP_seller.TabIndex = 12;
            this.btnP_seller.Text = "Продавец";
            // 
            // btnP_selling
            // 
            this.btnP_selling.BorderRadius = 10;
            this.btnP_selling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_selling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_selling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_selling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_selling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_selling.FillColor = System.Drawing.Color.RosyBrown;
            this.btnP_selling.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnP_selling.ForeColor = System.Drawing.Color.White;
            this.btnP_selling.Location = new System.Drawing.Point(22, 177);
            this.btnP_selling.Name = "btnP_selling";
            this.btnP_selling.Size = new System.Drawing.Size(180, 45);
            this.btnP_selling.TabIndex = 13;
            this.btnP_selling.Text = "Продажа";
            // 
            // btnP_category
            // 
            this.btnP_category.BorderRadius = 10;
            this.btnP_category.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_category.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_category.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_category.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_category.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_category.FillColor = System.Drawing.Color.RosyBrown;
            this.btnP_category.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnP_category.ForeColor = System.Drawing.Color.White;
            this.btnP_category.Location = new System.Drawing.Point(22, 114);
            this.btnP_category.Name = "btnP_category";
            this.btnP_category.Size = new System.Drawing.Size(180, 45);
            this.btnP_category.TabIndex = 14;
            this.btnP_category.Text = "Категории";
            this.btnP_category.Click += new System.EventHandler(this.btnP_category_Click);
            // 
            // btnP_logout
            // 
            this.btnP_logout.BorderRadius = 10;
            this.btnP_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnP_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnP_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnP_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnP_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnP_logout.FillColor = System.Drawing.Color.Brown;
            this.btnP_logout.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnP_logout.ForeColor = System.Drawing.Color.White;
            this.btnP_logout.Location = new System.Drawing.Point(34, 616);
            this.btnP_logout.Name = "btnP_logout";
            this.btnP_logout.Size = new System.Drawing.Size(137, 22);
            this.btnP_logout.TabIndex = 15;
            this.btnP_logout.Text = "Выйти";
            // 
            // dataGridView_product
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_product.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_product.ColumnHeadersHeight = 4;
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_product.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_product.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_product.Location = new System.Drawing.Point(280, 55);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersVisible = false;
            this.dataGridView_product.Size = new System.Drawing.Size(564, 516);
            this.dataGridView_product.TabIndex = 16;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_product.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_product.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_product.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_product.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_product.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_product.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_product.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_product.ThemeStyle.ReadOnly = false;
            this.dataGridView_product.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_product.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_product.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_product.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_product.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_product.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_product.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_product.Click += new System.EventHandler(this.dataGridView_product_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.btnP_logout);
            this.Controls.Add(this.btnP_category);
            this.Controls.Add(this.btnP_selling);
            this.Controls.Add(this.btnP_seller);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBoxP_quanity;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxP_name;
        private System.Windows.Forms.Label label_id;
        private Guna.UI2.WinForms.Guna2TextBox textBoxP_id;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxP_price;
        private Guna.UI2.WinForms.Guna2Button btnP_update;
        private Guna.UI2.WinForms.Guna2Button btnP_del;
        private Guna.UI2.WinForms.Guna2Button btnP_add;
        private System.Windows.Forms.ComboBox comboBoxP_category;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnP_refresh;
        private System.Windows.Forms.ComboBox comboBoxP_search;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnP_seller;
        private Guna.UI2.WinForms.Guna2Button btnP_selling;
        private Guna.UI2.WinForms.Guna2Button btnP_category;
        private Guna.UI2.WinForms.Guna2Button btnP_logout;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_product;
    }
}