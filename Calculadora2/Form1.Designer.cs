namespace Calculadora2
{
    partial class calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.savedDisplay = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.Label();
            this.button_CE = new System.Windows.Forms.Label();
            this.button_C = new System.Windows.Forms.Label();
            this.button_Return = new System.Windows.Forms.Label();
            this.button_Division = new System.Windows.Forms.Label();
            this.button_Multiplication = new System.Windows.Forms.Label();
            this.button_9 = new System.Windows.Forms.Label();
            this.button_8 = new System.Windows.Forms.Label();
            this.button_7 = new System.Windows.Forms.Label();
            this.button_Plus = new System.Windows.Forms.Label();
            this.button_3 = new System.Windows.Forms.Label();
            this.button_2 = new System.Windows.Forms.Label();
            this.button_1 = new System.Windows.Forms.Label();
            this.button_Minus = new System.Windows.Forms.Label();
            this.button_6 = new System.Windows.Forms.Label();
            this.button_5 = new System.Windows.Forms.Label();
            this.button_4 = new System.Windows.Forms.Label();
            this.button_Equals = new System.Windows.Forms.Label();
            this.button_Comma = new System.Windows.Forms.Label();
            this.button_0 = new System.Windows.Forms.Label();
            this.button_PlusMinus = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // savedDisplay
            // 
            this.savedDisplay.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedDisplay.Location = new System.Drawing.Point(0, 0);
            this.savedDisplay.Name = "savedDisplay";
            this.savedDisplay.Size = new System.Drawing.Size(256, 32);
            this.savedDisplay.TabIndex = 0;
            this.savedDisplay.Text = "savedDisplay";
            this.savedDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // display
            // 
            this.display.Font = new System.Drawing.Font("Lucida Console", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(-2, 32);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(256, 64);
            this.display.TabIndex = 1;
            this.display.Text = "display";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_CE
            // 
            this.button_CE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_CE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CE.Location = new System.Drawing.Point(0, 105);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(64, 64);
            this.button_CE.TabIndex = 2;
            this.button_CE.Text = "CE";
            this.button_CE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_CE.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_C
            // 
            this.button_C.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_C.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.Location = new System.Drawing.Point(64, 105);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(64, 64);
            this.button_C.TabIndex = 3;
            this.button_C.Text = "C";
            this.button_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_C.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Return.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Return.Location = new System.Drawing.Point(128, 105);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(64, 64);
            this.button_Return.TabIndex = 4;
            this.button_Return.Text = "⌫";
            this.button_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Return.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_Division
            // 
            this.button_Division.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Division.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Division.Location = new System.Drawing.Point(192, 105);
            this.button_Division.Name = "button_Division";
            this.button_Division.Size = new System.Drawing.Size(64, 64);
            this.button_Division.TabIndex = 5;
            this.button_Division.Text = "÷";
            this.button_Division.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Division.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_Multiplication
            // 
            this.button_Multiplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Multiplication.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Multiplication.Location = new System.Drawing.Point(192, 169);
            this.button_Multiplication.Name = "button_Multiplication";
            this.button_Multiplication.Size = new System.Drawing.Size(64, 64);
            this.button_Multiplication.TabIndex = 9;
            this.button_Multiplication.Text = "✕";
            this.button_Multiplication.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Multiplication.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_9
            // 
            this.button_9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_9.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(128, 169);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(64, 64);
            this.button_9.TabIndex = 8;
            this.button_9.Text = "9";
            this.button_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_9.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_8
            // 
            this.button_8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_8.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(64, 169);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(64, 64);
            this.button_8.TabIndex = 7;
            this.button_8.Text = "8";
            this.button_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_8.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_7
            // 
            this.button_7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_7.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(0, 169);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(64, 64);
            this.button_7.TabIndex = 6;
            this.button_7.Text = "7";
            this.button_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_7.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_Plus
            // 
            this.button_Plus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Plus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Plus.Location = new System.Drawing.Point(192, 297);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(64, 64);
            this.button_Plus.TabIndex = 17;
            this.button_Plus.Text = "＋";
            this.button_Plus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Plus.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_3
            // 
            this.button_3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_3.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(128, 297);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(64, 64);
            this.button_3.TabIndex = 16;
            this.button_3.Text = "3";
            this.button_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_3.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_2
            // 
            this.button_2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_2.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(64, 297);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(64, 64);
            this.button_2.TabIndex = 15;
            this.button_2.Text = "2";
            this.button_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_2.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_1
            // 
            this.button_1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_1.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(0, 297);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(64, 64);
            this.button_1.TabIndex = 14;
            this.button_1.Text = "1";
            this.button_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_1.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_Minus
            // 
            this.button_Minus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Minus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Minus.Location = new System.Drawing.Point(192, 233);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(64, 64);
            this.button_Minus.TabIndex = 13;
            this.button_Minus.Text = "–";
            this.button_Minus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Minus.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_6
            // 
            this.button_6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_6.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(128, 233);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(64, 64);
            this.button_6.TabIndex = 12;
            this.button_6.Text = "6";
            this.button_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_6.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_5
            // 
            this.button_5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_5.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(64, 233);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(64, 64);
            this.button_5.TabIndex = 11;
            this.button_5.Text = "5";
            this.button_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_5.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_4
            // 
            this.button_4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_4.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(0, 233);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(64, 64);
            this.button_4.TabIndex = 10;
            this.button_4.Text = "4";
            this.button_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_4.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_Equals
            // 
            this.button_Equals.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Equals.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Equals.Location = new System.Drawing.Point(192, 361);
            this.button_Equals.Name = "button_Equals";
            this.button_Equals.Size = new System.Drawing.Size(64, 64);
            this.button_Equals.TabIndex = 21;
            this.button_Equals.Text = "＝";
            this.button_Equals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Equals.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_Comma
            // 
            this.button_Comma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Comma.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Comma.Location = new System.Drawing.Point(128, 361);
            this.button_Comma.Name = "button_Comma";
            this.button_Comma.Size = new System.Drawing.Size(64, 64);
            this.button_Comma.TabIndex = 20;
            this.button_Comma.Text = ",";
            this.button_Comma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Comma.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_0
            // 
            this.button_0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_0.Font = new System.Drawing.Font("Lucida Console", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(64, 361);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(64, 64);
            this.button_0.TabIndex = 19;
            this.button_0.Text = "0";
            this.button_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_0.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // button_PlusMinus
            // 
            this.button_PlusMinus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_PlusMinus.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PlusMinus.Location = new System.Drawing.Point(0, 361);
            this.button_PlusMinus.Name = "button_PlusMinus";
            this.button_PlusMinus.Size = new System.Drawing.Size(64, 64);
            this.button_PlusMinus.TabIndex = 18;
            this.button_PlusMinus.Text = "±";
            this.button_PlusMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_PlusMinus.Click += new System.EventHandler(this.button_MouseClick);
            // 
            // calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(256, 425);
            this.Controls.Add(this.button_Equals);
            this.Controls.Add(this.button_Comma);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_PlusMinus);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_Multiplication);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_Division);
            this.Controls.Add(this.button_Return);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.button_CE);
            this.Controls.Add(this.display);
            this.Controls.Add(this.savedDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calc";
            this.ShowIcon = false;
            this.Text = "Calculadora";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.calc_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label savedDisplay;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Label button_CE;
        private System.Windows.Forms.Label button_C;
        private System.Windows.Forms.Label button_Return;
        private System.Windows.Forms.Label button_Division;
        private System.Windows.Forms.Label button_Multiplication;
        private System.Windows.Forms.Label button_9;
        private System.Windows.Forms.Label button_8;
        private System.Windows.Forms.Label button_7;
        private System.Windows.Forms.Label button_Plus;
        private System.Windows.Forms.Label button_3;
        private System.Windows.Forms.Label button_2;
        private System.Windows.Forms.Label button_1;
        private System.Windows.Forms.Label button_Minus;
        private System.Windows.Forms.Label button_6;
        private System.Windows.Forms.Label button_5;
        private System.Windows.Forms.Label button_4;
        private System.Windows.Forms.Label button_Equals;
        private System.Windows.Forms.Label button_Comma;
        private System.Windows.Forms.Label button_0;
        private System.Windows.Forms.Label button_PlusMinus;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

