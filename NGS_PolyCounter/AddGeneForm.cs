using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGS_PolyCounter
{
    public partial class AddGeneForm : Form
    {
        public AddGeneForm()
        {
            InitializeComponent();
        }

        private void AddGeneForm_Load(object sender, EventArgs e)
        {
            this.FormClosing += This_OnClosing;
        }

        private void This_OnClosing(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
