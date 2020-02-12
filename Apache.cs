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
        private Point newPoint;
        public Home()
        {
            InitializeComponent();
        }

	// Exit application
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    // When list box is changed
        private void list_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = list_items.SelectedItem.ToString();
            entity_name.Text = selectedItem;

            img_main.BackgroundImage = (Bitmap) Properties.Resources.ResourceManager.GetObject(selectedItem, Properties.Resources.Culture);

        }

    // On Mouse Move (top panel)
        private void panel_strip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - newPoint.X;
                this.Top += e.Y - newPoint.Y;
            }
        }

    // Mouse down redefines coordinates of lastPoint
        private void panel_strip_MouseDown(object sender, MouseEventArgs e)
        {
            newPoint = new Point(e.X, e.Y);
        }
    }
}