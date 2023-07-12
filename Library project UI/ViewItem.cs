using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_project_logic;

namespace Library_project_UI
{
    public partial class ViewItem : Form
    {
        private Main _instance;
        Item _current;
        string _oldTitle;
        bool _isLibrarian;
        public ViewItem(Main main, Item item, bool isLibrarian)
        {
            InitializeComponent();
            _instance = main;
            _current = item;
            _isLibrarian = isLibrarian;
            _oldTitle = _current.Title;

            if (item is Book)
            {
                Book temp = (Book)_current;
                TypeBox.Text = "Book";
                AuthorBox.Text = temp.Author;
            }
            else if (_current is Magazine)
            {
                AuthorBox.Enabled = false;
                label1.Visible = false;
                TypeBox.Text = "Magazine";
            }
            TitleBox.Text = _current.Title;
            GenreBox.Text = _current.Genre;
            PublisherBox.Text = _current.Publisher;
            PublishDatePicker.Value = _current.PublishDate;
            PriceBox.Text = _current.Price.ToString();
            if (!_isLibrarian)
            {
                SaveButton.Hide();
                DeleteButton.Hide();
                TitleBox.ReadOnly = true;
                GenreBox.ReadOnly = true;
                PublisherBox.ReadOnly = true;
                PublishDatePicker.Enabled = false;
                PriceBox.ReadOnly = true;
                if (item is Book)
                {
                    AuthorBox.ReadOnly = true;
                }
            }
        }

        private void ViewItem_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AuthorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ItemDelegate itemDel = ItemManager.DeleteItem;
            SureDelete sureDelete = new SureDelete(_instance, itemDel, _current);
            sureDelete.ShowDialog();
            _instance.RefreshListBox();
            this.Close();

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            double temp = _current.Price;
            if (!(double.TryParse(PriceBox.Text, out temp))) MessageBox.Show($"You must enter a valid value for Price.");
            else
            {
                _current.Title = TitleBox.Text;
                _current.Genre = GenreBox.Text;
                _current.Publisher = PublisherBox.Text;
                _current.PublishDate = PublishDatePicker.Value;
                _current.Price = temp;
                ItemManager.EditItem(_current, _oldTitle);
                MessageBox.Show("Saved");
            }
            _instance.RefreshListBox();
        }
    }
}
