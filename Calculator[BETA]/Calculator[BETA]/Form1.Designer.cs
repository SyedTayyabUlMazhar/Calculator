namespace Calculator_BETA_
{
    partial class Form1
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


        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button add;


        //1- Allocates memory for buttons,texboxes... using new just like     obj = new MyClass();
        //2- Sets properties of those objects(like size and position of button).
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Enabled = false;
            this.display.Location = new System.Drawing.Point(12, 12);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(246, 50);
            this.display.TabIndex = 0;
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.Control;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.Color.Black;
            this.seven.Location = new System.Drawing.Point(12, 68);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(61, 44);
            this.seven.TabIndex = 1;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(79, 68);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(61, 44);
            this.eight.TabIndex = 2;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(146, 68);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(61, 44);
            this.nine.TabIndex = 3;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(12, 118);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(61, 44);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(79, 118);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(61, 44);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(146, 118);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(61, 44);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(12, 168);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(61, 44);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(79, 168);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(61, 44);
            this.two.TabIndex = 8;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(146, 168);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(61, 44);
            this.three.TabIndex = 7;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // point
            // 
            this.point.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.point.Location = new System.Drawing.Point(12, 218);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(61, 44);
            this.point.TabIndex = 10;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.point_Click);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(146, 218);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(61, 44);
            this.equal.TabIndex = 11;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(79, 218);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(61, 44);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(213, 68);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(45, 37);
            this.DEL.TabIndex = 13;
            this.DEL.Text = "DEL";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(213, 159);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(45, 35);
            this.multiply.TabIndex = 14;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(213, 111);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(45, 42);
            this.divide.TabIndex = 15;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(213, 200);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(45, 28);
            this.subtract.TabIndex = 16;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(213, 234);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(45, 28);
            this.add.TabIndex = 17;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(268, 274);
            this.Controls.Add(this.add);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.DEL);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.point);
            this.Controls.Add(this.one);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}

