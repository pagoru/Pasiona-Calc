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
        private CalcFunctions calcFunctions;

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
            savedDisplay.Text = "";

            calcFunctions = new CalcFunctions(display, savedDisplay);
        }

        private void calc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                calcFunctions.addDisplayNumber((e.KeyValue - ((int)Keys.D0)));
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                calcFunctions.addDisplayNumber((e.KeyValue - ((int)Keys.NumPad0)));
            }
            else if (e.KeyCode == Keys.Delete)
            {
                calcFunctions.removeDisplayNumber();
            }
            else if (e.KeyCode == Keys.Back)
            {
                calcFunctions.removeLastDisplayNumber();
            }
            else if (e.KeyCode == Keys.Add)
            {
                calcFunctions.addNumber('+');
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                calcFunctions.addNumber('-');
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                calcFunctions.addNumber('*');
            }
            else if (e.KeyCode == Keys.Divide)
            {
                calcFunctions.addNumber('/');
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.Oemcomma)
            {
                calcFunctions.appendDisplayComma();
            }
            else if (e.KeyCode == Keys.Return)
            {
                calcFunctions.calculateResult();
            }
        }

        private void button_0_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(0);
        }

        private void button_1_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(1);
        }

        private void button_2_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(2);
        }

        private void button_3_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(3);
        }

        private void button_4_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(4);
        }

        private void button_5_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(5);
        }

        private void button_6_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(6);
        }

        private void button_7_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(7);
        }

        private void button_8_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(8);
        }

        private void button_9_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addDisplayNumber(9);
        }

        private void button_CE_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.removeDisplayNumber();
        }

        private void button_Return_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.removeLastDisplayNumber();
        }

        private void button_C_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.removeDisplays();
        }

        private void button_PlusMinus_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.toggleDisplayNumberSymbol();
        }

        private void button_Comma_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.appendDisplayComma();
        }

        private void button_Plus_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addNumber('+');
        }

        private void button_Minus_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addNumber('-');
        }

        private void button_Multiplication_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addNumber('*');
        }

        private void button_Division_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.addNumber('/');
        }

        private void button_Equals_MouseUp(object sender, MouseEventArgs e)
        {
            calcFunctions.calculateResult();
        }
    }
}
