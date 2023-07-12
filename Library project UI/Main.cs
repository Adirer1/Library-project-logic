using Library_project_logic;
using System.Windows.Forms;

namespace Library_project_UI
{
    public partial class Main : Form
    {
        bool _isLibrarian;
        private Login _instance;
        public Main(Login instance, bool isLibrarian)
        {
            _instance = instance;
            _isLibrarian = isLibrarian;
            InitializeComponent();
            RefreshListBox();
            if (!_isLibrarian)
            {
                AddButton.Hide();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddButton add = new AddButton(this);
            add.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void ItemListSearchBox_TextChanged(object sender, EventArgs e)
        {
            ItemsListBox.SelectedItems.Clear();
            for (int i = ItemsListBox.Items.Count - 1; i >= 0; i--)
            {
                if (ItemListSearchBox.Text == "")
                {
                    ItemsListBox.SetSelected(i, false);
                }
                if (ItemsListBox.Items[i].ToString().ToLower().Contains(ItemListSearchBox.Text.ToLower()))
                {
                    ItemsListBox.SetSelected(i, true);
                }
            }
        }
        public void RefreshListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (Item temp in ItemManager.ItemsDict.Values)
            {
                ItemsListBox.Items.Add(temp.Title);
            }

        }

        private void Main_Load_1(object sender, EventArgs e)
        {

        }


        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {

            if (ItemsListBox.SelectedItem != null)
            {
                Item i = ItemManager.ItemsDict.Values.FirstOrDefault(item => item.Title == ItemsListBox.SelectedItem);
                ViewItem view = new ViewItem(this, i, _isLibrarian);
                view.ShowDialog();
            }
        }



        private void ItemsListBox_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.Equals(Keys.Enter) && ItemsListBox.SelectedItem != null)
            {
                Item i = ItemManager.ItemsDict.Values.FirstOrDefault(item => item.Title == ItemsListBox.SelectedItem);
                ViewItem view = new ViewItem(this, i, _isLibrarian);
                view.ShowDialog();
            }
        }



        private void ItemsListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && ItemsListBox.SelectedItem != null)
            {
                Item i = ItemManager.ItemsDict.Values.FirstOrDefault(item => item.Title == ItemsListBox.SelectedItem);
                ViewItem view = new ViewItem(this, i, _isLibrarian);
                view.ShowDialog();
            }
        }
    }
}