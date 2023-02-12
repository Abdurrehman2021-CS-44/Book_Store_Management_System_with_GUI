
namespace BookStoreManagementSystem
{
    partial class frmUserPage
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
            this.btnNotice = new System.Windows.Forms.Button();
            this.btnMagazines = new System.Windows.Forms.Button();
            this.btnNewspaper = new System.Windows.Forms.Button();
            this.btnBuyBook = new System.Windows.Forms.Button();
            this.btnViewBooks = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucBuyProduct1 = new BookStoreManagementSystem.ucBuyProduct();
            this.ucViewNotices1 = new BookStoreManagementSystem.ucViewNotices();
            this.ucViewMagazines1 = new BookStoreManagementSystem.ucViewMagazines();
            this.ucViewNewspaper1 = new BookStoreManagementSystem.ucViewNewspaper();
            this.ucViewBooks1 = new BookStoreManagementSystem.ucViewBooks();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ucAddEmployee1 = new BookStoreManagementSystem.ucAddEmployee();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 412);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnNotice, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnMagazines, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnNewspaper, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnBuyBook, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnViewBooks, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLogout, 0, 6);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(164, 406);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnNotice
            // 
            this.btnNotice.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnNotice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNotice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNotice.Location = new System.Drawing.Point(3, 263);
            this.btnNotice.Name = "btnNotice";
            this.btnNotice.Size = new System.Drawing.Size(158, 42);
            this.btnNotice.TabIndex = 12;
            this.btnNotice.Text = "Notice";
            this.btnNotice.UseVisualStyleBackColor = false;
            this.btnNotice.Click += new System.EventHandler(this.btnNotice_Click);
            // 
            // btnMagazines
            // 
            this.btnMagazines.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnMagazines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMagazines.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMagazines.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMagazines.Location = new System.Drawing.Point(3, 215);
            this.btnMagazines.Name = "btnMagazines";
            this.btnMagazines.Size = new System.Drawing.Size(158, 42);
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
            this.btnNewspaper.Location = new System.Drawing.Point(3, 167);
            this.btnNewspaper.Name = "btnNewspaper";
            this.btnNewspaper.Size = new System.Drawing.Size(158, 42);
            this.btnNewspaper.TabIndex = 6;
            this.btnNewspaper.Text = "Newspapers";
            this.btnNewspaper.UseVisualStyleBackColor = false;
            this.btnNewspaper.Click += new System.EventHandler(this.btnNewspaper_Click);
            // 
            // btnBuyBook
            // 
            this.btnBuyBook.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnBuyBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBuyBook.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyBook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuyBook.Location = new System.Drawing.Point(3, 119);
            this.btnBuyBook.Name = "btnBuyBook";
            this.btnBuyBook.Size = new System.Drawing.Size(158, 42);
            this.btnBuyBook.TabIndex = 5;
            this.btnBuyBook.Text = "Buy Book";
            this.btnBuyBook.UseVisualStyleBackColor = false;
            this.btnBuyBook.Click += new System.EventHandler(this.btnBuyBook_Click);
            // 
            // btnViewBooks
            // 
            this.btnViewBooks.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnViewBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewBooks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewBooks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewBooks.Location = new System.Drawing.Point(3, 71);
            this.btnViewBooks.Name = "btnViewBooks";
            this.btnViewBooks.Size = new System.Drawing.Size(158, 42);
            this.btnViewBooks.TabIndex = 0;
            this.btnViewBooks.Text = "View Books";
            this.btnViewBooks.UseVisualStyleBackColor = false;
            this.btnViewBooks.Click += new System.EventHandler(this.btnViewBooks_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(3, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 28);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Menu";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(173, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.52988F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.47012F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(461, 406);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucAddEmployee1);
            this.panel1.Controls.Add(this.ucBuyProduct1);
            this.panel1.Controls.Add(this.ucViewNotices1);
            this.panel1.Controls.Add(this.ucViewMagazines1);
            this.panel1.Controls.Add(this.ucViewNewspaper1);
            this.panel1.Controls.Add(this.ucViewBooks1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 329);
            this.panel1.TabIndex = 6;
            // 
            // ucBuyProduct1
            // 
            this.ucBuyProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBuyProduct1.Location = new System.Drawing.Point(0, 0);
            this.ucBuyProduct1.Name = "ucBuyProduct1";
            this.ucBuyProduct1.Size = new System.Drawing.Size(455, 329);
            this.ucBuyProduct1.TabIndex = 4;
            // 
            // ucViewNotices1
            // 
            this.ucViewNotices1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewNotices1.Location = new System.Drawing.Point(0, 0);
            this.ucViewNotices1.Name = "ucViewNotices1";
            this.ucViewNotices1.Size = new System.Drawing.Size(455, 329);
            this.ucViewNotices1.TabIndex = 3;
            // 
            // ucViewMagazines1
            // 
            this.ucViewMagazines1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewMagazines1.Location = new System.Drawing.Point(0, 0);
            this.ucViewMagazines1.Name = "ucViewMagazines1";
            this.ucViewMagazines1.Size = new System.Drawing.Size(455, 329);
            this.ucViewMagazines1.TabIndex = 2;
            // 
            // ucViewNewspaper1
            // 
            this.ucViewNewspaper1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewNewspaper1.Location = new System.Drawing.Point(0, 0);
            this.ucViewNewspaper1.Name = "ucViewNewspaper1";
            this.ucViewNewspaper1.Size = new System.Drawing.Size(455, 329);
            this.ucViewNewspaper1.TabIndex = 1;
            // 
            // ucViewBooks1
            // 
            this.ucViewBooks1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucViewBooks1.Location = new System.Drawing.Point(0, 0);
            this.ucViewBooks1.Name = "ucViewBooks1";
            this.ucViewBooks1.Size = new System.Drawing.Size(455, 329);
            this.ucViewBooks1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 65);
            this.panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Britannic Bold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(0, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(455, 33);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "BOOK STORE MANAGEMENT SYSTEM";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.Location = new System.Drawing.Point(3, 311);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(158, 42);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // ucAddEmployee1
            // 
            this.ucAddEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAddEmployee1.Location = new System.Drawing.Point(0, 0);
            this.ucAddEmployee1.Name = "ucAddEmployee1";
            this.ucAddEmployee1.Size = new System.Drawing.Size(455, 329);
            this.ucAddEmployee1.TabIndex = 5;
            // 
            // frmUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmUserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.frmUserPage_Load);
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
        private System.Windows.Forms.Button btnNotice;
        private System.Windows.Forms.Button btnMagazines;
        private System.Windows.Forms.Button btnNewspaper;
        private System.Windows.Forms.Button btnBuyBook;
        private System.Windows.Forms.Button btnViewBooks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private ucViewBooks ucViewBooks1;
        private ucViewNewspaper ucViewNewspaper1;
        private ucViewMagazines ucViewMagazines1;
        private ucViewNotices ucViewNotices1;
        private ucBuyProduct ucBuyProduct1;
        private System.Windows.Forms.Button btnLogout;
        private ucAddEmployee ucAddEmployee1;
    }
}