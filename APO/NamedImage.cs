using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APO_Czerniawski
{
    public class NamedImage
    {
        private Image image;
        private string name;

        public NamedImage(Image image, string name)
        {
            this.image = image;
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }

        public Image getImage()
        {
            return image;
        }
    }
}
