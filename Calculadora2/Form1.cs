using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();

            CalcFunctions.basicbutton(button_0);
            CalcFunctions.basicbutton(button_1);
            CalcFunctions.basicbutton(button_2);
            CalcFunctions.basicbutton(button_3);
            CalcFunctions.basicbutton(button_4);
            CalcFunctions.basicbutton(button_5);
            CalcFunctions.basicbutton(button_6);
            CalcFunctions.basicbutton(button_7);
            CalcFunctions.basicbutton(button_8);
            CalcFunctions.basicbutton(button_9);
            CalcFunctions.basicbutton(button_CE);
            CalcFunctions.basicbutton(button_C);
            CalcFunctions.basicbutton(button_Return);
            CalcFunctions.basicbutton(button_Division);
            CalcFunctions.basicbutton(button_Multiplication);
            CalcFunctions.basicbutton(button_Plus);
            CalcFunctions.basicbutton(button_Minus);
            CalcFunctions.basicbutton(button_Equals);
            CalcFunctions.basicbutton(button_Comma);
            CalcFunctions.basicbutton(button_PlusMinus);

            display.Text = "0";
        }

        private void calc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                CalcFunctions.addDisplayNumber(display, (e.KeyValue - ((int)Keys.D0)));
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                CalcFunctions.addDisplayNumber(display, (e.KeyValue - ((int)Keys.NumPad0)));
            }
            else if (e.KeyCode == Keys.Delete)
            {
                CalcFunctions.removeDisplayNumber(display);
            }
            else if (e.KeyCode == Keys.Back)
            {
                CalcFunctions.removeLastDisplayNumber(display);
            }
            else if (e.KeyCode == Keys.Add)
            {
                
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                
            }
            else if (e.KeyCode == Keys.Divide)
            {
                
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Oemcomma)
            {
                
            }
            else if (e.KeyCode == Keys.Return)
            {
                
            }
        }

        private void button_0_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 0);
        }

        private void button_1_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 1);
        }

        private void button_2_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 2);
        }

        private void button_3_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 3);
        }

        private void button_4_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 4);
        }

        private void button_5_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 5);
        }

        private void button_6_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 6);
        }

        private void button_7_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 7);
        }

        private void button_8_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 8);
        }

        private void button_9_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.addDisplayNumber(display, 9);
        }

        private void button_CE_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.removeDisplayNumber(display);
        }

        private void button_Return_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.removeLastDisplayNumber(display);
        }

        private void button_PlusMinus_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.toggleDisplayNumberSymbol(display);
        }

        private void button_Comma_MouseUp(object sender, MouseEventArgs e)
        {
            CalcFunctions.appendDisplayComma(display);
        }
    }
}
