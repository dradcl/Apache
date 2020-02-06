using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HLStats
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

	// Exit application
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        // When list box is changed
        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = list_items.SelectedItem.ToString();
            test_label.Text = selectedItem;

            img_main.BackgroundImage = (Bitmap) Properties.Resources.ResourceManager.GetObject(selectedItem, Properties.Resources.Culture);

        }
    }
}
