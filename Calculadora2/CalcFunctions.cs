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

        private static long displayNumber = 0;
        private static long displayNumberComma = 0;

        public static void addDisplayNumber(Label display, int number)
        {
            String displayText = Convert.ToString(displayNumber);
            String newNumber = Convert.ToString(number);
            String currentNumber = displayText + newNumber;

            if (display.Text.Contains(','))
            {
                currentNumber = Convert.ToString(displayNumberComma) + newNumber;
            }
            
            if (display.Text.Length > 13)
            {
                return;
            }

            if (display.Text.Contains(','))
            {
                displayNumberComma = long.Parse(currentNumber);
                display.Text = Convert.ToString(displayNumber + "," + displayNumberComma);
                return;
            }
            displayNumber = long.Parse(currentNumber);
            display.Text = Convert.ToString(displayNumber);
        }

        public static void removeDisplayNumber(Label display)
        {
            displayNumber = displayNumberComma = 0;
            display.Text = "0";
        }
        public static void removeLastDisplayNumber(Label display)
        {
            String displayText = Convert.ToString(displayNumber);
            if (display.Text.Contains(","))
            {
                displayText += "," + Convert.ToString(displayNumberComma);
            }

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

            String[] numbers = displayText.Split(',');
            if (numbers.Length == 1 && !display.Text.Contains(","))
            {
                displayNumber = long.Parse(numbers[0].Substring(0, numbers[0].Length - 1));
                display.Text = Convert.ToString(displayNumber);
                return;
            }
            else if (numbers.Length == 2 
                && !display.Text.Substring(display.Text.Length - 1, 1).Equals(","))
            {
                if(numbers[1].Length != 1)
                {
                    displayNumberComma = long.Parse(numbers[1].Substring(0, numbers[1].Length - 1));
                    display.Text = Convert.ToString(displayNumber + "," + displayNumberComma);
                    return;
                }
                displayNumberComma = 0;
                display.Text = Convert.ToString(displayNumber + ",");
                return;
            }
            display.Text = Convert.ToString(displayNumber);
        }
        public static void toggleDisplayNumberSymbol(Label display)
        {
            displayNumber = (-displayNumber);
            display.Text = Convert.ToString(displayNumber);
        }
        public static void appendDisplayComma(Label display)
        {
            if (display.Text.Length > 13)
            {
                return;
            }
            if (display.Text.Contains(','))
            {
                return;
            }
            display.Text += ",";
        }
    }
}
