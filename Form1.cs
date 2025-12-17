using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Object____Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Create a database record
        private void btnCreateRecord_Click(object reader, EventArgs e)
        {
            string connectionString = @"Data Source=BB21304\FA25_OOP_SQL_EK; Initial Catalog=myfirstdb; User ID=InventoryUser; Password=1234; TrustServerCertificate=True";

            SqlConnection currConnection;
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            string name = txtAddTitle.Text;
            string description = txtAddDescription.Text;
            string category = txtAddAuthor.Text;
            string unitPrice = txtAddIsbn.Text;

            string sqlStatement = "INSERT INTO dbo.InventorySystem (ProductName, Description, Category, UnitPrice) VALUES (@name, @description, @category, @unitPrice)";
            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
            myQuery.Parameters.AddWithValue("@name", name);
            myQuery.Parameters.AddWithValue("@description", description);
            myQuery.Parameters.AddWithValue("@category", category);
            myQuery.Parameters.AddWithValue("@unitPrice", unitPrice);

            myQuery.ExecuteNonQuery();

            currConnection.Close();
        }

        private void btnFetch_Click(object reader, EventArgs e)
        {
            string connectionString = @"Data Source=BB21304\FA25_OOP_SQL_EK; Initial Catalog=myfirstdb; User ID=InventoryUser; Password=1234; TrustServerCertificate=True";

            SqlConnection currConnection;
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            string sqlStatement = "SELECT ProductID , ProductName , Description , Category , UnitPrice  FROM dbo.InventorySystem";
            SqlCommand myQuery = new SqlCommand(sqlStatement, currConnection);
            SqlDataReader myReader = myQuery.ExecuteReader();

            table1.RowStyles.Clear();  //first you must clear rowStyles
            // reset height
            table1.Height = 30;

            // Remove all controls NOT in row 0
            for (int i = table1.Controls.Count - 1; i >= 0; i--)
            {
                Control c = table1.Controls[i];
                if (table1.GetRow(c) > 0)
                    table1.Controls.RemoveAt(i);
            }

            // Remove all row styles except the first
            while (table1.RowStyles.Count > 1)
            {
                table1.RowStyles.RemoveAt(1);
            }

            // Reset the row count to 1
            table1.RowCount = 1;

            int readingIndex = 1;
            while (myReader.Read())
            {
                List<string> columns = Enumerable.Range(0, myReader.FieldCount).Select(myReader.GetName).ToList();

                // Modified from Source - https://stackoverflow.com/a
                // Posted by Ali Motamedi, modified by community. See post 'Timeline' for change history
                // Retrieved 2025-11-18, License - CC BY-SA 3.0
                // Purpose of source: Add row to table

                int index = 0;

                foreach (string column in columns)
                {
                    if (index == 0)
                    {
                        Label upload = new Label();
                        upload.Text = myReader[column].ToString();
                        table1.Controls.Add(upload, columns.IndexOf(column), readingIndex);  // add label in column0
                    }
                    else
                    {
                        TextBox upload = new TextBox();
                        upload.Text = myReader[column].ToString();
                        table1.Controls.Add(upload, columns.IndexOf(column), readingIndex);  // add label in column
                    }
                    index++;
                }

                // After puting all data in the row, add the save button to the lastcolumn
                
                Button saveBtn = new Button();
                saveBtn.Text = "Save";
                table1.Controls.Add(saveBtn, index, readingIndex);  // add label in column0

                // add the onclick function to every save button created
                saveBtn.Click += btnSave_Click;
                


                table1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // 30 is the rows space
                table1.Height = table1.Height + 30;
                readingIndex++;
            }

            table1.Height = table1.Height + 15;
            panel1.Height = panel1.Height + 30;


            currConnection.Close();
        }


        public void btnSave_Click(object sender, EventArgs e)
        {
            // Which button was clicked?
            Button btnSave = sender as Button;
            if (btnSave == null) return;

            // MessageBox.Show("Click did gud");
            string connectionString = @"Data Source=BB21304\FA25_OOP_SQL_EK; Initial Catalog=myfirstdb; User ID=InventoryUser; Password=1234; TrustServerCertificate=True";

            SqlConnection currConnection;
            currConnection = new SqlConnection(connectionString);
            currConnection.Open();

            int rowIndex = (table1.GetPositionFromControl(btnSave)).Row;


            int productId = 0;
            TextBox txtTitle = null;
            TextBox txtDescription = null;
            TextBox txtAuthor = null;
            TextBox txtIsbn = null;
            TextBox txtCheckedOut = null;

            // Loop all controls, filter by rowIndex, and map them by column
            foreach (Control c in table1.Controls)
            {
                if (table1.GetRow(c) != rowIndex) continue;

                int col = table1.GetColumn(c);

                // Based on your SELECT order:
                // 0 = BookID (Label)
                // 1 = BookTitle
                // 2 = BookDescription
                // 3 = BookAuthor
                // 4 = BookISBN
                // 5 = IsCheckedOut
                // 6 = Save button

                switch (col)
                {
                    case 0:
                        if (c is Label lbl)
                            int.TryParse(lbl.Text, out productId);
                        break;
                    case 1:
                        txtTitle = c as TextBox;
                        break;
                    case 2:
                        txtDescription = c as TextBox;
                        break;
                    case 3:
                        txtAuthor = c as TextBox;
                        break;
                    case 4:
                        txtIsbn = c as TextBox;
                        break;
                    case 5:
                        txtCheckedOut = c as TextBox;
                        break;
                }
            }

            // Safety check
            if (productId == 0 || txtTitle == null || txtDescription == null ||
                txtAuthor == null || txtIsbn == null || txtCheckedOut == null)
            {
                MessageBox.Show("Could not resolve row controls for update.");
                return;
            }


            // get the row with this id? Change row w
            string updateQuery = @"UPDATE dbo.InventorySystem SET ProductName = @t, BookDescription = @d, BookAuthor = @a, BookISBN = @i, IsCheckedOut = @c WHERE BookID = @id;";
            // Add parameters
            SqlCommand command = new SqlCommand(updateQuery, currConnection);
            command.Parameters.AddWithValue("@t", txtTitle.Text);
                command.Parameters.AddWithValue("@d", txtDescription.Text);
                command.Parameters.AddWithValue("@a", txtAuthor.Text);
                command.Parameters.AddWithValue("@i", txtIsbn.Text);
                command.Parameters.AddWithValue("@c", txtCheckedOut.Text);
               command.Parameters.AddWithValue("@id", productId);
            
            command.ExecuteNonQuery();
            MessageBox.Show("Row saved!");

            currConnection.Close();
        }

    }
}

