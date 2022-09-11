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
                label13.Text = "Administracja i eksplotacja systemów komputerowych, urządzeń peryferyjnych i lokalnych sieci komputerowych";
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
            if (comboBox1.Text == "")
            {
                comboBox1.BackColor = Color.Red;
            }
            else
            {
                comboBox1.BackColor = Color.White;
            }
            if (comboBox2.Text == "")
            {
                comboBox2.BackColor = Color.Red;
            }
            else
            {
                comboBox2.BackColor = Color.White;
            }
            



            listBox1.Items.Clear();
            listBox1.Items.Add("Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikację w zawodzie");
            listBox1.Items.Add("przeprowadzanego w terminie " + comboBox1.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("Dane osobowe ucznia");
            listBox1.Items.Add(" Nazwisko:                               " + textBox1.Text);
            listBox1.Items.Add(" Imię (imiona):                        " + textBox2.Text);
            listBox1.Items.Add(" Data i miejsce urodzenia:     " + maskedTextBox1.Text + ", " + textBox5.Text);
            listBox1.Items.Add(" Numer PESEL:                        " + maskedTextBox2.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("Adres korespondecyjny");
            listBox1.Items.Add(" miejscowość:                             " + textBox6.Text);
            listBox1.Items.Add(" ulica i numer domu:                 " + textBox7.Text);
            listBox1.Items.Add(" kod pocztowy i poczta:            " + maskedTextBox3.Text + textBox8.Text);
            listBox1.Items.Add(" nr telefonu z kierunkowym:     " + textBox11.Text);
            listBox1.Items.Add(" mail:                                            " + textBox9.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("");

            if (checkBox1.Checked && checkBox2.Checked == false)
            {
                listBox1.Items.Add("Deklaruję przystąpienie do egzaminu poraz koljeny do części pisemnej");
                }
                else if (checkBox2.Checked && checkBox1.Checked == false)
                {
                    listBox1.Items.Add("Deklaruję przystąpienie do egzaminu poraz koljeny do części praktycznej");
                }
                    else if(checkBox1.Checked && checkBox2.Checked)
                    listBox1.Items.Add("Deklaruję przystąpienie do egzaminu poraz koljeny do części pisemnej i praktycznej");
                else
                {
                    listBox1.Items.Add("Deklaruję przystąpienie do egzaminu poraz koljeny do części ");
                }

            listBox1.Items.Add("");
            listBox1.Items.Add("Oznaczenie kwalifikacji zgodnie z podstawą programową: " + comboBox2.Text);
            listBox1.Items.Add("Nazwa kwalifikacji: " + label13.Text);
            listBox1.Items.Add("");

            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Symbol cyfrowy zawodu: 351203");
            }else if (radioButton2.Checked) {
                listBox1.Items.Add("Symbol cyfrowy zawodu: 351406");
            }
            else {
                listBox1.Items.Add("Symbol cyfrowy zawodu: ");
            }



            if (radioButton1.Checked)
            {
                listBox1.Items.Add("Nazwa zawodu: technik informatyk");
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Add("Nazwa zawodu: technik programista");
            }
            else
            {
                listBox1.Items.Add("Symbol cyfrowy zawodu: ");
            }



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
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;

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
            comboBox1.BackColor= Color.White;
            comboBox2.BackColor = Color.White;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox1.Items[i]);
                }
                writer.Close();
            }
            dlg.Dispose();


        }
    }
}
