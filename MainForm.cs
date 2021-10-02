using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkUpdateUi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FireFirstForm(object sender, EventArgs e)
        {
            var form = new WorkerForm(progressBar1, button1);
            form.Show();
        }

        private void FireSecondForm(object sender, EventArgs e)
        {
            var form = new WorkerForm(progressBar2, button2);
            form.Show();
        }
    }
}
