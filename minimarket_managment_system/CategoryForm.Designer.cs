namespace minimarket_managment_system
{
    partial class CategoryForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnC_update = new Guna.UI2.WinForms.Guna2Button();
            this.btnC_del = new Guna.UI2.WinForms.Guna2Button();
            this.btnC_add = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxC_descr = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnC_products = new Guna.UI2.WinForms.Guna2Button();
            this.btnP_selling = new Guna.UI2.WinForms.Guna2Button();
            this.btnP_seller = new Guna.UI2.WinForms.Guna2Button();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxC_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxC_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_category = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnC_logout = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "УПРАВЛЕНИЕ КАТЕГОРИЯМИ";
            // 
            // btnC_update
            // 
            this.btnC_update.BorderRadius = 8;
            this.btnC_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnC_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnC_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnC_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnC_update.FillColor = System.Drawing.Color.LightYellow;
            this.btnC_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnC_update.ForeColor = System.Drawing.Color.Black;
            this.btnC_update.Location = new System.Drawing.Point(104, 163);
            this.btnC_update.Name = "btnC_update";
            this.btnC_update.Size = new System.Drawing.Size(84, 40);
            this.btnC_update.TabIndex = 12;
            this.btnC_update.Text = "Обновить";
            this.btnC_update.Click += new System.EventHandler(this.btnC_update_Click);
            // 
            // btnC_del
            // 
            this.btnC_del.BorderRadius = 8;
            this.btnC_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC_del.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnC_del.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnC_del.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnC_del.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnC_del.FillColor = System.Drawing.Color.Coral;
            this.btnC_del.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnC_del.ForeColor = System.Drawing.Color.White;
            this.btnC_del.Location = new System.Drawing.Point(194, 163);
            this.btnC_del.Name = "btnC_del";
            this.btnC_del.Size = new System.Drawing.Size(84, 40);
            this.btnC_del.TabIndex = 11;
            this.btnC_del.Text = "Удалить";
            this.btnC_del.Click += new System.EventHandler(this.btnC_del_Click);
            // 
            // btnC_add
            // 
            this.btnC_add.BorderRadius = 8;
            this.btnC_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnC_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnC_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnC_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnC_add.FillColor = System.Drawing.Color.PaleGreen;
            this.btnC_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnC_add.ForeColor = System.Drawing.Color.Black;
            this.btnC_add.Location = new System.Drawing.Point(14, 163);
            this.btnC_add.Name = "btnC_add";
            this.btnC_add.Size = new System.Drawing.Size(84, 40);
            this.btnC_add.TabIndex = 10;
            this.btnC_add.Text = "Добавить";
            this.btnC_add.Click += new System.EventHandler(this.btnC_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание";
            // 
            // textBoxC_descr
            // 
            this.textBoxC_descr.BorderRadius = 8;
            this.textBoxC_descr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxC_descr.DefaultText = "";
            this.textBoxC_descr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxC_descr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxC_descr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxC_descr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxC_descr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxC_descr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxC_descr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxC_descr.Location = new System.Drawing.Point(127, 118);
            this.textBoxC_descr.Name = "textBoxC_descr";
            this.textBoxC_descr.PasswordChar = '\0';
            this.textBoxC_descr.PlaceholderText = "Красный, синий...";
            this.textBoxC_descr.SelectedText = "";
            this.textBoxC_descr.Size = new System.Drawing.Size(146, 30);
            this.textBoxC_descr.TabIndex = 7;
            // 
            // btnC_products
            // 
            this.btnC_products.BorderRadius = 10;
            this.btnC_products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC_products.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnC_products.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnC_products.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnC_products.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnC_products.FillColor = System.Drawing.Color.RosyBrown;
            this.btnC_products.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnC_products.ForeColor = System.Drawing.Color.White;
            this.btnC_products.Location = new System.Drawing.Point(22, 116);
            this.btnC_products.Name = "btnC_products";
            this.btnC_products.Size = new System.Drawing.Size(180, 45);
            this.btnC_products.TabIndex = 20;
            this.btnC_products.Text = "Продукты";
            this.btnC_products.Click += new System.EventHandler(this.btnC_products_Click);
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
            this.btnP_selling.Location = new System.Drawing.Point(22, 179);
            this.btnP_selling.Name = "btnP_selling";
            this.btnP_selling.Size = new System.Drawing.Size(180, 45);
            this.btnP_selling.TabIndex = 19;
            this.btnP_selling.Text = "Продажа";
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
            this.btnP_seller.Location = new System.Drawing.Point(22, 56);
            this.btnP_seller.Name = "btnP_seller";
            this.btnP_seller.Size = new System.Drawing.Size(180, 45);
            this.btnP_seller.TabIndex = 18;
            this.btnP_seller.Text = "Продавец";
            this.btnP_seller.Click += new System.EventHandler(this.btnP_seller_Click);
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_close.Location = new System.Drawing.Point(1066, 11);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(17, 19);
            this.label_close.TabIndex = 17;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // textBoxC_name
            // 
            this.textBoxC_name.BorderRadius = 8;
            this.textBoxC_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxC_name.DefaultText = "";
            this.textBoxC_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxC_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxC_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxC_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxC_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxC_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxC_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxC_name.Location = new System.Drawing.Point(127, 82);
            this.textBoxC_name.Name = "textBoxC_name";
            this.textBoxC_name.PasswordChar = '\0';
            this.textBoxC_name.PlaceholderText = "Цветные";
            this.textBoxC_name.SelectedText = "";
            this.textBoxC_name.Size = new System.Drawing.Size(146, 30);
            this.textBoxC_name.TabIndex = 3;
            // 
            // textBoxC_id
            // 
            this.textBoxC_id.BorderRadius = 8;
            this.textBoxC_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxC_id.DefaultText = "";
            this.textBoxC_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxC_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxC_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxC_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxC_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxC_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxC_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxC_id.Location = new System.Drawing.Point(127, 46);
            this.textBoxC_id.Name = "textBoxC_id";
            this.textBoxC_id.PasswordChar = '\0';
            this.textBoxC_id.PlaceholderText = "ID категории";
            this.textBoxC_id.SelectedText = "";
            this.textBoxC_id.Size = new System.Drawing.Size(146, 30);
            this.textBoxC_id.TabIndex = 1;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(27, 51);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(23, 19);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.dataGridView_category);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnC_update);
            this.panel1.Controls.Add(this.btnC_del);
            this.panel1.Controls.Add(this.btnC_add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxC_descr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxC_name);
            this.panel1.Controls.Add(this.label_id);
            this.panel1.Controls.Add(this.textBoxC_id);
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(224, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 584);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView_category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_category.BackgroundColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_category.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_category.ColumnHeadersHeight = 24;
            this.dataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_category.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_category.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.Location = new System.Drawing.Point(305, 0);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.RowHeadersVisible = false;
            this.dataGridView_category.Size = new System.Drawing.Size(554, 584);
            this.dataGridView_category.TabIndex = 16;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_category.ThemeStyle.BackColor = System.Drawing.Color.FloralWhite;
            this.dataGridView_category.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_category.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_category.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_category.ThemeStyle.HeaderStyle.Height = 24;
            this.dataGridView_category.ThemeStyle.ReadOnly = false;
            this.dataGridView_category.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_category.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_category.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridView_category.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_category.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_category.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_category.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_category.Click += new System.EventHandler(this.dataGridView_category_Click);
            // 
            // btnC_logout
            // 
            this.btnC_logout.BorderRadius = 10;
            this.btnC_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnC_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnC_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnC_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnC_logout.FillColor = System.Drawing.Color.Brown;
            this.btnC_logout.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnC_logout.ForeColor = System.Drawing.Color.White;
            this.btnC_logout.Location = new System.Drawing.Point(34, 616);
            this.btnC_logout.Name = "btnC_logout";
            this.btnC_logout.Size = new System.Drawing.Size(137, 22);
            this.btnC_logout.TabIndex = 21;
            this.btnC_logout.Text = "Выйти";
            this.btnC_logout.Click += new System.EventHandler(this.btnC_logout_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.btnC_products);
            this.Controls.Add(this.btnP_selling);
            this.Controls.Add(this.btnP_seller);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.btnC_logout);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnC_update;
        private Guna.UI2.WinForms.Guna2Button btnC_del;
        private Guna.UI2.WinForms.Guna2Button btnC_add;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBoxC_descr;
        private Guna.UI2.WinForms.Guna2Button btnC_products;
        private Guna.UI2.WinForms.Guna2Button btnP_selling;
        private Guna.UI2.WinForms.Guna2Button btnP_seller;
        private System.Windows.Forms.Label label_close;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxC_name;
        private Guna.UI2.WinForms.Guna2TextBox textBoxC_id;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_category;
        private Guna.UI2.WinForms.Guna2Button btnC_logout;
    }
}