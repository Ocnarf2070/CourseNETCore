using Controller.Library;
using Data;
using LinqToDB;
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
        //private Libraries libraries = new Libraries();
        //private Conection database = new Conection();

        private List<TextBox> listTextBox;
        private List<Label> listLabel;
        private PictureBox image;


        public CStudients(List<TextBox> listTextBox, List<Label> listLabel, Object[] objects)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            this.image = (PictureBox)objects[0];
        }

        public void RegisterStudient()
        {

            bool first = true;
            for (int i = 0; i < listLabel.Count; i++)
            {
                if (listTextBox[i].Text.Equals(""))
                {
                    listLabel[i].Text = "This field is required";
                    listLabel[i].ForeColor = Color.Red;
                    if (first)
                    {
                        listTextBox[i].Focus();
                        first = false;
                    }
                }
            }
            if (first)
            {
                if (_Studient.Where(e => e.nid.Equals(listTextBox[1].Text)).Count() != 0)
                {
                    listLabel[1].Text = "Nid is already registered";
                    listLabel[1].ForeColor = Color.Red;
                    listTextBox[1].Focus();
                }
                else if (!textBoxEvent.checkEmailFormat(listTextBox[3].Text))
                {
                    listLabel[3].Text = "Email not valid";
                    listLabel[3].ForeColor = Color.Red;
                    listTextBox[3].Focus();
                }
                else if (_Studient.Where(e => e.email.Equals(listTextBox[3].Text)).Count() != 0)
                {
                    listLabel[3].Text = "Email is already registered";
                    listLabel[3].ForeColor = Color.Red;
                    listTextBox[3].Focus();
                }
                else startTransaction();
            }
            
        }
        private void startTransaction()
        {
            BeginTransactionAsync();
            try
            {
                var imageArray = uploadImage.ImageToByte(image.Image);

                //using (var db = new Conection())
                //{
                //    db.Insert(new Studient()
                //    {
                //        nid = listTextBox[0].Text,
                //        name = listTextBox[1].Text,
                //        surname = listTextBox[2].Text,
                //        email = listTextBox[3].Text,

                //    });
                //}
                _Studient.Value(e => e.nid, listTextBox[0].Text)
                    .Value(e => e.name, listTextBox[1].Text)
                    .Value(e => e.surname, listTextBox[2].Text)
                    .Value(e => e.email, listTextBox[3].Text)
                    .Value(e => e.image, imageArray)
                    .Insert();


                CommitTransaction();
            }
            catch (Exception e)
            {
                Console.WriteLine("Transaction not complete\n"+e.Message);
            }
        }

    }
}
