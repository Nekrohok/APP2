using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public class DataContainer
        {
            public event EventHandler AcceptedChanges;
            protected virtual void OnAcceptedChanges()
            {
                if ((this.AcceptedChanges != null))
                {
                    this.AcceptedChanges(this, EventArgs.Empty);
                }
            }

            public void AcceptChanges()
            {
                this.OnAcceptedChanges();
            }

            public string Text1 { get; set; }
            public string Text2 { get; set; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text != null)
            {
                Application.Exit();
            }
        }
        public string text;
        public string text1;
        public string text2;
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            text = comboBox1.GetItemText(comboBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


            switch (text)
            {
                case "Параметр 1":
                    text1 = richTextBox1.Text;
                    break;
                case "Параметр 2":
                    text2 = richTextBox1.Text;
                    break;

            }
        }
    }
}
