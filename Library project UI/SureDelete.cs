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
namespace Library_project_UI
{
    public partial class SureDelete : Form
    {
        private Main instance;
        Item current;
        ItemDelegate itemDel;
        public SureDelete(Main main, ItemDelegate del, Item item)
        {
            InitializeComponent();
            instance = main;
            current = item;
            itemDel = del;
        }

        private void SureDelete_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            itemDel(current);
            MessageBox.Show("Deleted");
            this.Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
