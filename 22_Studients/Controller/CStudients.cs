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
    public enum Method
    {
        Insert,
        Modify
    }
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
            for (int i = 0; i < listTextBox.Count; i++)
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
                if (_Studient.Where(e => e.nid.Equals(listTextBox[0].Text)).Count() != 0)
                {
                    listLabel[0].Text = "NID is already registered";
                    listLabel[0].ForeColor = Color.Red;
                    listTextBox[0].Focus();
                }
                else if (!textBoxEvent.checkEmailFormat(listTextBox[3].Text))
                {
                    listLabel[3].Text = "Email not valid";
                    listLabel[3].ForeColor = Color.Red;
                    listTextBox[3].Focus();
                }
                else if (_idStudient > 0)
                {
                    var user = from p in _Studient where p.id == _idStudient select p;
                    var email = from e in user select e.email;
                    
                    if (!email.First().Equals(listTextBox[3].Text)&&_Studient.Where(e => e.email.Equals(listTextBox[3].Text)).Count() != 0)
                    {
                        listLabel[3].Text = "Email is already registered";
                        listLabel[3].ForeColor = Color.Red;
                        listTextBox[3].Focus();
                    }

                    startTransaction(Method.Modify);
                }
                else
                {

                    if (_Studient.Where(e => e.email.Equals(listTextBox[3].Text)).Count() != 0)
                    {
                        listLabel[3].Text = "Email is already registered";
                        listLabel[3].ForeColor = Color.Red;
                        listTextBox[3].Focus();
                    }
                    else startTransaction(Method.Insert);
                }
            }


        }
        private void startTransaction(Method method)
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
                if (method.Equals(Method.Insert))
                    _Studient.Value(s => s.nid, listTextBox[0].Text)
                        .Value(s => s.name, listTextBox[1].Text)
                        .Value(s => s.surname, listTextBox[2].Text)
                        .Value(s => s.email, listTextBox[3].Text)
                        .Value(s => s.image, imageArray)
                        .Insert();
                else if (method.Equals(Method.Modify))
                    _Studient.Where(s => s.id.Equals(_idStudient))
                        .Set(s => s.nid, listTextBox[0].Text)
                        .Set(s => s.name, listTextBox[1].Text)
                        .Set(s => s.surname, listTextBox[2].Text)
                        .Set(s => s.email, listTextBox[3].Text)
                        .Set(s => s.image, imageArray)
                        .Update();


                CommitTransaction();
                Reestablish();
            }
            catch (Exception e)
            {
                Console.WriteLine("Transaction not complete\n" + e.Message);
            }
        }

        public void DeleteStudient()
        {
            if (_idStudient == 0) MessageBox.Show("Select a studient.");
            else
            {
                var option = MessageBox.Show("Are you sure to eliminate this studient?", "Delete studient", MessageBoxButtons.YesNo);
                if (option.Equals(DialogResult.Yes))
                {
                    try
                    {
                        BeginTransactionAsync();
                        _Studient.Where(s => s.id.Equals(_idStudient)).Delete();
                        Reestablish();
                        CommitTransaction();
                    }
                    catch(LinqToDBException e)
                    {
                        Console.WriteLine("Transaction not complete\n" + e.Message);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Transaction not complete\n" + e.Message);

                    }

                }
            }
        }

        public void Reestablish()
        {
            _idStudient = 0;
            image.Image = _originalImage;
            listLabel[0].Text = "NID";
            listLabel[0].ForeColor = Color.LightSlateGray;
            listLabel[1].Text = "Name";
            listLabel[1].ForeColor = Color.LightSlateGray;
            listLabel[2].Text = "Surname";
            listLabel[2].ForeColor = Color.LightSlateGray;
            listLabel[3].Text = "Email";
            listLabel[3].ForeColor = Color.LightSlateGray;
            foreach (var textbox in listTextBox) textbox.Text = "";
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
                        s.image
                    }).Skip(initial).Take(_reg_per_page).ToList();
                _dataGridView.Columns[0].Visible = false;
                _dataGridView.Columns[5].Visible = false;

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
                        s.image
                    }).ToList();
            }
        }

        private int _idStudient = 0;
        public void GetStudient()
        {
            _idStudient = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            listTextBox[0].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[1].Value);
            listTextBox[1].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[2].Value);
            listTextBox[2].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[3].Value);
            listTextBox[3].Text = Convert.ToString(_dataGridView.CurrentRow.Cells[4].Value);
            try
            {
                byte[] arrayImage = (byte[])_dataGridView.CurrentRow.Cells[5].Value;
                image.Image = uploadImage.ByteArrayToImage(arrayImage);
            }
            catch (Exception)
            {
                image.Image = _originalImage;
            }


        }


    }
}
