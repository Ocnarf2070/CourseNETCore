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
        private Bitmap _originalImage;
        private DataGridView _dataGridView;
        private NumericUpDown _numericUpDown;
        private Pager<Studient> _pager;

        public CStudients(List<TextBox> listTextBox, List<Label> listLabel, Object[] objects)
        {
            this.listTextBox = listTextBox;
            this.listLabel = listLabel;
            this.image = (PictureBox)objects[0];
            this._originalImage = (Bitmap)objects[1];
            this._dataGridView = (DataGridView)objects[2];
            this._numericUpDown = (NumericUpDown)objects[3];
            Reestablish();
        }

        public void Pager(Library.Action action)
        {
            _num_page = _pager.action(action);
            SeachStudient("");
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
                    listLabel[1].Text = "NID is already registered";
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
                Reestablish();
            }
            catch (Exception e)
            {
                Console.WriteLine("Transaction not complete\n" + e.Message);
            }
        }
        private void Reestablish()
        {
            image.Image = _originalImage;
            listLabel[0].Text = "NID";
            listLabel[0].ForeColor = Color.LightSlateGray;
            listLabel[1].Text = "Name";
            listLabel[1].ForeColor = Color.LightSlateGray;
            listLabel[2].Text = "Surname";
            listLabel[2].ForeColor = Color.LightSlateGray;
            listLabel[3].Text = "Email";
            listLabel[3].ForeColor = Color.LightSlateGray;
            if (_Studient.Count() > 0) _pager = new Pager<Studient>(_Studient.ToList(), listLabel[4], _reg_per_page);
            SeachStudient("");
        }

        public void PageRegister()
        {
            _num_page = 1;
            _reg_per_page = (int)_numericUpDown.Value;
            if (_Studient.Count() > 0) _pager = new Pager<Studient>(_Studient.ToList(), listLabel[4], _reg_per_page);
            SeachStudient("");
        }

        private int _reg_per_page = 2, _num_page = 1;
        public void SeachStudient(string search)
        {
            int initial = (_num_page - 1) * _reg_per_page;
            List<Studient> query = new List<Studient>();
            if (search.Equals("")) query = _Studient.ToList();
            else
                query = _Studient.Where(s => s.nid.StartsWith(search)
                || s.name.StartsWith(search) || s.surname.StartsWith(search)).ToList();
            if (query.Count > 0)
            {
                _dataGridView.DataSource = query.Select(
                    s => new
                    {
                        s.id,
                        s.nid,
                        s.name,
                        s.surname,
                        s.email,
                    }).Skip(initial).Take(_reg_per_page).ToList();
                _dataGridView.Columns[0].Visible = false;

                _dataGridView.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                _dataGridView.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;

            }
            else
            {
                _dataGridView.DataSource = query.Select(
                    s => new
                    {
                        s.id,
                        s.nid,
                        s.name,
                        s.surname,
                        s.email,
                    }).ToList();
            }
        }


    }
}
