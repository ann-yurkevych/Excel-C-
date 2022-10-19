using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablet
{
    public partial class Notes : Form
    {
        public Notes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowDialog();
            this.richTextBox1.SelectionFont = this.fontDialog1.Font;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.colorDialog1.ShowDialog();
            this.richTextBox1.SelectionColor = this.colorDialog1.Color;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id=0;
            int lastId = id;
            lastId += 1;
            string fileName = Application.StartupPath + lastId.ToString();
            this.richTextBox1.SaveFile(fileName);
        }
    }
}
