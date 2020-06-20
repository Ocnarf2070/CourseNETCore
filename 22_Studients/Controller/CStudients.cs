using Controller.Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public class CStudients : Libraries
    {
        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;

        public CStudients(List<TextBox> listTextBox, List<Label> listLabel, Object[] objects)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            this.image = (PictureBox)objects[0];
        }

        public void Register()
        {
            if (listTextBox.Select(x => x.Text.Equals("")).Contains(true))
            {
                bool first = true;
                for (int i = 0; i < listLabel.Count; i++)
                {
                    if (listTextBox[i].Text.Equals(""))
                    {
                        listLabel[i].Text = $"This field is required";
                        listLabel[i].ForeColor = Color.Red;
                        if (first)
                        {
                            listTextBox[i].Focus();
                            first = false;
                        }
                    }
                }
            }
            else if (!textBoxEvent.checkEmailFormat(listTextBox[3].Text))
            {
                listLabel[3].Text = "Email not valid";
                listLabel[3].ForeColor = Color.Red;
                listTextBox[3].Focus();
            }
            else
            {
                var imageArray = uploadImage.ImageToByte(image.Image);
            }


        }
    }
}
