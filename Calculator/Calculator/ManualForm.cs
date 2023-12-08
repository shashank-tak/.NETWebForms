using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class ManualForm : Form
    {
        public ManualForm()
        {
            InitializeComponent();
            InitializeManualContents();
        }
        private void InitializeManualContents()
        {
            Label labelAdd = new Label();
            labelAdd.Text = "";
            labelAdd.Top = 10;
            labelAdd.Left = 10;
            labelAdd.Width = 300;
            this.Controls.Add(labelAdd);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ManualForm_Load(object sender, EventArgs e)
        {

        }
    }
}
