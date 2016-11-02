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

            designBasicButtons();

            display.Text = "0";
            savedDisplay.Text = "";

            calcFunctions = new CalcFunctions(display, savedDisplay);
        }

        private void designBasicButtons()
        {
            SimpleButton.designLabelToBasicButton(button_0);
            SimpleButton.designLabelToBasicButton(button_1);
            SimpleButton.designLabelToBasicButton(button_2);
            SimpleButton.designLabelToBasicButton(button_3);
            SimpleButton.designLabelToBasicButton(button_4);
            SimpleButton.designLabelToBasicButton(button_5);
            SimpleButton.designLabelToBasicButton(button_6);
            SimpleButton.designLabelToBasicButton(button_7);
            SimpleButton.designLabelToBasicButton(button_8);
            SimpleButton.designLabelToBasicButton(button_9);
            SimpleButton.designLabelToBasicButton(button_CE);
            SimpleButton.designLabelToBasicButton(button_C);
            SimpleButton.designLabelToBasicButton(button_Return);
            SimpleButton.designLabelToBasicButton(button_Division);
            SimpleButton.designLabelToBasicButton(button_Multiplication);
            SimpleButton.designLabelToBasicButton(button_Plus);
            SimpleButton.designLabelToBasicButton(button_Minus);
            SimpleButton.designLabelToBasicButton(button_Equals);
            SimpleButton.designLabelToBasicButton(button_Comma);
            SimpleButton.designLabelToBasicButton(button_PlusMinus);
        }

        private void calc_KeyUp(object sender, KeyEventArgs e)
        {
            Keys keyCode = e.KeyCode;
            int keyValue = e.KeyValue;

            if (keyCode >= Keys.D0 && keyCode <= Keys.D9)
            {
                calcFunctions.addDisplayNumber((keyValue - ((int)Keys.D0)));
            }
            else if (keyCode >= Keys.NumPad0 && keyCode <= Keys.NumPad9)
            {
                calcFunctions.addDisplayNumber((keyValue - ((int)Keys.NumPad0)));
            }
            else if (keyCode == Keys.Delete)
            {
                calcFunctions.removeDisplays();
            }
            else if (keyCode == Keys.Back)
            {
                calcFunctions.removeLastDisplayNumber();
            }
            else if (keyCode == Keys.Add)
            {
                calcFunctions.addOperator('+');
            }
            else if (keyCode == Keys.Subtract)
            {
                calcFunctions.addOperator('-');
            }
            else if (keyCode == Keys.Multiply)
            {
                calcFunctions.addOperator('*');
            }
            else if (keyCode == Keys.Divide)
            {
                calcFunctions.addOperator('/');//TODO Cambiar operadores a simbolos.
            }
            else if (keyCode == Keys.Decimal || keyCode == Keys.Oemcomma)
            {
                calcFunctions.appendDisplayComma();
            }
            else if (keyCode == Keys.Return)
            {
                calcFunctions.calculateResult();
            }
        }

        private void button_MouseClick(object sender, EventArgs e)
        {
            String labelValue = ((Label)sender).Text;
            int labelNumValue = 0;

            if (int.TryParse(labelValue, out labelNumValue))
            {
                if (labelNumValue >= 0 && labelNumValue <= 9)
                {
                    calcFunctions.addDisplayNumber(labelNumValue);
                }
                return;
            }
            switch (labelValue)
            {
                case "CE":
                    calcFunctions.removeDisplayNumber();
                    break;
                case "⌫":
                    calcFunctions.removeLastDisplayNumber();
                    break;
                case "C":
                    calcFunctions.removeDisplays();
                    break;
                case "±":
                    calcFunctions.toggleDisplayNumberSymbol();
                    break;
                case ",":
                    calcFunctions.appendDisplayComma();
                    break;
                case "＋":
                case "–":
                case "✕":
                case "÷":
                    calcFunctions.addOperator(labelValue.ToCharArray()[0]);
                    break;
                case "=":
                    calcFunctions.calculateResult();
                    break;

            }
        }
    }
}
