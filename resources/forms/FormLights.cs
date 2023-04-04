using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteKeypadUI.resources.forms
{
    public partial class FormLights : Form
    {
        public FormLights()
        {
            InitializeComponent();
        }

        private void FormLights_Load(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar3.Value.ToString();
            textBox3.Text = trackBar2.Value.ToString();
        }

        private void colorDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = LLColorPicked.BackColor;
            colorDialog1.ShowDialog();
        }

        private static string ToRGB(Color color)
        {
            return $"{color.R.ToString()}, {color.G.ToString()}, {color.B.ToString()}";
        }

        private static string ToHex(Color color)
        {
            return $"#{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}";
        }

        private void copyHTMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ToHex(LLColorPicked.BackColor));
        }

        private void copyRGBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(ToRGB(LLColorPicked.BackColor));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            LLColorPicked.BackColor = Color.FromArgb(trackBar1.Value, trackBar3.Value, trackBar2.Value);
            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar3.Value.ToString();
            textBox3.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            LLColorPicked.BackColor = Color.FromArgb(trackBar1.Value, trackBar3.Value, trackBar2.Value);
            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar3.Value.ToString();
            textBox3.Text = trackBar2.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            LLColorPicked.BackColor = Color.FromArgb(trackBar1.Value, trackBar3.Value, trackBar2.Value);
            textBox1.Text = trackBar1.Value.ToString();
            textBox2.Text = trackBar3.Value.ToString();
            textBox3.Text = trackBar2.Value.ToString();
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(trackBar6.Value, trackBar4.Value, trackBar5.Value);
            textBox6.Text = trackBar6.Value.ToString();
            textBox5.Text = trackBar4.Value.ToString();
            textBox4.Text = trackBar5.Value.ToString();
        }

        private void trackBar3_Scroll_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(trackBar6.Value, trackBar4.Value, trackBar5.Value);
            textBox6.Text = trackBar6.Value.ToString();
            textBox5.Text = trackBar4.Value.ToString();
            textBox4.Text = trackBar5.Value.ToString();
        }

        private void trackBar2_Scroll_1(object sender, EventArgs e)
        {
            panel3.BackColor = Color.FromArgb(trackBar6.Value, trackBar4.Value, trackBar5.Value);
            textBox6.Text = trackBar6.Value.ToString();
            textBox5.Text = trackBar4.Value.ToString();
            textBox4.Text = trackBar5.Value.ToString();
        }

        private void colorDialogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            colorDialog1.Color = panel3.BackColor;
            colorDialog1.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
