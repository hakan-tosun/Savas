using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavasLibrary.Abstract
{
    internal abstract class Cisim : PictureBox
    {
        protected Cisim()
        {
            SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}
