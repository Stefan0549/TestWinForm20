using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TestWinForm20
{
    internal class Book
    {
        private string txt_avtor;
        private string txt_zaglavie;
        private string combo_izdatelstvo;
        private string group_janr;
        private string groupBox1;

        public string Txt_avtor
        {
            get { return txt_avtor; }
            set { txt_avtor = value; } 
        }
        public string Txt_zaglavie
        {
            get { return txt_zaglavie; }
            set { txt_zaglavie = value; }
        }
        public string Combo_izdatelstvo
        {
            get { return combo_izdatelstvo; }
            set { combo_izdatelstvo = value; }
        }
        public string Group_janr
        {
            get { return group_janr; }
            set { group_janr = value; }
        }
        public string GroupBox1
        {
            get { return groupBox1; }
            set { groupBox1 = value; }
        }
    }
}
