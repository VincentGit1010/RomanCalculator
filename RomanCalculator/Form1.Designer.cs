namespace RomanCalculator
{
    partial class WndRomanCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WndRomanCalculator));
            this.txtCalculation = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnMemStore = new System.Windows.Forms.Button();
            this.btnMemMin = new System.Windows.Forms.Button();
            this.btnMemPlus = new System.Windows.Forms.Button();
            this.btnMemRecall = new System.Windows.Forms.Button();
            this.btnMemClear = new System.Windows.Forms.Button();
            this.txtBackspace = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnProcent = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnComma = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnMemShow = new System.Windows.Forms.Button();
            this.btnKwadraat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCalculation
            // 
            this.txtCalculation.BackColor = System.Drawing.SystemColors.Control;
            this.txtCalculation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCalculation.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalculation.Location = new System.Drawing.Point(6, 7);
            this.txtCalculation.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalculation.Name = "txtCalculation";
            this.txtCalculation.ReadOnly = true;
            this.txtCalculation.Size = new System.Drawing.Size(340, 19);
            this.txtCalculation.TabIndex = 63;
            this.txtCalculation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(8, 34);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(338, 44);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtOutput_KeyPress);
            // 
            // btnMemStore
            // 
            this.btnMemStore.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemStore.Location = new System.Drawing.Point(236, 92);
            this.btnMemStore.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemStore.Name = "btnMemStore";
            this.btnMemStore.Size = new System.Drawing.Size(53, 32);
            this.btnMemStore.TabIndex = 60;
            this.btnMemStore.Tag = "MS";
            this.btnMemStore.Text = "MS";
            this.btnMemStore.UseVisualStyleBackColor = false;
            // 
            // btnMemMin
            // 
            this.btnMemMin.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemMin.Location = new System.Drawing.Point(178, 92);
            this.btnMemMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemMin.Name = "btnMemMin";
            this.btnMemMin.Size = new System.Drawing.Size(53, 32);
            this.btnMemMin.TabIndex = 59;
            this.btnMemMin.Tag = "M-";
            this.btnMemMin.Text = "M-";
            this.btnMemMin.UseVisualStyleBackColor = false;
            // 
            // btnMemPlus
            // 
            this.btnMemPlus.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemPlus.Location = new System.Drawing.Point(121, 92);
            this.btnMemPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemPlus.Name = "btnMemPlus";
            this.btnMemPlus.Size = new System.Drawing.Size(53, 32);
            this.btnMemPlus.TabIndex = 58;
            this.btnMemPlus.Tag = "M+";
            this.btnMemPlus.Text = "M+";
            this.btnMemPlus.UseVisualStyleBackColor = false;
            // 
            // btnMemRecall
            // 
            this.btnMemRecall.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemRecall.Enabled = false;
            this.btnMemRecall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemRecall.Location = new System.Drawing.Point(63, 92);
            this.btnMemRecall.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemRecall.Name = "btnMemRecall";
            this.btnMemRecall.Size = new System.Drawing.Size(53, 32);
            this.btnMemRecall.TabIndex = 57;
            this.btnMemRecall.Tag = "MR";
            this.btnMemRecall.Text = "MR";
            this.btnMemRecall.UseVisualStyleBackColor = false;
            // 
            // btnMemClear
            // 
            this.btnMemClear.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemClear.Enabled = false;
            this.btnMemClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemClear.Location = new System.Drawing.Point(6, 92);
            this.btnMemClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemClear.Name = "btnMemClear";
            this.btnMemClear.Size = new System.Drawing.Size(53, 32);
            this.btnMemClear.TabIndex = 56;
            this.btnMemClear.Tag = "MC";
            this.btnMemClear.Text = "MC";
            this.btnMemClear.UseVisualStyleBackColor = false;
            // 
            // txtBackspace
            // 
            this.txtBackspace.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBackspace.Location = new System.Drawing.Point(265, 128);
            this.txtBackspace.Margin = new System.Windows.Forms.Padding(2);
            this.txtBackspace.Name = "txtBackspace";
            this.txtBackspace.Size = new System.Drawing.Size(81, 49);
            this.txtBackspace.TabIndex = 55;
            this.txtBackspace.Tag = "BS";
            this.txtBackspace.Text = "←";
            this.txtBackspace.UseVisualStyleBackColor = false;
            this.txtBackspace.Click += new System.EventHandler(this.TxtBackspace_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(179, 128);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 49);
            this.btnClear.TabIndex = 54;
            this.btnClear.Tag = "C";
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEntry.Location = new System.Drawing.Point(93, 128);
            this.btnClearEntry.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(82, 49);
            this.btnClearEntry.TabIndex = 53;
            this.btnClearEntry.Tag = "CE";
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.BtnClearEntry_Click);
            // 
            // btnProcent
            // 
            this.btnProcent.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProcent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcent.Location = new System.Drawing.Point(6, 128);
            this.btnProcent.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcent.Name = "btnProcent";
            this.btnProcent.Size = new System.Drawing.Size(81, 49);
            this.btnProcent.TabIndex = 52;
            this.btnProcent.Tag = "%";
            this.btnProcent.Text = "%";
            this.btnProcent.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(265, 180);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(2);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(81, 49);
            this.btnDivide.TabIndex = 51;
            this.btnDivide.Tag = "/";
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(179, 180);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(2);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(81, 49);
            this.btnSquare.TabIndex = 50;
            this.btnSquare.Tag = "vx";
            this.btnSquare.Text = "√x";
            this.btnSquare.UseVisualStyleBackColor = false;
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReciprocal.Location = new System.Drawing.Point(93, 180);
            this.btnReciprocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(82, 49);
            this.btnReciprocal.TabIndex = 49;
            this.btnReciprocal.Tag = "1/x";
            this.btnReciprocal.Text = "⅟x";
            this.btnReciprocal.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(265, 234);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(2);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(81, 49);
            this.btnMultiply.TabIndex = 47;
            this.btnMultiply.Tag = "*";
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(265, 287);
            this.btnMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(81, 49);
            this.btnMin.TabIndex = 46;
            this.btnMin.Tag = "-";
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(265, 340);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(81, 49);
            this.btnPlus.TabIndex = 45;
            this.btnPlus.Tag = "+";
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(265, 392);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(81, 49);
            this.btnEquals.TabIndex = 62;
            this.btnEquals.Tag = "=";
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // btnM
            // 
            this.btnM.BackColor = System.Drawing.Color.White;
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnM.Location = new System.Drawing.Point(179, 236);
            this.btnM.Margin = new System.Windows.Forms.Padding(2);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(81, 65);
            this.btnM.TabIndex = 43;
            this.btnM.Tag = "M";
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = false;
            this.btnM.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnComma
            // 
            this.btnComma.BackColor = System.Drawing.Color.White;
            this.btnComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComma.Location = new System.Drawing.Point(179, 374);
            this.btnComma.Margin = new System.Windows.Forms.Padding(2);
            this.btnComma.Name = "btnComma";
            this.btnComma.Size = new System.Drawing.Size(81, 65);
            this.btnComma.TabIndex = 42;
            this.btnComma.Tag = ",";
            this.btnComma.Text = ",";
            this.btnComma.UseVisualStyleBackColor = false;
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.White;
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.Location = new System.Drawing.Point(93, 374);
            this.btnI.Margin = new System.Windows.Forms.Padding(2);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(82, 65);
            this.btnI.TabIndex = 41;
            this.btnI.Tag = "I";
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnV
            // 
            this.btnV.BackColor = System.Drawing.Color.White;
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnV.Location = new System.Drawing.Point(6, 305);
            this.btnV.Margin = new System.Windows.Forms.Padding(2);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(81, 65);
            this.btnV.TabIndex = 37;
            this.btnV.Tag = "V";
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = false;
            this.btnV.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnL
            // 
            this.btnL.BackColor = System.Drawing.Color.White;
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL.Location = new System.Drawing.Point(179, 305);
            this.btnL.Margin = new System.Windows.Forms.Padding(2);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(81, 65);
            this.btnL.TabIndex = 35;
            this.btnL.Tag = "L";
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = false;
            this.btnL.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.White;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(6, 236);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(81, 65);
            this.btnC.TabIndex = 34;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.White;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.Location = new System.Drawing.Point(93, 305);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(82, 65);
            this.btnX.TabIndex = 33;
            this.btnX.Tag = "X";
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnNegate
            // 
            this.btnNegate.BackColor = System.Drawing.Color.White;
            this.btnNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNegate.Location = new System.Drawing.Point(6, 374);
            this.btnNegate.Margin = new System.Windows.Forms.Padding(2);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(81, 65);
            this.btnNegate.TabIndex = 32;
            this.btnNegate.Tag = "+/-";
            this.btnNegate.Text = "+ / -";
            this.btnNegate.UseVisualStyleBackColor = false;
            // 
            // btnD
            // 
            this.btnD.BackColor = System.Drawing.Color.White;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(93, 236);
            this.btnD.Margin = new System.Windows.Forms.Padding(2);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(82, 65);
            this.btnD.TabIndex = 64;
            this.btnD.Tag = "D";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = false;
            this.btnD.Click += new System.EventHandler(this.BtnNumber_Click);
            // 
            // btnMemShow
            // 
            this.btnMemShow.BackColor = System.Drawing.SystemColors.Control;
            this.btnMemShow.Enabled = false;
            this.btnMemShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemShow.Image = global::RomanCalculator.Properties.Resources.ToonGeheugenknopSmall;
            this.btnMemShow.Location = new System.Drawing.Point(292, 92);
            this.btnMemShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnMemShow.Name = "btnMemShow";
            this.btnMemShow.Size = new System.Drawing.Size(53, 32);
            this.btnMemShow.TabIndex = 61;
            this.btnMemShow.Tag = "MEM";
            this.btnMemShow.UseVisualStyleBackColor = false;
            // 
            // btnKwadraat
            // 
            this.btnKwadraat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnKwadraat.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKwadraat.Image = ((System.Drawing.Image)(resources.GetObject("btnKwadraat.Image")));
            this.btnKwadraat.Location = new System.Drawing.Point(6, 181);
            this.btnKwadraat.Margin = new System.Windows.Forms.Padding(2);
            this.btnKwadraat.Name = "btnKwadraat";
            this.btnKwadraat.Size = new System.Drawing.Size(81, 49);
            this.btnKwadraat.TabIndex = 48;
            this.btnKwadraat.Tag = "x2";
            this.btnKwadraat.UseVisualStyleBackColor = false;
            // 
            // WndRomanCalculator
            // 
            this.AcceptButton = this.btnEquals;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 448);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.txtCalculation);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnMemShow);
            this.Controls.Add(this.btnMemStore);
            this.Controls.Add(this.btnMemMin);
            this.Controls.Add(this.btnMemPlus);
            this.Controls.Add(this.btnMemRecall);
            this.Controls.Add(this.btnMemClear);
            this.Controls.Add(this.txtBackspace);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnProcent);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnReciprocal);
            this.Controls.Add(this.btnKwadraat);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnM);
            this.Controls.Add(this.btnComma);
            this.Controls.Add(this.btnI);
            this.Controls.Add(this.btnV);
            this.Controls.Add(this.btnL);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnNegate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WndRomanCalculator";
            this.Text = "Roman Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCalculation;
        internal System.Windows.Forms.TextBox txtOutput;
        internal System.Windows.Forms.Button btnMemShow;
        internal System.Windows.Forms.Button btnMemStore;
        internal System.Windows.Forms.Button btnMemMin;
        internal System.Windows.Forms.Button btnMemPlus;
        internal System.Windows.Forms.Button btnMemRecall;
        internal System.Windows.Forms.Button btnMemClear;
        internal System.Windows.Forms.Button txtBackspace;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnClearEntry;
        internal System.Windows.Forms.Button btnProcent;
        internal System.Windows.Forms.Button btnDivide;
        internal System.Windows.Forms.Button btnSquare;
        internal System.Windows.Forms.Button btnReciprocal;
        internal System.Windows.Forms.Button btnKwadraat;
        internal System.Windows.Forms.Button btnMultiply;
        internal System.Windows.Forms.Button btnMin;
        internal System.Windows.Forms.Button btnPlus;
        internal System.Windows.Forms.Button btnEquals;
        internal System.Windows.Forms.Button btnM;
        internal System.Windows.Forms.Button btnComma;
        internal System.Windows.Forms.Button btnI;
        internal System.Windows.Forms.Button btnV;
        internal System.Windows.Forms.Button btnL;
        internal System.Windows.Forms.Button btnC;
        internal System.Windows.Forms.Button btnX;
        internal System.Windows.Forms.Button btnNegate;
        internal System.Windows.Forms.Button btnD;
    }
}

