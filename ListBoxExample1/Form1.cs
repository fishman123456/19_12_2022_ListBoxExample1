using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBoxExample1
{
    public partial class Form1 : Form
    {
        public enum DateTimeFormat { ShowClock, ShowDate };
        public Form1()
        {
            InitializeComponent();
            NumericUpDown updown = new NumericUpDown();
           


        }

        private void btnAddToListBox_Click(object sender, EventArgs e)
        {
            this.listBox1.Text = numericUpDown1.Value.ToString();
            if (!String.IsNullOrEmpty(this.textBox1.Text))
            {
                if (!this.listBox1.Items.Contains(this.textBox1.Text))
                {
                    this.listBox1.Items.Add(this.textBox1.Text);
                }
                else
                    MessageBox.Show("Strings must be unique");
            }
            else
                MessageBox.Show("Empty string");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCopyFromListBox_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();

            if(this.listBox1.Items.Count != 0)

            for (int i = 0; i < this.listBox1.Items.Count; i++)
          
                this.listBox2.Items.Add(this.listBox1.Items[i]);
            else
                MessageBox.Show("The first ListBox is empty");
         
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                if (this.listBox1.SelectedItems != null)
                {
                    for (int i = 0; i < this.listBox1.SelectedItems.Count; i++)
                    {
                        this.listBox1.Items.Remove(this.listBox1.SelectedItems[i]);
                        i--;
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
           
        }

        private void button_Add_NumericUpDown_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = (trackBar1.Value.ToString());
           // this.textBox1.Text=(numericUpDown1.Value.ToString());
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            
            DateTimeFormat format = DateTimeFormat.ShowClock;
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            string str;
            str = DateTime.Now.ToShortDateString();
            this.toolStripStatusLabel1.Text = str;
            str = DateTime.Now.DayOfWeek.ToString();
          
            if (format == DateTimeFormat.ShowClock)
            {
                this.toolStripStatusLabel1.Text =
                DateTime.Now.ToShortTimeString();
                format = DateTimeFormat.ShowDate;
            }
            else
            {
                this.toolStripStatusLabel1.Text =
                DateTime.Now.ToShortDateString();
                format = DateTimeFormat.ShowClock;
            }
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackBar1.Minimum= 0;
            trackBar1.Maximum= 100;
            // trackBar1.Value =Convert.ToInt16(numericUpDown1.Value);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = (trackBar1.Value.ToString());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2 = new TextBox();
           
          
        }
    }
}
