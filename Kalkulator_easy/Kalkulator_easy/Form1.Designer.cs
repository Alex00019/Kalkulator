﻿namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.meanGeometric = new System.Windows.Forms.Button();
            this.cose = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.arccose = new System.Windows.Forms.Button();
            this.arcctg = new System.Windows.Forms.Button();
            this.catangent = new System.Windows.Forms.Button();
            this.logarithmTen = new System.Windows.Forms.Button();
            this.twoDivide = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(24, 73);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(156, 23);
            this.amount.TabIndex = 0;
            this.amount.Text = "+";
            this.amount.UseVisualStyleBackColor = true;
            this.amount.Click += new System.EventHandler(this.CalculateTest);
            // 
            // difference
            // 
            this.difference.Location = new System.Drawing.Point(186, 73);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(156, 23);
            this.difference.TabIndex = 1;
            this.difference.Text = "-";
            this.difference.UseVisualStyleBackColor = true;
            this.difference.Click += new System.EventHandler(this.CalculateTest);
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(348, 73);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(156, 23);
            this.multiplication.TabIndex = 2;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.CalculateTest);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(510, 73);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(157, 23);
            this.division.TabIndex = 3;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.CalculateTest);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(198, 28);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(429, 311);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(157, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Первый аргумент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Второй аргумент";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Результат";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(198, 102);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(132, 23);
            this.Root.TabIndex = 10;
            this.Root.Text = "Root";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.OneArgument);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(360, 102);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(128, 23);
            this.Degree.TabIndex = 11;
            this.Degree.Text = "Degree";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.OneArgument);
            // 
            // degreeTwo
            // 
            this.degreeTwo.Location = new System.Drawing.Point(12, 169);
            this.degreeTwo.Name = "degreeTwo";
            this.degreeTwo.Size = new System.Drawing.Size(75, 23);
            this.degreeTwo.TabIndex = 12;
            this.degreeTwo.Text = "DegreeTwo";
            this.degreeTwo.UseVisualStyleBackColor = true;
            this.degreeTwo.Click += new System.EventHandler(this.CalculateTest);
            // 
            // logXAcrossY
            // 
            this.logXAcrossY.Location = new System.Drawing.Point(93, 169);
            this.logXAcrossY.Name = "logXAcrossY";
            this.logXAcrossY.Size = new System.Drawing.Size(75, 23);
            this.logXAcrossY.TabIndex = 13;
            this.logXAcrossY.Text = "logXAcrossY";
            this.logXAcrossY.UseVisualStyleBackColor = true;
            this.logXAcrossY.Click += new System.EventHandler(this.CalculateTest);
            // 
            // remainderOfDivision
            // 
            this.remainderOfDivision.Location = new System.Drawing.Point(174, 169);
            this.remainderOfDivision.Name = "remainderOfDivision";
            this.remainderOfDivision.Size = new System.Drawing.Size(75, 23);
            this.remainderOfDivision.TabIndex = 14;
            this.remainderOfDivision.Text = "remainder";
            this.remainderOfDivision.UseVisualStyleBackColor = true;
            this.remainderOfDivision.Click += new System.EventHandler(this.CalculateTest);
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(255, 169);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 23);
            this.min.TabIndex = 15;
            this.min.Text = "Min";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.CalculateTest);
            // 
            // arifmeticMean
            // 
            this.arifmeticMean.Location = new System.Drawing.Point(12, 198);
            this.arifmeticMean.Name = "arifmeticMean";
            this.arifmeticMean.Size = new System.Drawing.Size(75, 23);
            this.arifmeticMean.TabIndex = 16;
            this.arifmeticMean.Text = "ArifmeticMean";
            this.arifmeticMean.UseVisualStyleBackColor = true;
            this.arifmeticMean.Click += new System.EventHandler(this.CalculateTest);
            // 
            // sine
            // 
            this.sine.Location = new System.Drawing.Point(93, 198);
            this.sine.Name = "sine";
            this.sine.Size = new System.Drawing.Size(75, 23);
            this.sine.TabIndex = 17;
            this.sine.Text = "Sine";
            this.sine.UseVisualStyleBackColor = true;
            this.sine.Click += new System.EventHandler(this.OneArgument);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(174, 198);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(75, 23);
            this.tan.TabIndex = 18;
            this.tan.Text = "Tangent";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.OneArgument);
            // 
            // arcsine
            // 
            this.arcsine.Location = new System.Drawing.Point(255, 198);
            this.arcsine.Name = "arcsine";
            this.arcsine.Size = new System.Drawing.Size(75, 23);
            this.arcsine.TabIndex = 19;
            this.arcsine.Text = "Arcsine";
            this.arcsine.UseVisualStyleBackColor = true;
            this.arcsine.Click += new System.EventHandler(this.OneArgument);
            // 
            // arctan
            // 
            this.arctan.Location = new System.Drawing.Point(12, 227);
            this.arctan.Name = "arctan";
            this.arctan.Size = new System.Drawing.Size(75, 23);
            this.arctan.TabIndex = 20;
            this.arctan.Text = "Arctan";
            this.arctan.UseVisualStyleBackColor = true;
            this.arctan.Click += new System.EventHandler(this.OneArgument);
            // 
            // oneDivideByX
            // 
            this.oneDivideByX.Location = new System.Drawing.Point(93, 227);
            this.oneDivideByX.Name = "oneDivideByX";
            this.oneDivideByX.Size = new System.Drawing.Size(75, 23);
            this.oneDivideByX.TabIndex = 21;
            this.oneDivideByX.Text = "OneDivideByX";
            this.oneDivideByX.UseVisualStyleBackColor = true;
            this.oneDivideByX.Click += new System.EventHandler(this.OneArgument);
            // 
            // reversePower
            // 
            this.reversePower.Location = new System.Drawing.Point(348, 169);
            this.reversePower.Name = "reversePower";
            this.reversePower.Size = new System.Drawing.Size(75, 23);
            this.reversePower.TabIndex = 22;
            this.reversePower.Text = "ReversePower";
            this.reversePower.UseVisualStyleBackColor = true;
            this.reversePower.Click += new System.EventHandler(this.CalculateTest);
            // 
            // max
            // 
            this.max.Location = new System.Drawing.Point(429, 169);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(75, 23);
            this.max.TabIndex = 23;
            this.max.Text = "Max";
            this.max.UseVisualStyleBackColor = true;
            this.max.Click += new System.EventHandler(this.CalculateTest);
            // 
            // meanGeometric
            // 
            this.meanGeometric.Location = new System.Drawing.Point(511, 168);
            this.meanGeometric.Name = "meanGeometric";
            this.meanGeometric.Size = new System.Drawing.Size(75, 23);
            this.meanGeometric.TabIndex = 24;
            this.meanGeometric.Text = "meanGeometric";
            this.meanGeometric.UseVisualStyleBackColor = true;
            this.meanGeometric.Click += new System.EventHandler(this.CalculateTest);
            // 
            // cose
            // 
            this.cose.Location = new System.Drawing.Point(593, 168);
            this.cose.Name = "cose";
            this.cose.Size = new System.Drawing.Size(75, 23);
            this.cose.TabIndex = 25;
            this.cose.Text = "cose";
            this.cose.UseVisualStyleBackColor = true;
            this.cose.Click += new System.EventHandler(this.OneArgument);
            // 
            // exp
            // 
            this.exp.Location = new System.Drawing.Point(348, 199);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(75, 23);
            this.exp.TabIndex = 26;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.OneArgument);
            // 
            // arccose
            // 
            this.arccose.Location = new System.Drawing.Point(429, 198);
            this.arccose.Name = "arccose";
            this.arccose.Size = new System.Drawing.Size(75, 23);
            this.arccose.TabIndex = 27;
            this.arccose.Text = "arccose";
            this.arccose.UseVisualStyleBackColor = true;
            this.arccose.Click += new System.EventHandler(this.OneArgument);
            // 
            // arcctg
            // 
            this.arcctg.Location = new System.Drawing.Point(511, 199);
            this.arcctg.Name = "arcctg";
            this.arcctg.Size = new System.Drawing.Size(75, 23);
            this.arcctg.TabIndex = 28;
            this.arcctg.Text = "arcctg";
            this.arcctg.UseVisualStyleBackColor = true;
            this.arcctg.Click += new System.EventHandler(this.OneArgument);
            // 
            // catangent
            // 
            this.catangent.Location = new System.Drawing.Point(593, 198);
            this.catangent.Name = "catangent";
            this.catangent.Size = new System.Drawing.Size(75, 23);
            this.catangent.TabIndex = 29;
            this.catangent.Text = "catangent";
            this.catangent.UseVisualStyleBackColor = true;
            this.catangent.Click += new System.EventHandler(this.OneArgument);
            // 
            // logarithmTen
            // 
            this.logarithmTen.Location = new System.Drawing.Point(348, 228);
            this.logarithmTen.Name = "logarithmTen";
            this.logarithmTen.Size = new System.Drawing.Size(75, 23);
            this.logarithmTen.TabIndex = 30;
            this.logarithmTen.Text = "logarithmTen";
            this.logarithmTen.UseVisualStyleBackColor = true;
            this.logarithmTen.Click += new System.EventHandler(this.OneArgument);
            // 
            // twoDivide
            // 
            this.twoDivide.Location = new System.Drawing.Point(429, 228);
            this.twoDivide.Name = "twoDivide";
            this.twoDivide.Size = new System.Drawing.Size(75, 23);
            this.twoDivide.TabIndex = 31;
            this.twoDivide.Text = "twoDivide";
            this.twoDivide.UseVisualStyleBackColor = true;
            this.twoDivide.Click += new System.EventHandler(this.OneArgument);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Sasha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Pasha";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(679, 379);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 372);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.twoDivide);
            this.Controls.Add(this.logarithmTen);
            this.Controls.Add(this.catangent);
            this.Controls.Add(this.arcctg);
            this.Controls.Add(this.arccose);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.cose);
            this.Controls.Add(this.meanGeometric);
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
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.Button meanGeometric;
        private System.Windows.Forms.Button cose;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button arccose;
        private System.Windows.Forms.Button arcctg;
        private System.Windows.Forms.Button catangent;
        private System.Windows.Forms.Button logarithmTen;
        private System.Windows.Forms.Button twoDivide;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

