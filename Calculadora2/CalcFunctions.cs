using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Calculadora2
{
    class CalcFunctions
    {
        
        public static void basicbutton(Label label)
        {
            label.MouseDown += (sender, e) =>
            {
                buttonDown(label, true);
            };
            label.MouseUp += (sender, e) =>
            {
                buttonDown(label, false);
            };

            label.MouseEnter += (sender, e) =>
            {
                buttonHover(label, true);
            };
            label.MouseLeave += (sender, e) =>
            {
                buttonHover(label, false);
            };
        }

        private static void buttonHover(Label label, bool hover)
        {
            if (hover)
            {
                label.BackColor = SystemColors.ControlLight;
                return;
            }
            label.BackColor = SystemColors.ButtonFace;
        }

        private static void buttonDown(Label label, bool down)
        {
            if (down)
            {
                label.BackColor = SystemColors.ActiveBorder;
                return;
            }
            label.BackColor = SystemColors.ControlLight;
        }

        //Operaciones con display y la numeración de esta

        private static double displayNumber = 0;

        public static void addDisplayNumber(Label display, double number)
        {
            String displayText = Convert.ToString(displayNumber);
            String newNumber = Convert.ToString(number);
            String currentNumber = displayText + newNumber;

            if (display.Text.Contains(','))
            {
                currentNumber = displayText + "," + newNumber;
            }

            if (double.Parse(currentNumber).ToString().Length > 14)
            {
                return;
            }
            displayNumber = double.Parse(currentNumber);
            display.Text = Convert.ToString(displayNumber);
        }

        public static void removeDisplayNumber(Label display)
        {
            displayNumber = 0;
            display.Text = "0";
        }
        public static void removeLastDisplayNumber(Label display)
        {
            String displayText = Convert.ToString(displayNumber);
            
            if(displayText.Length == 1)
            {
                if (displayText.Equals("0"))
                {
                    return;
                }
                displayNumber = 0;
                display.Text = "0";
                return;
            }
            displayNumber = double.Parse(displayText.Substring(0, displayText.Length - 1));
            display.Text = Convert.ToString(displayNumber);
        }
        public static void toggleDisplayNumberSymbol(Label display)
        {
            displayNumber = (-displayNumber);
            display.Text = Convert.ToString(displayNumber);
        }
        public static void appendDisplayComma(Label display)
        {
            if (display.Text.Contains(','))
            {
                return;
            }
            display.Text += ",0";
        }
    }
}
