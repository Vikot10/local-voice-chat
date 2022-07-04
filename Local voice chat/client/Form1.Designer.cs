namespace kur_seti
{
    partial class Form1
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
            this.login = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.sign = new System.Windows.Forms.Button();
            this.registr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(142, 104);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(93, 31);
            this.login.TabIndex = 0;
            this.login.Text = "Логин";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass.Location = new System.Drawing.Point(133, 223);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(110, 31);
            this.pass.TabIndex = 1;
            this.pass.Text = "Пароль";
            // 
            // loginBox
            // 
            this.loginBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.Location = new System.Drawing.Point(49, 161);
            this.loginBox.MaxLength = 16;
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(290, 31);
            this.loginBox.TabIndex = 2;
            // 
            // passBox
            // 
            this.passBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passBox.Location = new System.Drawing.Point(49, 292);
            this.passBox.MaxLength = 16;
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(290, 31);
            this.passBox.TabIndex = 3;
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign.Location = new System.Drawing.Point(128, 367);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(115, 35);
            this.sign.TabIndex = 4;
            this.sign.Text = "Войти";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // registr
            // 
            this.registr.AutoSize = true;
            this.registr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registr.Dock = System.Windows.Forms.DockStyle.Right;
            this.registr.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registr.Location = new System.Drawing.Point(176, 0);
            this.registr.Name = "registr";
            this.registr.Size = new System.Drawing.Size(208, 23);
            this.registr.TabIndex = 5;
            this.registr.Text = "Зарегистрироваться";
            this.registr.Click += new System.EventHandler(this.registr_Click);
            this.registr.MouseLeave += new System.EventHandler(this.registr_MouseLeave);
            this.registr.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registr_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 23);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.registr);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 36);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(124, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.login);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Form1";
            this.Text = "Клиент";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Label registr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}

