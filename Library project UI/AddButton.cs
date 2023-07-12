using Library_project_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_project_logic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace Library_project_UI
{
    public partial class AddButton : Form
    {
        private Main instance;
        double price;
        bool isInfoValid;
        public AddButton(Main main)
        {

            InitializeComponent();
            instance = main;
            BookButton.Checked = true;
        }

        private void AddButton_Load(object sender, EventArgs e)
        {

        }

        private void BookButton_CheckedChanged(object sender, EventArgs e)
        {
            AuthorBox.Enabled = true;

        }

        private void MagazineButton_CheckedChanged(object sender, EventArgs e)
        {
            AuthorBox.Enabled = false;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            isInfoValid = false;
            if (TitleBox.Text == null || TitleBox.Text.Equals("")) MessageBox.Show($"You must enter a value for Title.");
            else if (GenreBox.Text == null || GenreBox.Text.Equals("")) MessageBox.Show($"You must enter a value for Genre.");
            else if (PublisherBox.Text == null || PublisherBox.Text.Equals("")) MessageBox.Show($"You must enter a value for Publisher.");
            else if (PriceBox.Text == null || PriceBox.Text.Equals("")) MessageBox.Show($"You must enter a value for Price.");
            else try
                {
                    price = Convert.ToDouble(PriceBox.Text);
                    isInfoValid = true;
                }
                catch { MessageBox.Show($"You must enter a valid value for Price."); }
            if (BookButton.Checked == true && isInfoValid)
            {
                if (AuthorBox.Text == null || AuthorBox.Text.Equals("")) MessageBox.Show($"You must enter a value for Author.");
                else
                {
                    Book book = new Book();
                    book.Author = AuthorBox.Text;
                    book.Title = TitleBox.Text;
                    book.Genre = GenreBox.Text;
                    book.Publisher = PublisherBox.Text;
                    book.Price = price;
                    book.PublishDate = PublishDatePicker.Value;
                    ItemManager.AddItem(book);
                    MessageBox.Show("Saved.");
                    this.Close();
                }
            }
            else if (MagazineButton.Checked == true && isInfoValid)
            {
                Magazine mag = new Magazine();
                mag.Title = TitleBox.Text;
                mag.Genre = GenreBox.Text;
                mag.Publisher = PublisherBox.Text;
                mag.Price = price;
                mag.PublishDate = PublishDatePicker.Value;
                ItemManager.AddItem(mag);
                MessageBox.Show("Saved.");
                this.Close();
            }
            instance.RefreshListBox();


        }

        private void AddButton_Load_1(object sender, EventArgs e)
        {

        }

        private void AuthorBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

