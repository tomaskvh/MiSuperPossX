using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace WinFormsApp1.Lib.forms
{
    public class numberPicket
    {
        public void tableNumberSetter(bool Adding, int number, TextBox txtTableNo)
        {
            string txt = txtTableNo.Text;

            if (Adding)
            {
                txt = txt + number.ToString();
            }
            else
            {
                if (number == 0)
                {
                    if (txt.Length == 0) return;
                    txt = txtTableNo.Text.Substring(0, txtTableNo.Text.Length - 1);
                }
                else
                {
                    txt = "";
                }
            }

            txtTableNo.Text = txt;
        }
    }
}
