namespace Tempreture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                TextBox? textBoxObject = sender as TextBox;

                if (textBoxObject != null)
                {
                    if (textBoxObject.TabIndex == 5)
                    {
                        textBox6.Text = (Convert.ToSingle(textBox3.Text) * (9 / 5) + 32).ToString();
                        textBox7.Text = (Convert.ToSingle(textBox3.Text) + 273.15f).ToString();
                    }
                    else if (textBoxObject.TabIndex == 6)
                    {
                        textBox3.Text = ((Convert.ToSingle(textBox6.Text) - 32) * 5 / 9).ToString();
                        textBox7.Text = (((Convert.ToSingle(textBox6.Text) - 32) * 5 / 9) + 273.15f).ToString();
                    }
                    else if (textBoxObject.TabIndex == 7)
                    {
                        textBox3.Text = (Convert.ToSingle(textBox7.Text) - 273.15f).ToString();
                        textBox6.Text = (((Convert.ToSingle(textBox7.Text) - 273.15f) * 9 / 5) + 32).ToString();
                    }
                }
            }
        }
    }
}