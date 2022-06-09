using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cheat_Loader_By_LeonimusT
{
    public partial class options : Form
    {
        public options()
        {
            InitializeComponent();

            autoupdateCheckBox.Checked = Properties.Settings.Default.AutoUpdate;
            autoinjectCheckBox.Checked = Properties.Settings.Default.AutoInject;
        }

        //close button
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //drag the window
        bool mouseDown = false;
        private Point offset;
        private void topName_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }
        private void topName_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }
        private void topName_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        //end drag window

        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutoUpdate = autoupdateCheckBox.Checked;
            Properties.Settings.Default.AutoInject = autoinjectCheckBox.Checked;
            Properties.Settings.Default.Save();

            this.Hide();
        }
    }
}
