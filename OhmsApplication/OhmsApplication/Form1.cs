using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhmsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CurrentRadio_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Text = "Voltage =>";
            Input2.Text = "Resistance =>";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "A", "mA", "kA" });
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "Ohm", "kOhm", "MOhm" });
        }

        private void VoltageRadio_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Text = "Current =>";
            Input2.Text = "Resistance =>";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "V", "kV", "MV" });
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "Ohm", "kOhm", "MOhm" });
        }

        private void ResistanceRadio_CheckedChanged(object sender, EventArgs e)
        {
            Input1.Text = "Current =>";
            Input2.Text = "Voltage =>";
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "A", "mA", "kA" });
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new string[] { "V", "kV", "MV" });
        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Input2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutputResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void computeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentRadio.Checked)
            {
                OutputResult.Text = (Convert.ToDouble(Output1.Text) / Convert.ToDouble(Output2.Text)).ToString();
            }
            else if (VoltageRadio.Checked)
            {
                OutputResult.Text = (Convert.ToDouble(Output1.Text) * Convert.ToDouble(Output2.Text)).ToString();
            }
            else if (ResistanceRadio.Checked)
            {
                OutputResult.Text = (Convert.ToDouble(Output2.Text) / Convert.ToDouble(Output1.Text)).ToString();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Input1.Clear();
            Input2.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            OutputResult.Text = "";
            CurrentRadio.Checked = false;
            VoltageRadio.Checked = false;
            ResistanceRadio.Checked = false;
            Input1.Text = "Current =>";
            Input2.Text = "Resistance =>";
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
