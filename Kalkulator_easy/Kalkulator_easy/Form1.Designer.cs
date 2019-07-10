namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.amount = new System.Windows.Forms.Button();
            this.difference = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Root = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.Button();
            this.degreeTwo = new System.Windows.Forms.Button();
            this.logXAcrossY = new System.Windows.Forms.Button();
            this.remainderOfDivision = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.arifmeticMean = new System.Windows.Forms.Button();
            this.sine = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.arcsine = new System.Windows.Forms.Button();
            this.arctan = new System.Windows.Forms.Button();
            this.oneDivideByX = new System.Windows.Forms.Button();
            this.reversePower = new System.Windows.Forms.Button();
            this.max = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(12, 73);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(75, 23);
            this.amount.TabIndex = 0;
            this.amount.Text = "+";
            this.amount.UseVisualStyleBackColor = true;
            this.amount.Click += new System.EventHandler(this.TwoArguments);
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(93, 73);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(75, 23);
            this.difference.TabIndex = 1;
            this.difference.Text = "-";
            this.difference.UseVisualStyleBackColor = true;
            this.difference.Click += new System.EventHandler(this.TwoArguments);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(174, 73);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(75, 23);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.TwoArguments);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(255, 73);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(75, 23);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.TwoArguments);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(230, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(93, 102);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(75, 23);
            this.Root.TabIndex = 10;
            this.Root.Text = "Root";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.OneArgument);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(174, 102);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(75, 23);
            this.Degree.TabIndex = 11;
            this.Degree.Text = "Degree";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.OneArgument);
            // 
            // degreeTwo
            // 
            this.degreeTwo.Location = new System.Drawing.Point(12, 140);
            this.degreeTwo.Name = "degreeTwo";
            this.degreeTwo.Size = new System.Drawing.Size(75, 23);
            this.degreeTwo.TabIndex = 12;
            this.degreeTwo.Text = "DegreeTwo";
            this.degreeTwo.UseVisualStyleBackColor = true;
            this.degreeTwo.Click += new System.EventHandler(this.TwoArguments);
            // 
            // logXAcrossY
            // 
            this.logXAcrossY.Location = new System.Drawing.Point(93, 140);
            this.logXAcrossY.Name = "logXAcrossY";
            this.logXAcrossY.Size = new System.Drawing.Size(75, 23);
            this.logXAcrossY.TabIndex = 13;
            this.logXAcrossY.Text = "logXAcrossY";
            this.logXAcrossY.UseVisualStyleBackColor = true;
            this.logXAcrossY.Click += new System.EventHandler(this.TwoArguments);
            // 
            // remainderOfDivision
            // 
            this.remainderOfDivision.Location = new System.Drawing.Point(174, 140);
            this.remainderOfDivision.Name = "remainderOfDivision";
            this.remainderOfDivision.Size = new System.Drawing.Size(75, 23);
            this.remainderOfDivision.TabIndex = 14;
            this.remainderOfDivision.Text = "remainder";
            this.remainderOfDivision.UseVisualStyleBackColor = true;
            this.remainderOfDivision.Click += new System.EventHandler(this.TwoArguments);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(255, 140);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 15;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.TwoArguments);
            // 
            // arifmeticMean
            // 
            this.arifmeticMean.Location = new System.Drawing.Point(12, 169);
            this.arifmeticMean.Name = "arifmeticMean";
            this.arifmeticMean.Size = new System.Drawing.Size(75, 23);
            this.arifmeticMean.TabIndex = 16;
            this.arifmeticMean.Text = "ArifmeticMean";
            this.arifmeticMean.UseVisualStyleBackColor = true;
            this.arifmeticMean.Click += new System.EventHandler(this.TwoArguments);
            // 
            // sine
            // 
            this.sine.Location = new System.Drawing.Point(93, 169);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(75, 23);
            this.sine.TabIndex = 17;
            this.sine.Text = "Sine";
            this.sine.UseVisualStyleBackColor = true;
            this.sine.Click += new System.EventHandler(this.OneArgument);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(174, 169);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 18;
            this.tan.Text = "Tangent";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgument);
            // 
            // arcsine
            // 
            this.arcsine.Location = new System.Drawing.Point(255, 169);
            this.arcsine.Name = "arcsine";
            this.arcsine.Size = new System.Drawing.Size(75, 23);
            this.arcsine.TabIndex = 19;
            this.arcsine.Text = "Arcsine";
            this.arcsine.UseVisualStyleBackColor = true;
            this.arcsine.Click += new System.EventHandler(this.OneArgument);
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(12, 198);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(75, 23);
            this.arctan.TabIndex = 20;
            this.arctan.Text = "Arctan";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.OneArgument);
            // 
            // oneDivideByX
            // 
            this.oneDivideByX.Location = new System.Drawing.Point(93, 198);
            this.oneDivideByX.Name = "oneDivideByX";
            this.oneDivideByX.Size = new System.Drawing.Size(75, 23);
            this.oneDivideByX.TabIndex = 21;
            this.oneDivideByX.Text = "OneDivideByX";
            this.oneDivideByX.UseVisualStyleBackColor = true;
            this.oneDivideByX.Click += new System.EventHandler(this.OneArgument);
            // 
            // reversePower
            // 
            this.reversePower.Location = new System.Drawing.Point(12, 238);
            this.reversePower.Name = "reversePower";
            this.reversePower.Size = new System.Drawing.Size(75, 23);
            this.reversePower.TabIndex = 22;
            this.reversePower.Text = "ReversePower";
            this.reversePower.UseVisualStyleBackColor = true;
            this.reversePower.Click += new System.EventHandler(this.TwoArguments);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(93, 238);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 23;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.TwoArguments);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 380);
            this.Controls.Add(this.max);
            this.Controls.Add(this.reversePower);
            this.Controls.Add(this.oneDivideByX);
            this.Controls.Add(this.arctan);
            this.Controls.Add(this.arcsine);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.sine);
            this.Controls.Add(this.arifmeticMean);
            this.Controls.Add(this.min);
            this.Controls.Add(this.remainderOfDivision);
            this.Controls.Add(this.logXAcrossY);
            this.Controls.Add(this.degreeTwo);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.amount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button amount;
        private System.Windows.Forms.Button difference;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button degreeTwo;
        private System.Windows.Forms.Button logXAcrossY;
        private System.Windows.Forms.Button remainderOfDivision;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button arifmeticMean;
        private System.Windows.Forms.Button sine;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button arcsine;
        private System.Windows.Forms.Button arctan;
        private System.Windows.Forms.Button oneDivideByX;
        private System.Windows.Forms.Button reversePower;
        private System.Windows.Forms.Button max;
    }
}

