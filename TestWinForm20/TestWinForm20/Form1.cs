using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestWinForm20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_janr_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Txt_avtor=txt_avtor.Text;
            book.Txt_zaglavie=txt_zaglavie.Text;
            book.Combo_izdatelstvo= 

            MessageBox.Show($"Автор {book.Txt_avtor}, Заглавие {txt_zaglavie.Text}, Издателство {combo_izdatelstvo.Text}, ЕГН {txt_egn.Text}, Жанр {}")
        }
    }
}
