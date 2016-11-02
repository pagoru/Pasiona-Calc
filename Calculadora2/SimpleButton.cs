using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Calculadora2
{
    class SimpleButton
    {
        public static void designLabelToBasicButton(Label label)
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
    }
}
