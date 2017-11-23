using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evolution.Forms
{
    public partial class TextDialog : Form
    {
        public TextDialog(string text, string caption)
        {
            InitializeComponent();
            this.labelMessage.Text = text;
            this.Text = caption;
        }

        public string Value = "";
        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Value = textInput.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
