namespace Library_Object____Database
{
    partial class Form1
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
            this.tableOuter = new System.Windows.Forms.TableLayoutPanel();
            this.flwAddBookForm = new System.Windows.Forms.FlowLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.fetchBtn = new System.Windows.Forms.Button();
            this.selectFileLbl = new System.Windows.Forms.Label();
            this.lblAddBookForm = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.lblAddTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.lblAddDescription = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddAuthor = new System.Windows.Forms.TextBox();
            this.lblAddAuthor = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtAddIsbn = new System.Windows.Forms.TextBox();
            this.lblAddIsbn = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.table1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblGetID = new System.Windows.Forms.Label();
            this.lblGetIsbn = new System.Windows.Forms.Label();
            this.lblGetAuthor = new System.Windows.Forms.Label();
            this.lblGetDescription = new System.Windows.Forms.Label();
            this.lblGetTitle = new System.Windows.Forms.Label();
            this.tableOuter.SuspendLayout();
            this.flwAddBookForm.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.table1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableOuter
            // 
            this.tableOuter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableOuter.ColumnCount = 2;
            this.tableOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.35101F));
            this.tableOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.64899F));
            this.tableOuter.Controls.Add(this.flwAddBookForm, 0, 0);
            this.tableOuter.Controls.Add(this.panel2, 1, 0);
            this.tableOuter.Location = new System.Drawing.Point(6, 6);
            this.tableOuter.Name = "tableOuter";
            this.tableOuter.RowCount = 1;
            this.tableOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableOuter.Size = new System.Drawing.Size(1040, 439);
            this.tableOuter.TabIndex = 0;
            // 
            // flwAddBookForm
            // 
            this.flwAddBookForm.Controls.Add(this.panel7);
            this.flwAddBookForm.Controls.Add(this.lblAddBookForm);
            this.flwAddBookForm.Controls.Add(this.panel1);
            this.flwAddBookForm.Controls.Add(this.panel3);
            this.flwAddBookForm.Controls.Add(this.panel4);
            this.flwAddBookForm.Controls.Add(this.panel5);
            this.flwAddBookForm.Controls.Add(this.btnAddBook);
            this.flwAddBookForm.Location = new System.Drawing.Point(6, 6);
            this.flwAddBookForm.Name = "flwAddBookForm";
            this.flwAddBookForm.Size = new System.Drawing.Size(277, 361);
            this.flwAddBookForm.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.fetchBtn);
            this.panel7.Controls.Add(this.selectFileLbl);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(264, 100);
            this.panel7.TabIndex = 1;
            // 
            // fetchBtn
            // 
            this.fetchBtn.Location = new System.Drawing.Point(135, 26);
            this.fetchBtn.Name = "fetchBtn";
            this.fetchBtn.Size = new System.Drawing.Size(75, 23);
            this.fetchBtn.TabIndex = 2;
            this.fetchBtn.Text = "Fetch All Books";
            this.fetchBtn.UseVisualStyleBackColor = true;
            this.fetchBtn.Click += new System.EventHandler(this.btnFetch_Click);
            // 
            // selectFileLbl
            // 
            this.selectFileLbl.AutoSize = true;
            this.selectFileLbl.Location = new System.Drawing.Point(45, 68);
            this.selectFileLbl.Name = "selectFileLbl";
            this.selectFileLbl.Size = new System.Drawing.Size(77, 13);
            this.selectFileLbl.TabIndex = 1;
            this.selectFileLbl.Text = "selectedFileLbl";
            // 
            // lblAddBookForm
            // 
            this.lblAddBookForm.AutoSize = true;
            this.lblAddBookForm.Location = new System.Drawing.Point(3, 106);
            this.lblAddBookForm.Name = "lblAddBookForm";
            this.lblAddBookForm.Size = new System.Drawing.Size(66, 13);
            this.lblAddBookForm.TabIndex = 0;
            this.lblAddBookForm.Text = "Add Product";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAddTitle);
            this.panel1.Controls.Add(this.lblAddTitle);
            this.panel1.Location = new System.Drawing.Point(3, 124);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 25);
            this.panel1.TabIndex = 2;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(88, 3);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(165, 20);
            this.txtAddTitle.TabIndex = 1;
            // 
            // lblAddTitle
            // 
            this.lblAddTitle.AutoSize = true;
            this.lblAddTitle.Location = new System.Drawing.Point(3, 6);
            this.lblAddTitle.Name = "lblAddTitle";
            this.lblAddTitle.Size = new System.Drawing.Size(35, 13);
            this.lblAddTitle.TabIndex = 0;
            this.lblAddTitle.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtAddDescription);
            this.panel3.Controls.Add(this.lblAddDescription);
            this.panel3.Location = new System.Drawing.Point(3, 157);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 25);
            this.panel3.TabIndex = 4;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Location = new System.Drawing.Point(88, 3);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.Size = new System.Drawing.Size(165, 20);
            this.txtAddDescription.TabIndex = 1;
            // 
            // lblAddDescription
            // 
            this.lblAddDescription.AutoSize = true;
            this.lblAddDescription.Location = new System.Drawing.Point(3, 6);
            this.lblAddDescription.Name = "lblAddDescription";
            this.lblAddDescription.Size = new System.Drawing.Size(60, 13);
            this.lblAddDescription.TabIndex = 0;
            this.lblAddDescription.Text = "Description";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAddAuthor);
            this.panel4.Controls.Add(this.lblAddAuthor);
            this.panel4.Location = new System.Drawing.Point(3, 190);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 25);
            this.panel4.TabIndex = 3;
            // 
            // txtAddAuthor
            // 
            this.txtAddAuthor.Location = new System.Drawing.Point(88, 3);
            this.txtAddAuthor.Name = "txtAddAuthor";
            this.txtAddAuthor.Size = new System.Drawing.Size(165, 20);
            this.txtAddAuthor.TabIndex = 1;
            // 
            // lblAddAuthor
            // 
            this.lblAddAuthor.AutoSize = true;
            this.lblAddAuthor.Location = new System.Drawing.Point(3, 6);
            this.lblAddAuthor.Name = "lblAddAuthor";
            this.lblAddAuthor.Size = new System.Drawing.Size(49, 13);
            this.lblAddAuthor.TabIndex = 0;
            this.lblAddAuthor.Text = "Category";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtAddIsbn);
            this.panel5.Controls.Add(this.lblAddIsbn);
            this.panel5.Location = new System.Drawing.Point(3, 223);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 25);
            this.panel5.TabIndex = 5;
            // 
            // txtAddIsbn
            // 
            this.txtAddIsbn.Location = new System.Drawing.Point(88, 3);
            this.txtAddIsbn.Name = "txtAddIsbn";
            this.txtAddIsbn.Size = new System.Drawing.Size(165, 20);
            this.txtAddIsbn.TabIndex = 1;
            // 
            // lblAddIsbn
            // 
            this.lblAddIsbn.AutoSize = true;
            this.lblAddIsbn.Location = new System.Drawing.Point(3, 6);
            this.lblAddIsbn.Name = "lblAddIsbn";
            this.lblAddIsbn.Size = new System.Drawing.Size(53, 13);
            this.lblAddIsbn.TabIndex = 0;
            this.lblAddIsbn.Text = "Unit Price";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(3, 254);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Product";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnCreateRecord_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.table1);
            this.panel2.Location = new System.Drawing.Point(301, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 426);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // table1
            // 
            this.table1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table1.ColumnCount = 5;
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40779F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40779F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40779F));
            this.table1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.40963F));
            this.table1.Controls.Add(this.lblGetID, 0, 0);
            this.table1.Controls.Add(this.lblGetIsbn, 4, 0);
            this.table1.Controls.Add(this.lblGetAuthor, 3, 0);
            this.table1.Controls.Add(this.lblGetDescription, 2, 0);
            this.table1.Controls.Add(this.lblGetTitle, 1, 0);
            this.table1.Location = new System.Drawing.Point(6, 3);
            this.table1.Name = "table1";
            this.table1.RowCount = 1;
            this.table1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table1.Size = new System.Drawing.Size(678, 27);
            this.table1.TabIndex = 1;
            // 
            // lblGetID
            // 
            this.lblGetID.AutoSize = true;
            this.lblGetID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetID.Location = new System.Drawing.Point(4, 1);
            this.lblGetID.Name = "lblGetID";
            this.lblGetID.Size = new System.Drawing.Size(23, 17);
            this.lblGetID.TabIndex = 5;
            this.lblGetID.Text = "ID";
            this.lblGetID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGetIsbn
            // 
            this.lblGetIsbn.AutoSize = true;
            this.lblGetIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetIsbn.Location = new System.Drawing.Point(520, 1);
            this.lblGetIsbn.Name = "lblGetIsbn";
            this.lblGetIsbn.Size = new System.Drawing.Size(79, 17);
            this.lblGetIsbn.TabIndex = 3;
            this.lblGetIsbn.Text = "Unit Price";
            this.lblGetIsbn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGetAuthor
            // 
            this.lblGetAuthor.AutoSize = true;
            this.lblGetAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetAuthor.Location = new System.Drawing.Point(360, 1);
            this.lblGetAuthor.Name = "lblGetAuthor";
            this.lblGetAuthor.Size = new System.Drawing.Size(73, 17);
            this.lblGetAuthor.TabIndex = 2;
            this.lblGetAuthor.Text = "Category";
            this.lblGetAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGetDescription
            // 
            this.lblGetDescription.AutoSize = true;
            this.lblGetDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetDescription.Location = new System.Drawing.Point(200, 1);
            this.lblGetDescription.Name = "lblGetDescription";
            this.lblGetDescription.Size = new System.Drawing.Size(90, 17);
            this.lblGetDescription.TabIndex = 1;
            this.lblGetDescription.Text = "Description";
            this.lblGetDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGetTitle
            // 
            this.lblGetTitle.AutoSize = true;
            this.lblGetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetTitle.Location = new System.Drawing.Point(40, 1);
            this.lblGetTitle.Name = "lblGetTitle";
            this.lblGetTitle.Size = new System.Drawing.Size(49, 17);
            this.lblGetTitle.TabIndex = 0;
            this.lblGetTitle.Text = "Name";
            this.lblGetTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.tableOuter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableOuter.ResumeLayout(false);
            this.flwAddBookForm.ResumeLayout(false);
            this.flwAddBookForm.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.table1.ResumeLayout(false);
            this.table1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableOuter;
        private System.Windows.Forms.FlowLayoutPanel flwAddBookForm;
        private System.Windows.Forms.Label lblAddBookForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label lblAddTitle;
        private System.Windows.Forms.Button btnAddBook;
        public System.Windows.Forms.TableLayoutPanel table1;
        private System.Windows.Forms.Label lblGetTitle;
        private System.Windows.Forms.Label lblGetDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAddDescription;
        private System.Windows.Forms.Label lblAddDescription;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtAddAuthor;
        private System.Windows.Forms.Label lblAddAuthor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtAddIsbn;
        private System.Windows.Forms.Label lblAddIsbn;
        private System.Windows.Forms.Label lblGetIsbn;
        private System.Windows.Forms.Label lblGetAuthor;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label selectFileLbl;
        private System.Windows.Forms.Button fetchBtn;
        private System.Windows.Forms.Label lblGetID;
    }
}

