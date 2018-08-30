namespace ComplexArithmeticCalculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtReal1 = new System.Windows.Forms.TextBox();
            this.txtImag1 = new System.Windows.Forms.TextBox();
            this.lblImag1 = new System.Windows.Forms.Label();
            this.cbSign1 = new System.Windows.Forms.ComboBox();
            this.txtReal2 = new System.Windows.Forms.TextBox();
            this.cbSign2 = new System.Windows.Forms.ComboBox();
            this.txtImag2 = new System.Windows.Forms.TextBox();
            this.lblImag2 = new System.Windows.Forms.Label();
            this.cbArithmetic = new System.Windows.Forms.ComboBox();
            this.lblValueOne = new System.Windows.Forms.Label();
            this.lblValueTwo = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.txtReal1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtImag1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblImag1, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbSign1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtReal2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbSign2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtImag2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblImag2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbArithmetic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblValueOne, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValueTwo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCalc, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtResults, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(597, 363);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtReal1
            // 
            this.txtReal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReal1.Location = new System.Drawing.Point(108, 10);
            this.txtReal1.Name = "txtReal1";
            this.txtReal1.Size = new System.Drawing.Size(194, 30);
            this.txtReal1.TabIndex = 0;
            // 
            // txtImag1
            // 
            this.txtImag1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImag1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImag1.Location = new System.Drawing.Point(368, 10);
            this.txtImag1.Name = "txtImag1";
            this.txtImag1.Size = new System.Drawing.Size(194, 30);
            this.txtImag1.TabIndex = 2;
            // 
            // lblImag1
            // 
            this.lblImag1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImag1.AutoSize = true;
            this.lblImag1.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImag1.Location = new System.Drawing.Point(568, 0);
            this.lblImag1.Name = "lblImag1";
            this.lblImag1.Size = new System.Drawing.Size(14, 50);
            this.lblImag1.TabIndex = 1;
            this.lblImag1.Text = "i";
            this.lblImag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSign1
            // 
            this.cbSign1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSign1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSign1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSign1.FormattingEnabled = true;
            this.cbSign1.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbSign1.Location = new System.Drawing.Point(308, 12);
            this.cbSign1.Name = "cbSign1";
            this.cbSign1.Size = new System.Drawing.Size(54, 26);
            this.cbSign1.TabIndex = 1;
            // 
            // txtReal2
            // 
            this.txtReal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReal2.Location = new System.Drawing.Point(108, 95);
            this.txtReal2.Name = "txtReal2";
            this.txtReal2.Size = new System.Drawing.Size(194, 30);
            this.txtReal2.TabIndex = 4;
            // 
            // cbSign2
            // 
            this.cbSign2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSign2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSign2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSign2.FormattingEnabled = true;
            this.cbSign2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.cbSign2.Location = new System.Drawing.Point(308, 97);
            this.cbSign2.Name = "cbSign2";
            this.cbSign2.Size = new System.Drawing.Size(54, 26);
            this.cbSign2.TabIndex = 5;
            // 
            // txtImag2
            // 
            this.txtImag2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImag2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImag2.Location = new System.Drawing.Point(368, 95);
            this.txtImag2.Name = "txtImag2";
            this.txtImag2.Size = new System.Drawing.Size(194, 30);
            this.txtImag2.TabIndex = 6;
            // 
            // lblImag2
            // 
            this.lblImag2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImag2.AutoSize = true;
            this.lblImag2.Font = new System.Drawing.Font("Script MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImag2.Location = new System.Drawing.Point(568, 85);
            this.lblImag2.Name = "lblImag2";
            this.lblImag2.Size = new System.Drawing.Size(14, 50);
            this.lblImag2.TabIndex = 1;
            this.lblImag2.Text = "i";
            this.lblImag2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbArithmetic
            // 
            this.cbArithmetic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.cbArithmetic, 6);
            this.cbArithmetic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArithmetic.FormattingEnabled = true;
            this.cbArithmetic.Items.AddRange(new object[] {
            "ADD",
            "SUBTRACT",
            "MULTIPLY",
            "DIVIDE"});
            this.cbArithmetic.Location = new System.Drawing.Point(181, 54);
            this.cbArithmetic.Name = "cbArithmetic";
            this.cbArithmetic.Size = new System.Drawing.Size(235, 26);
            this.cbArithmetic.TabIndex = 3;
            // 
            // lblValueOne
            // 
            this.lblValueOne.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueOne.Location = new System.Drawing.Point(3, 0);
            this.lblValueOne.Name = "lblValueOne";
            this.lblValueOne.Size = new System.Drawing.Size(99, 50);
            this.lblValueOne.TabIndex = 4;
            this.lblValueOne.Text = "Value One:";
            this.lblValueOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueTwo
            // 
            this.lblValueTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueTwo.Location = new System.Drawing.Point(3, 85);
            this.lblValueTwo.Name = "lblValueTwo";
            this.lblValueTwo.Size = new System.Drawing.Size(99, 50);
            this.lblValueTwo.TabIndex = 4;
            this.lblValueTwo.Text = "Value Two:";
            this.lblValueTwo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.btnCalc, 3);
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(418, 138);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(125, 34);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "CALCULATE";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtResults
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtResults, 6);
            this.txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResults.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResults.Location = new System.Drawing.Point(3, 178);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(591, 182);
            this.txtResults.TabIndex = 8;
            this.txtResults.TabStop = false;
            this.txtResults.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 44);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Complex Number Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(597, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = "CS 3260 Lab 03 Complex Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtReal1;
        private System.Windows.Forms.TextBox txtImag1;
        private System.Windows.Forms.Label lblImag1;
        private System.Windows.Forms.ComboBox cbSign1;
        private System.Windows.Forms.TextBox txtReal2;
        private System.Windows.Forms.ComboBox cbSign2;
        private System.Windows.Forms.TextBox txtImag2;
        private System.Windows.Forms.Label lblImag2;
        private System.Windows.Forms.ComboBox cbArithmetic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblValueOne;
        private System.Windows.Forms.Label lblValueTwo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.RichTextBox txtResults;
    }
}

