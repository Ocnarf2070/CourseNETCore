using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            //Condition which only allows to introduce a text type
            if (char.IsLetter(e.KeyChar)) e.Handled = false;
            //Condition which does not allow to do a newline when Enter is pressed.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) e.Handled = true;
            //Condition which allows to use the backspace button and the space button
            else if (char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)) e.Handled = false;
            else e.Handled = true;
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            //Condition which only allows to introduce a number type
            if (char.IsDigit(e.KeyChar)) e.Handled = false;
            //Condition which does not allow to introduce text type
            else if (char.IsLetter(e.KeyChar)) e.Handled = true;
            //Condition which does not allow to do a newline when Enter is pressed.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) e.Handled = true;
            //Condition which allows to use the backspace button
            else if (char.IsControl(e.KeyChar)) e.Handled = false;
            //Condition which does not allow to use the space button
            else if (char.IsSeparator(e.KeyChar)) e.Handled = true;
            else e.Handled = true;
        }

        public bool checkEmailFormat(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
