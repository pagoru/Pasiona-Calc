using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class calc : Form
    {
        private Calculator calculator;

        public calc()
        {
            InitializeComponent();

            designBasicButtons();

            calculator = new Calculator();
            printDisplays(calculator.getDisplays());
        }

        private void designBasicButtons()
        {
            SimpleButton.labelToBasicButton(button_0);
            SimpleButton.labelToBasicButton(button_1);
            SimpleButton.labelToBasicButton(button_2);
            SimpleButton.labelToBasicButton(button_3);
            SimpleButton.labelToBasicButton(button_4);
            SimpleButton.labelToBasicButton(button_5);
            SimpleButton.labelToBasicButton(button_6);
            SimpleButton.labelToBasicButton(button_7);
            SimpleButton.labelToBasicButton(button_8);
            SimpleButton.labelToBasicButton(button_9);
            SimpleButton.labelToBasicButton(button_CE);
            SimpleButton.labelToBasicButton(button_C);
            SimpleButton.labelToBasicButton(button_Return);
            SimpleButton.labelToBasicButton(button_Divide);
            SimpleButton.labelToBasicButton(button_Multiply);
            SimpleButton.labelToBasicButton(button_Add);
            SimpleButton.labelToBasicButton(button_Substract);
            SimpleButton.labelToBasicButton(button_Equals);
            SimpleButton.labelToBasicButton(button_Comma);
            SimpleButton.labelToBasicButton(button_PlusMinus);
        }

        private void calc_KeyUp(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            int keyValue = e.KeyValue;

            if (keyCode >= Keys.D0 && keyCode <= Keys.D9)
            {
                calculator.addDisplayNumber((keyValue - ((int)Keys.D0)));
            }
            else if (keyCode >= Keys.NumPad0 && keyCode <= Keys.NumPad9)
            {
                calculator.addDisplayNumber((keyValue - ((int)Keys.NumPad0)));
            }
            else if (keyCode == Keys.Delete)
            {
                calculator.removeDisplays();
            }
            else if (keyCode == Keys.Back)
            {
                calculator.removeLastDisplayNumber();
            }
            else if (keyCode == Keys.Add)
            {
                calculator.addOperator((char)Calculator.Symbols.ADD);
            }
            else if (keyCode == Keys.Subtract)
            {
                calculator.addOperator((char)Calculator.Symbols.SUBSTRACT);
            }
            else if (keyCode == Keys.Multiply)
            {
                calculator.addOperator((char)Calculator.Symbols.MULTIPLY);
            }
            else if (keyCode == Keys.Divide)
            {
                calculator.addOperator((char)Calculator.Symbols.DIVIDE);
            }
            else if (keyCode == Keys.Decimal || keyCode == Keys.Oemcomma)
            {
                calculator.appendDisplayComma();
            }
            else if (keyCode == Keys.Return)
            {
                calculator.calculateResult();
            }
            printDisplays(calculator.getDisplays());
        }

        private void button_MouseClick(object sender, EventArgs e)
        {
            String strLabelValue = ((Label)sender).Text;
            Char firstCharLabelValue = strLabelValue.ToCharArray()[0];
            int labelNumValue = 0;

            if (int.TryParse(strLabelValue, out labelNumValue))
            {
                if (labelNumValue >= 0 && labelNumValue <= 9)
                {
                    calculator.addDisplayNumber(labelNumValue);
                }
                printDisplays(calculator.getDisplays());
                return;
            }
            if (strLabelValue.Equals("CE"))
            {
                calculator.removeDisplayNumber();
                printDisplays(calculator.getDisplays());
                return;
            }
            switch (firstCharLabelValue)
            {
                case (char)Calculator.Symbols.REMOVE_LAST:
                    calculator.removeLastDisplayNumber();
                    break;
                case (char)Calculator.Symbols.REMOVE_DISPLAY:
                    calculator.removeDisplays();
                    break;
                case (char)Calculator.Symbols.PLUS_MINUS:
                    calculator.toggleDisplayNumberSymbol();
                    break;
                case (char)Calculator.Symbols.COMMA:
                    calculator.appendDisplayComma();
                    break;
                case (char)Calculator.Symbols.ADD:
                case (char)Calculator.Symbols.SUBSTRACT:
                case (char)Calculator.Symbols.MULTIPLY:
                case (char)Calculator.Symbols.DIVIDE:
                    calculator.addOperator(firstCharLabelValue);
                    break;
                case (char)Calculator.Symbols.EQUAL:
                    calculator.calculateResult();
                    break;
            }
            printDisplays(calculator.getDisplays());
        }
        
        public void printDisplays(String[] displays)
        {
            display.Text = displays[0];
            savedDisplay.Text = displays[1];
        }
    }
}
