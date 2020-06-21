using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studients
{
    public partial class Form1 : Form
    {
        private CStudients studient;
        public Form1()
        {
            InitializeComponent();

            var listTextBox = new List<TextBox>();
            var listLabel = new List<Label>();

            listTextBox.Add(textBoxNID);
            listLabel.Add(labelNID);
            listTextBox.Add(textBoxSurname);
            listLabel.Add(labelSurname);
            listTextBox.Add(textBoxName);
            listLabel.Add(labelName);
            listTextBox.Add(textBoxEmail);
            listLabel.Add(labelEmail); 
            
            Object[] obj = { pictureBoxImage };

            studient = new CStudients(listTextBox, listLabel, obj);



        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            studient.uploadImage.LoadImage(pictureBoxImage);
        }

        private void textBoxNID_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNID.Text.Equals(""))
            {
                labelNID.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNID.ForeColor = Color.Green;
                labelNID.Text = "NID";
            }

        }

        private void textBoxNID_KeyPress(object sender, KeyPressEventArgs e)
        {
            studient.textBoxEvent.numberKeyPress(e);
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSurname.Text.Equals(""))
            {
                labelSurname.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelSurname.ForeColor = Color.Green;
                labelSurname.Text = "Surname";
            }

        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            studient.textBoxEvent.textKeyPress(e);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Equals(""))
            {
                labelName.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelName.ForeColor = Color.Green;
                labelName.Text = "Name";
            }

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            studient.textBoxEvent.textKeyPress(e);
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email";
            }


        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            studient.Register();
        }
    }
}
