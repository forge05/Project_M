using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_M_CSharp
{
    class Feld : Button
    {
        public Button[] nachbarn; //ist das cool weil Feld

        //Button b = new Button();
        public Feld() : base()
        {
        }

        public void setNachbar (params Button[] ButtonList)
        {
            nachbarn = ButtonList;
        }
    }
}
