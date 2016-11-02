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

        

        private Label display;
        private Label savedDisplay;

        private bool comma;

        public CalcFunctions(Label display, Label savedDisplay)
        {
            this.display = display;
            this.savedDisplay = savedDisplay;

            comma = false;
        }

        //Operaciones con display y la numeración de esta
        
        public void addDisplayNumber(int number)
        {
            String displayText = display.Text;
            String newNumber = Convert.ToString(number);
            
            if (displayText.Length > 13)
            {
                return;
            }

            if(displayText.StartsWith("0") && !comma)
            {
                display.Text = Convert.ToString(number);
                return;
            }
            
            display.Text += ((!displayText.Contains(',') && comma) ? "," : "") + number;
        }

        public void removeDisplays()
        {
            removeDisplayNumber();
            savedDisplay.Text = "";
        }

        public void removeDisplayNumber()
        {
            comma = false;
            display.Text = "0";
        }
        public void removeLastDisplayNumber()
        {
            String displayText = display.Text;
            if(displayText.Length > 1)
            {
                if (displayText.Substring(displayText.Length - 1, 1).Equals(","))
                {
                    comma = false;
                }
            }

            if(displayText.Length == 1)
            {
                display.Text = "0";
                return;
            }

            display.Text = displayText.Substring(0, displayText.Length - 1);
        }
        public void toggleDisplayNumberSymbol()
        {
            String displayText = display.Text;
            display.Text = displayText.StartsWith("-") ? displayText.Substring(1, displayText.Length - 1) : "-" + displayText;
        }
        public void appendDisplayComma()
        {
            if (display.Text.Length > 13)
            {
                return;
            }
            if (comma)
            {
                return;
            }
            display.Text += ",";
            comma = true;
        }

        //Operaciones
        

        private bool saveDisplayNumber(String symbol)
        {
            String savedDisplayText = savedDisplay.Text;
            String displayText = display.Text;

            if(savedDisplayText.Length + displayText.Length + 3 > 34)
            {
                return false;
            }
            
            double displayNumber = double.Parse(displayText);
            if (savedDisplayText.Length == 0)
            {
                savedDisplay.Text += displayNumber + " " + symbol + " ";
                removeDisplayNumber();
                return false;
            }
            String lastCharSavedDisplayText = savedDisplayText.Substring(savedDisplayText.Length - 2, 2);
            
            if (!lastCharSavedDisplayText.Equals("+ ")
                && !lastCharSavedDisplayText.Equals("- ")
                && !lastCharSavedDisplayText.Equals("* ")
                && !lastCharSavedDisplayText.Equals("/ "))
            {
                return false;
            }
            savedDisplay.Text.Replace(lastCharSavedDisplayText.Substring(1, 1), symbol);
            savedDisplay.Text += displayNumber;
            removeDisplayNumber();
            if (lastCharSavedDisplayText.Length != 0)
            {
                return true;
            }
            return false;
        }

        private bool isSavedDisplayAvailable()
        {
            if (savedDisplay.Text.Length == 0)
            {
                savedDisplay.Text = "";
                return false;
            }
            return true;
        }

        public void addOperator(char symbol)
        {
            detectSavedDisplayError();
            if (!saveDisplayNumber(Convert.ToString(symbol)))
            {
                return;
            }
            if (!isSavedDisplayAvailable())
            {
                return;
            }
            calcNumbers(symbol);
        }

        private void detectSavedDisplayError()
        {
            if (savedDisplay.Text.Equals("Error"))
            {
                savedDisplay.Text = "";
            }
        }

        public void calculateResult()
        {
            detectSavedDisplayError();
            if (isSavedDisplayAvailable())
            {
                calcNumbers('\0');
            }
        }

        private void calcNumbers(char symbol)
        {
            char trueSymbol = char.Parse(savedDisplay.Text.Split(' ')[1]);
            String[] numbers = savedDisplay.Text.Split(trueSymbol);
            if (symbol.Equals('\0'))
            {
                numbers[1] = display.Text;
            }
            if (numbers.Length < 2)
            {
                return;
            }
            double[] dNumbers =
            {
                double.Parse(numbers[0]), numbers[1].Equals(" ") 
                ? 0 
                : double.Parse(numbers[1])
            };
            double result = 0;
            bool error = false;

            switch (trueSymbol)
            {
                case '+':
                    result = dNumbers[0] + dNumbers[1];
                    break;
                case '-':
                    result = dNumbers[0] - dNumbers[1];
                    break;
                case '*':
                    result = dNumbers[0] * dNumbers[1];
                    break;
                case '/':
                    error = (dNumbers[1] == 0);
                    result = dNumbers[0] / dNumbers[1];
                    break;
            }
            savedDisplay.Text = error ? "Error" : Convert.ToString(result + " " + (symbol.Equals('\0') ? trueSymbol : symbol) + " ");
            //removeDisplayNumber();
        }
    }
}
