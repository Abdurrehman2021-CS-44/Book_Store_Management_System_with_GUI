
namespace BookStoreManagementSystem
{
    partial class frmAdminPage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReqOrder = new System.Windows.Forms.Button();
            this.btnAddNotice = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMagazines = new System.Windows.Forms.Button();
            this.btnNewspaper = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucOrderedBooks1 = new BookStoreManagementSystem.ucOrderedBooks();
            this.ucNotices1 = new BookStoreManagementSystem.ucNotices();
            this.ucMagazines2 = new BookStoreManagementSystem.ucMagazines();
            this.ucNewspaper2 = new BookStoreManagementSystem.ucNewspaper();
            this.ucUsers2 = new BookStoreManagementSystem.ucUsers();
            this.ucBooks2 = new BookStoreManagementSystem.ucBooks();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.71053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.28947F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(728, 508);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnReqOrder, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNotice, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnLogout, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnMagazines, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnNewspaper, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnUsers, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.7546F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8922F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8922F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8922F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8922F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8922F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8922F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.8922F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(188, 502);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // btnReqOrder
            // 
            this.btnReqOrder.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnReqOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReqOrder.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReqOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReqOrder.Location = new System.Drawing.Point(3, 382);
            this.btnReqOrder.Name = "btnReqOrder";
            this.btnReqOrder.Size = new System.Drawing.Size(182, 53);
            this.btnReqOrder.TabIndex = 13;
            this.btnReqOrder.Text = "Books to be Ordered";
            this.btnReqOrder.UseVisualStyleBackColor = false;
            this.btnReqOrder.Click += new System.EventHandler(this.btnReqOrder_Click);
            // 
            // btnAddNotice
            // 
            this.btnAddNotice.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAddNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNotice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNotice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNotice.Location = new System.Drawing.Point(3, 323);
            this.btnAddNotice.Name = "btnAddNotice";
            this.btnAddNotice.Size = new System.Drawing.Size(182, 53);
            this.btnAddNotice.TabIndex = 12;
            this.btnAddNotice.Text = "Add Notice";
            this.btnAddNotice.UseVisualStyleBackColor = false;
            this.btnAddNotice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(3, 441);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(182, 58);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMagazines
            // 
            this.btnMagazines.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnMagazines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMagazines.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagazines.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMagazines.Location = new System.Drawing.Point(3, 264);
            this.btnMagazines.Name = "btnMagazines";
            this.btnMagazines.Size = new System.Drawing.Size(182, 53);
            this.btnMagazines.TabIndex = 7;
            this.btnMagazines.Text = "Magazines";
            this.btnMagazines.UseVisualStyleBackColor = false;
            this.btnMagazines.Click += new System.EventHandler(this.btnMagazines_Click);
            // 
            // btnNewspaper
            // 
            this.btnNewspaper.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnNewspaper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewspaper.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewspaper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewspaper.Location = new System.Drawing.Point(3, 205);
            this.btnNewspaper.Name = "btnNewspaper";
            this.btnNewspaper.Size = new System.Drawing.Size(182, 53);
            this.btnNewspaper.TabIndex = 6;
            this.btnNewspaper.Text = "Newspapers";
            this.btnNewspaper.UseVisualStyleBackColor = false;
            this.btnNewspaper.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsers.Location = new System.Drawing.Point(3, 146);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(182, 53);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "View Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Location = new System.Drawing.Point(3, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 53);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Books";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(3, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Admin Menu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(197, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.52988F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.47012F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(528, 502);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucOrderedBooks1);
            this.panel1.Controls.Add(this.ucNotices1);
            this.panel1.Controls.Add(this.ucMagazines2);
            this.panel1.Controls.Add(this.ucNewspaper2);
            this.panel1.Controls.Add(this.ucUsers2);
            this.panel1.Controls.Add(this.ucBooks2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 408);
            this.panel1.TabIndex = 6;
            // 
            // ucOrderedBooks1
            // 
            this.ucOrderedBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderedBooks1.Location = new System.Drawing.Point(0, 0);
            this.ucOrderedBooks1.Name = "ucOrderedBooks1";
            this.ucOrderedBooks1.Size = new System.Drawing.Size(522, 408);
            this.ucOrderedBooks1.TabIndex = 5;
            // 
            // ucNotices1
            // 
            this.ucNotices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNotices1.Location = new System.Drawing.Point(0, 0);
            this.ucNotices1.Name = "ucNotices1";
            this.ucNotices1.Size = new System.Drawing.Size(522, 408);
            this.ucNotices1.TabIndex = 4;
            // 
            // ucMagazines2
            // 
            this.ucMagazines2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMagazines2.Location = new System.Drawing.Point(0, 0);
            this.ucMagazines2.Name = "ucMagazines2";
            this.ucMagazines2.Size = new System.Drawing.Size(522, 408);
            this.ucMagazines2.TabIndex = 3;
            // 
            // ucNewspaper2
            // 
            this.ucNewspaper2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucNewspaper2.Location = new System.Drawing.Point(0, 0);
            this.ucNewspaper2.Name = "ucNewspaper2";
            this.ucNewspaper2.Size = new System.Drawing.Size(522, 408);
            this.ucNewspaper2.TabIndex = 2;
            // 
            // ucUsers2
            // 
            this.ucUsers2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucUsers2.Location = new System.Drawing.Point(0, 0);
            this.ucUsers2.Name = "ucUsers2";
            this.ucUsers2.Size = new System.Drawing.Size(522, 408);
            this.ucUsers2.TabIndex = 1;
            // 
            // ucBooks2
            // 
            this.ucBooks2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBooks2.Location = new System.Drawing.Point(0, 0);
            this.ucBooks2.Name = "ucBooks2";
            this.ucBooks2.Size = new System.Drawing.Size(522, 408);
            this.ucBooks2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 82);
            this.panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Britannic Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(0, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(522, 33);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "BOOK STORE MANAGEMENT SYSTEM";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(3, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 53);
            this.button2.TabIndex = 6;
            this.button2.Text = "Newspapers";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmAdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "frmAdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.frmAdminPage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMagazines;
        private System.Windows.Forms.Button btnNewspaper;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReqOrder;
        private System.Windows.Forms.Button btnAddNotice;
        private System.Windows.Forms.Button button2;
        private ucMagazines ucMagazines1;
        private ucNewspaper ucNewspaper1;
        private ucUsers ucUsers1;
        private ucBooks ucBooks1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private ucBooks ucBooks2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private ucNewspaper ucNewspaper2;
        private ucUsers ucUsers2;
        private ucOrderedBooks ucOrderedBooks1;
        private ucNotices ucNotices1;
        private ucMagazines ucMagazines2;
    }
}