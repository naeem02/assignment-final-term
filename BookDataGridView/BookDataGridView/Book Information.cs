using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDataGridView
{
    public partial class Book_Information : Form
    {

        //BusinessLayer.ProductService productService = new Business_Layer.ProductService();
        ProductService.ProductService ps = new ProductService.ProductService();
        public Book_Information()
        {
            InitializeComponent();
            bookinfodatagridview.AutoGenerateColumns = false;
            bookinfodatagridview.ColumnCount = 4;
            bookinfodatagridview.Columns[0].HeaderText = "ID";
            bookinfodatagridview.Columns[1].HeaderText = "Name";
            bookinfodatagridview.Columns[2].HeaderText = "Author";
            bookinfodatagridview.Columns[3].HeaderText = "Edition";

            DataTable dt = ps.GetAllBooksInfo();
            bookinfodatagridview.DataSource = dt;

            bookinfodatagridview.Columns[0].DataPropertyName = "bookid";
            bookinfodatagridview.Columns[1].DataPropertyName = "bookname";
            bookinfodatagridview.Columns[2].DataPropertyName = "bookauthor";
            bookinfodatagridview.Columns[3].DataPropertyName = "bookedition";
            bookinfodatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Book_Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        string bn;
        private void button1_Click(object sender, EventArgs e)
        {
            bn = textBox1.Text.ToUpper();
            if(string.IsNullOrEmpty(bn))
            {

                MessageBox.Show("Give a book name to get Information");
            }
            else
            {
                loadFunction(bn);
            }
        }
        private void loadFunction(string bn)
        {
            DataTable dt = ps.GetBookInfo(bn);
            bookinfodatagridview.DataSource = dt;

            bookinfodatagridview.Columns[0].DataPropertyName = "bookid";
            bookinfodatagridview.Columns[1].DataPropertyName = "bookname";
            bookinfodatagridview.Columns[2].DataPropertyName = "bookauthor";
            bookinfodatagridview.Columns[3].DataPropertyName = "bookedition";
            bookinfodatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
