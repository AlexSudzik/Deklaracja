namespace Deklaracja
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("INF.02");
            comboBox2.Items.Add("INF.03");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("INF.03");
            comboBox2.Items.Add("INF.04");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedItem.ToString() == "INF.02")
            {
                label13.Text = "Administracja i eksplotacja systemów komputerowych, urz¹dzeñ peryferyjnych i lokalnych sieci komputerowych";
            }
            else
            {
                if(comboBox2.SelectedItem.ToString() == "INF.03")
                {
                    label13.Text = "Tworzenie i admistorwanie stronami i aplikacjami internetowymi oraz bazami danych";
                }
                else
                {
                    label13.Text = "Projektowanie, programowanie i testowanie aplikacji";
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Checked=false;
                checkBox1.Enabled=false;
                checkBox2.Checked=false;
                checkBox2.Enabled=false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Enabled=true;
            checkBox2.Enabled=true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red;
            }else
            {
                textBox1.BackColor = Color.White;
            }

            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.Red;
            }else
            {
                textBox2.BackColor = Color.White;
            }
            
            if (maskedTextBox1.MaskFull == false)
            {
                maskedTextBox1.BackColor = Color.Red;
            }else
            {
                maskedTextBox1.BackColor = Color.White;
            }
            
            if (textBox5.Text == "")
            {
                textBox5.BackColor = Color.Red;
            }else
            {
                textBox5.BackColor = Color.White;
            }

            if (maskedTextBox2.MaskFull == false)
            {
                maskedTextBox2.BackColor = Color.Red;
            }else
            {
                maskedTextBox2.BackColor = Color.White;
            }

            if (textBox6.Text == "")
            {
                textBox6.BackColor = Color.Red;
            }else
            {
                textBox6.BackColor = Color.White;
            }

            if (textBox7.Text == "")
            {
                textBox7.BackColor = Color.Red;
            }else
            {
                textBox7.BackColor = Color.White;
            }

            if (maskedTextBox3.MaskFull == false)
            {
                maskedTextBox3.BackColor = Color.Red;
            }else
            {
                maskedTextBox3.BackColor = Color.White;
            }

            if (textBox8.Text == "")
            {
                textBox8.BackColor = Color.Red;
            }else
            {
                textBox8.BackColor = Color.White;
            }

            if (textBox11.Text == "")
            {
                textBox11.BackColor = Color.Red;
            }else
            {
                textBox11.BackColor = Color.White;
            }
            if (textBox9.Text == "")
            {
                textBox9.BackColor = Color.Red;
            }else
            {
                textBox9.BackColor = Color.White;
            }


            listBox1.Items.Clear();
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(maskedTextBox1.Text);
            listBox1.Items.Add(textBox5.Text);
            listBox1.Items.Add(maskedTextBox2.Text);
            listBox1.Items.Add(textBox6.Text);
            listBox1.Items.Add(textBox7.Text);
            listBox1.Items.Add(maskedTextBox3.Text);
            listBox1.Items.Add(textBox8.Text);
            listBox1.Items.Add(textBox11.Text);
            listBox1.Items.Add(textBox9.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Clear();
            textBox5.Text = "";
            maskedTextBox2.Clear();
            textBox6.Text = "";
            textBox7.Text = "";
            maskedTextBox3.Clear();
            textBox8.Text = "";
            textBox11.Text = "";
            textBox9.Text = "";

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            maskedTextBox1.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            maskedTextBox2.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            maskedTextBox3.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox9.BackColor = Color.White;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}