namespace kur_seti
{
    partial class Menu
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.settingsBut = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameClient = new System.Windows.Forms.Label();
            this.AddLeaveServ = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Speake = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Send = new System.Windows.Forms.Button();
            this.NameNewRoom = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(252)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(4, 126);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(668, 806);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название комнаты";
            this.columnHeader1.Width = 300;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Кол-во участников";
            this.columnHeader2.Width = 185;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.settingsBut);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nameClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1576, 123);
            this.panel1.TabIndex = 1;
            // 
            // settingsBut
            // 
            this.settingsBut.BackColor = System.Drawing.Color.Lavender;
            this.settingsBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settingsBut.BackgroundImage")));
            this.settingsBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBut.FlatAppearance.BorderColor = System.Drawing.Color.Lavender;
            this.settingsBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBut.Location = new System.Drawing.Point(1407, 15);
            this.settingsBut.Margin = new System.Windows.Forms.Padding(4);
            this.settingsBut.Name = "settingsBut";
            this.settingsBut.Size = new System.Drawing.Size(156, 94);
            this.settingsBut.TabIndex = 2;
            this.settingsBut.UseVisualStyleBackColor = false;
            this.settingsBut.Click += new System.EventHandler(this.settingsBut_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(39, 26);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 82);
            this.panel2.TabIndex = 1;
            // 
            // nameClient
            // 
            this.nameClient.AutoSize = true;
            this.nameClient.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClient.Location = new System.Drawing.Point(145, 47);
            this.nameClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameClient.Name = "nameClient";
            this.nameClient.Size = new System.Drawing.Size(150, 47);
            this.nameClient.TabIndex = 0;
            this.nameClient.Text = "привет";
            // 
            // AddLeaveServ
            // 
            this.AddLeaveServ.AutoSize = true;
            this.AddLeaveServ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.AddLeaveServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLeaveServ.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLeaveServ.Location = new System.Drawing.Point(681, 446);
            this.AddLeaveServ.Margin = new System.Windows.Forms.Padding(4);
            this.AddLeaveServ.Name = "AddLeaveServ";
            this.AddLeaveServ.Size = new System.Drawing.Size(137, 79);
            this.AddLeaveServ.TabIndex = 2;
            this.AddLeaveServ.Text = "Добавить\r\n комнату";
            this.AddLeaveServ.UseVisualStyleBackColor = false;
            this.AddLeaveServ.Click += new System.EventHandler(this.AddLeaveServ_Click);
            // 
            // Off
            // 
            this.Off.AutoSize = true;
            this.Off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.Off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Off.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Off.Location = new System.Drawing.Point(511, 364);
            this.Off.Margin = new System.Windows.Forms.Padding(4);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(145, 66);
            this.Off.TabIndex = 3;
            this.Off.Text = "Отключить\r\nзвук";
            this.Off.UseVisualStyleBackColor = false;
            this.Off.Visible = false;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            // 
            // Stop
            // 
            this.Stop.AutoSize = true;
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.Stop.Enabled = false;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(513, 734);
            this.Stop.Margin = new System.Windows.Forms.Padding(4);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(139, 79);
            this.Stop.TabIndex = 7;
            this.Stop.Text = "Закончить\r\nговорить";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Visible = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Speake
            // 
            this.Speake.AutoSize = true;
            this.Speake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.Speake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Speake.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speake.Location = new System.Drawing.Point(513, 532);
            this.Speake.Margin = new System.Windows.Forms.Padding(4);
            this.Speake.Name = "Speake";
            this.Speake.Size = new System.Drawing.Size(137, 79);
            this.Speake.TabIndex = 8;
            this.Speake.Text = "Начать\r\nговорить";
            this.Speake.UseVisualStyleBackColor = false;
            this.Speake.Visible = false;
            this.Speake.Click += new System.EventHandler(this.Speake_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(885, 466);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaxLength = 16;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(412, 34);
            this.textBox1.TabIndex = 9;
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Send.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(1407, 891);
            this.Send.Margin = new System.Windows.Forms.Padding(4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(169, 37);
            this.Send.TabIndex = 10;
            this.Send.Text = "отправить";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Visible = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // NameNewRoom
            // 
            this.NameNewRoom.AutoSize = true;
            this.NameNewRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameNewRoom.Location = new System.Drawing.Point(959, 418);
            this.NameNewRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameNewRoom.Name = "NameNewRoom";
            this.NameNewRoom.Size = new System.Drawing.Size(233, 29);
            this.NameNewRoom.TabIndex = 11;
            this.NameNewRoom.Text = "Название комнаты";
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.warning.ForeColor = System.Drawing.Color.Red;
            this.warning.Location = new System.Drawing.Point(880, 532);
            this.warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(64, 25);
            this.warning.TabIndex = 12;
            this.warning.Text = "label1";
            this.warning.Visible = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.Lavender;
            this.listView2.Enabled = false;
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView2.ForeColor = System.Drawing.Color.Black;
            this.listView2.Location = new System.Drawing.Point(683, 132);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Multiline = true;
            this.listView2.Name = "listView2";
            this.listView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listView2.Size = new System.Drawing.Size(896, 621);
            this.listView2.TabIndex = 14;
            this.listView2.Visible = false;
            this.listView2.TextChanged += new System.EventHandler(this.listView2_TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1576, 927);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.NameNewRoom);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Speake);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.AddLeaveServ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1594, 974);
            this.MinimumSize = new System.Drawing.Size(1594, 974);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameClient;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddLeaveServ;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Speake;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button settingsBut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label NameNewRoom;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.TextBox listView2;
    }
}