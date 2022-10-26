using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Form2 form = new Form2();

        private void button2_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (WinFormsApp1.Form2.)
        }
    }
}