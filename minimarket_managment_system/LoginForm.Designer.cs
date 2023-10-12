namespace minimarket_managment_system
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_join = new Guna.UI2.WinForms.Guna2Button();
            this.textBox_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBox_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_signup = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_join
            // 
            this.button_join.BorderRadius = 8;
            this.button_join.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_join.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_join.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_join.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_join.FillColor = System.Drawing.Color.CornflowerBlue;
            this.button_join.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_join.ForeColor = System.Drawing.Color.White;
            this.button_join.Location = new System.Drawing.Point(256, 244);
            this.button_join.Name = "button_join";
            this.button_join.Size = new System.Drawing.Size(135, 35);
            this.button_join.TabIndex = 0;
            this.button_join.Text = "Войти";
            this.button_join.Click += new System.EventHandler(this.button_join_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.BorderRadius = 8;
            this.textBox_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_pass.DefaultText = "";
            this.textBox_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_pass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_pass.Location = new System.Drawing.Point(223, 181);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '•';
            this.textBox_pass.PlaceholderText = "Пароль";
            this.textBox_pass.SelectedText = "";
            this.textBox_pass.Size = new System.Drawing.Size(198, 28);
            this.textBox_pass.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.BorderRadius = 8;
            this.textBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_name.DefaultText = "";
            this.textBox_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_name.Location = new System.Drawing.Point(223, 147);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.PasswordChar = '\0';
            this.textBox_name.PlaceholderText = "Имя пользователя";
            this.textBox_name.SelectedText = "";
            this.textBox_name.Size = new System.Drawing.Size(198, 28);
            this.textBox_name.TabIndex = 3;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(256, 46);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(136, 31);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Авторизация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(206, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Нет аккаунта?";
            // 
            // button_signup
            // 
            this.button_signup.BorderRadius = 8;
            this.button_signup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button_signup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button_signup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button_signup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button_signup.FillColor = System.Drawing.Color.CornflowerBlue;
            this.button_signup.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_signup.ForeColor = System.Drawing.Color.White;
            this.button_signup.Location = new System.Drawing.Point(316, 309);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(152, 21);
            this.button_signup.TabIndex = 8;
            this.button_signup.Text = "Зарегистрироваться";
            // 
            // comboBox_role
            // 
            this.comboBox_role.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Админ",
            "Продавец"});
            this.comboBox_role.Location = new System.Drawing.Point(255, 91);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(139, 27);
            this.comboBox_role.TabIndex = 9;
            this.comboBox_role.Text = "Выберите роль";
            // 
            // label_close
            // 
            this.label_close.AutoSize = true;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Location = new System.Drawing.Point(608, 9);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(13, 13);
            this.label_close.TabIndex = 10;
            this.label_close.Text = "X";
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.label_close);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.button_join);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_join;
        private Guna.UI2.WinForms.Guna2TextBox textBox_pass;
        private Guna.UI2.WinForms.Guna2TextBox textBox_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button button_signup;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label_close;
    }
}

