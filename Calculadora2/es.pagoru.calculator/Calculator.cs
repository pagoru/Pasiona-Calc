using System;
using System.Linq;

namespace Calculadora
{
    class Calculator
    {
        public enum Symbols : int
        {
            REMOVE_DISPLAY = 'C',
            REMOVE_LAST = '⌫',
            PLUS_MINUS = '±',
            COMMA = ',',
            EQUAL = '＝',
            ADD = '＋',
            SUBSTRACT = '–',
            DIVIDE = '÷',
            MULTIPLY = '✕'
        }

        public const int DISPLAY_MAX_LENGTH = 13;
        public const int SAVED_DISPLAY_MAX_LENGTH = 34;
        
        private String displayText;
        private String savedDisplayText;

        private bool comma;

        public Calculator()
        {
            this.displayText = "0";
            this.savedDisplayText = "";

            comma = false;
        }
        
        public String[] getDisplays()
        {
            return new String[2] { displayText, savedDisplayText };
        }
        
        public void addDisplayNumber(int number)
        {
            String newNumber = Convert.ToString(number);
            
            if (displayText.Length > DISPLAY_MAX_LENGTH)
            {
                return;
            }

            if(displayText.StartsWith("0") && !comma)
            {
                displayText = Convert.ToString(number);
                return;
            }

            displayText += ((!displayText.Contains((Char)Symbols.COMMA) && comma) ? ((Char)Symbols.COMMA).ToString() : "") + number;
        }

        public void removeDisplays()
        {
            removeDisplayNumber();
            savedDisplayText = "";
        }

        public void removeDisplayNumber()
        {
            comma = false;
            displayText = "0";
        }
        public void removeLastDisplayNumber()
        {
            if(displayText.Length > 1)
            {
                if (displayText.Substring(displayText.Length - 1, 1).ToCharArray()[0].Equals((Char)Symbols.COMMA))
                {
                    comma = false;
                }
            }

            if(displayText.Length == 1)
            {
                displayText = "0";
                return;
            }

            displayText = displayText.Substring(0, displayText.Length - 1);
        }
        public void toggleDisplayNumberSymbol()
        {
            displayText = displayText.StartsWith("-") ? displayText.Substring(1, displayText.Length - 1) : "-" + displayText;
        }
        public void appendDisplayComma()
        {
            if (comma)
            {
                return;
            }
            if (displayText.Length > DISPLAY_MAX_LENGTH)
            {
                return;
            }
            displayText += Symbols.COMMA;
            comma = true;
        }
        
        private bool saveDisplayNumber(Char symbol)
        {
            if(savedDisplayText.Length + displayText.Length + 3 > SAVED_DISPLAY_MAX_LENGTH)
            {
                return false;
            }
            
            double displayNumber = double.Parse(displayText);
            if (savedDisplayText.Length == 0)
            {
                savedDisplayText += displayNumber + " " + symbol + " ";
                removeDisplayNumber();
                return false;
            }
            Char lastCharSavedDisplayText = savedDisplayText.Substring(savedDisplayText.Length - 2, 1).ToCharArray()[0];
            
            if (!lastCharSavedDisplayText.Equals((Char)Symbols.ADD)
                && !lastCharSavedDisplayText.Equals((Char)Symbols.SUBSTRACT)
                && !lastCharSavedDisplayText.Equals((Char)Symbols.MULTIPLY)
                && !lastCharSavedDisplayText.Equals((Char)Symbols.DIVIDE))
            {
                return false;
            }
            savedDisplayText.Replace(lastCharSavedDisplayText, symbol);
            savedDisplayText += displayNumber;
            removeDisplayNumber();
            if (lastCharSavedDisplayText != ' ')
            {
                return true;
            }
            return false;
        }

        private bool isSavedDisplayAvailable()
        {
            if (savedDisplayText.Length == 0)
            {
                savedDisplayText = "";
                return false;
            }
            return true;
        }

        public void addOperator(char symbol)
        {
            detectSavedDisplayError();
            if (!saveDisplayNumber(symbol))
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
            if (savedDisplayText.Equals("Error"))
            {
                savedDisplayText = "";
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
            char trueSymbol = char.Parse(savedDisplayText.Split(' ')[1]);
            String[] numbers = savedDisplayText.Split(trueSymbol);
            if (symbol.Equals('\0'))
            {
                numbers[1] = displayText;
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
                case (Char)Symbols.ADD:
                    result = dNumbers[0] + dNumbers[1];
                    break;
                case (Char)Symbols.SUBSTRACT:
                    result = dNumbers[0] - dNumbers[1];
                    break;
                case (Char)Symbols.MULTIPLY:
                    result = dNumbers[0] * dNumbers[1];
                    break;
                case (Char)Symbols.DIVIDE:
                    error = (dNumbers[1] == 0);
                    result = dNumbers[0] / dNumbers[1];
                    break;
            }
            savedDisplayText = error ? "Error" : Convert.ToString(result + " " + (symbol.Equals('\0') ? trueSymbol : symbol) + " ");
        }
    }
}