using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolution
{
    public partial class ShowImageForm : Form
    {
        public ShowImageForm(Image img)
        {
            InitializeComponent();
            ShowPictureBox.Image = img;
        }
    }
}
