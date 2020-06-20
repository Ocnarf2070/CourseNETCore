using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller.Library
{
    public class UploadImage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        public void LoadImage(PictureBox pictureBox)
        {
            //Stablishing the property of WaitOnLoad to true it means the image is going to load in a syncronised way.
            pictureBox.WaitOnLoad = true;
            fd.Filter = "Images|*.jpg;*.gip;*.gif;*.bmp";
            fd.ShowDialog();
            if(fd.FileName != String.Empty) //If it is true, it has the correct extension
            {
                pictureBox.ImageLocation = fd.FileName;
            }
        }
    }
}
