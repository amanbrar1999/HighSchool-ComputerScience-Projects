using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Head_Soccer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void moveObjects(PictureBox player, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                player.Left += 10;
            }
            else if(e.KeyCode == Keys.Left)
            {
                player.Left -= 10;
            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            moveObjects(player1,e);
        }
    }
}
