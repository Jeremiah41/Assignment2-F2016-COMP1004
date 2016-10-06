namespace Assignment2_F2016_COMP1004
{
    partial class CarServiceForm
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
            this.AdditionalOptionsLabel = new System.Windows.Forms.Label();
            this.BasePriceLabel = new System.Windows.Forms.Label();
            this.SubTotalLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.TradeInAllowanceLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AmountDueLabel = new System.Windows.Forms.Label();
            this.BasePriceTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalOptionsTextBox = new System.Windows.Forms.TextBox();
            this.SubTotalTextBox = new System.Windows.Forms.TextBox();
            this.SalesTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TradeInAllowance = new System.Windows.Forms.TextBox();
            this.AmountDueTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalItemsGroupBox = new System.Windows.Forms.GroupBox();
            this.ExteriorFinishGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.AdditionalItemsGroupBox.SuspendLayout();
            this.ExteriorFinishGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdditionalOptionsLabel
            // 
            this.AdditionalOptionsLabel.AutoSize = true;
            this.AdditionalOptionsLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionalOptionsLabel.Location = new System.Drawing.Point(8, 58);
            this.AdditionalOptionsLabel.Name = "AdditionalOptionsLabel";
            this.AdditionalOptionsLabel.Size = new System.Drawing.Size(130, 19);
            this.AdditionalOptionsLabel.TabIndex = 0;
            this.AdditionalOptionsLabel.Text = "Additional Options :";
            this.AdditionalOptionsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BasePriceLabel
            // 
            this.BasePriceLabel.AutoSize = true;
            this.BasePriceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasePriceLabel.Location = new System.Drawing.Point(52, 35);
            this.BasePriceLabel.Name = "BasePriceLabel";
            this.BasePriceLabel.Size = new System.Drawing.Size(81, 19);
            this.BasePriceLabel.TabIndex = 1;
            this.BasePriceLabel.Text = "Base Price :";
            this.BasePriceLabel.Click += new System.EventHandler(this.BasePriceLabel_Click);
            // 
            // SubTotalLabel
            // 
            this.SubTotalLabel.AutoSize = true;
            this.SubTotalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalLabel.Location = new System.Drawing.Point(63, 87);
            this.SubTotalLabel.Name = "SubTotalLabel";
            this.SubTotalLabel.Size = new System.Drawing.Size(70, 19);
            this.SubTotalLabel.TabIndex = 2;
            this.SubTotalLabel.Text = "SubTotal :";
            this.SubTotalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(21, 115);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(117, 19);
            this.SalesTaxLabel.TabIndex = 3;
            this.SalesTaxLabel.Text = "Sales Tax (13%) :";
            this.SalesTaxLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // TradeInAllowanceLabel
            // 
            this.TradeInAllowanceLabel.AutoSize = true;
            this.TradeInAllowanceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TradeInAllowanceLabel.Location = new System.Drawing.Point(8, 167);
            this.TradeInAllowanceLabel.Name = "TradeInAllowanceLabel";
            this.TradeInAllowanceLabel.Size = new System.Drawing.Size(128, 19);
            this.TradeInAllowanceLabel.TabIndex = 4;
            this.TradeInAllowanceLabel.Text = "Trade in Allowance:";
            this.TradeInAllowanceLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(87, 141);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(46, 19);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "Total :";
            this.TotalLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // AmountDueLabel
            // 
            this.AmountDueLabel.AutoSize = true;
            this.AmountDueLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountDueLabel.Location = new System.Drawing.Point(47, 193);
            this.AmountDueLabel.Name = "AmountDueLabel";
            this.AmountDueLabel.Size = new System.Drawing.Size(86, 19);
            this.AmountDueLabel.TabIndex = 6;
            this.AmountDueLabel.Text = "Amount Due";
            this.AmountDueLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // BasePriceTextBox
            // 
            this.BasePriceTextBox.Location = new System.Drawing.Point(155, 36);
            this.BasePriceTextBox.Name = "BasePriceTextBox";
            this.BasePriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BasePriceTextBox.TabIndex = 7;
            this.BasePriceTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AdditionalOptionsTextBox
            // 
            this.AdditionalOptionsTextBox.Location = new System.Drawing.Point(155, 62);
            this.AdditionalOptionsTextBox.Name = "AdditionalOptionsTextBox";
            this.AdditionalOptionsTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdditionalOptionsTextBox.TabIndex = 8;
            this.AdditionalOptionsTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SubTotalTextBox
            // 
            this.SubTotalTextBox.Location = new System.Drawing.Point(155, 88);
            this.SubTotalTextBox.Name = "SubTotalTextBox";
            this.SubTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubTotalTextBox.TabIndex = 9;
            this.SubTotalTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // SalesTaxTextBox
            // 
            this.SalesTaxTextBox.Location = new System.Drawing.Point(155, 114);
            this.SalesTaxTextBox.Name = "SalesTaxTextBox";
            this.SalesTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SalesTaxTextBox.TabIndex = 10;
            this.SalesTaxTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(155, 140);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalTextBox.TabIndex = 11;
            this.TotalTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // TradeInAllowance
            // 
            this.TradeInAllowance.Location = new System.Drawing.Point(155, 166);
            this.TradeInAllowance.Name = "TradeInAllowance";
            this.TradeInAllowance.Size = new System.Drawing.Size(100, 20);
            this.TradeInAllowance.TabIndex = 12;
            this.TradeInAllowance.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // AmountDueTextBox
            // 
            this.AmountDueTextBox.Location = new System.Drawing.Point(155, 192);
            this.AmountDueTextBox.Name = "AmountDueTextBox";
            this.AmountDueTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmountDueTextBox.TabIndex = 13;
            this.AmountDueTextBox.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // AdditionalItemsGroupBox
            // 
            this.AdditionalItemsGroupBox.Controls.Add(this.checkBox3);
            this.AdditionalItemsGroupBox.Controls.Add(this.checkBox2);
            this.AdditionalItemsGroupBox.Controls.Add(this.checkBox1);
            this.AdditionalItemsGroupBox.Location = new System.Drawing.Point(268, 36);
            this.AdditionalItemsGroupBox.Name = "AdditionalItemsGroupBox";
            this.AdditionalItemsGroupBox.Size = new System.Drawing.Size(200, 112);
            this.AdditionalItemsGroupBox.TabIndex = 14;
            this.AdditionalItemsGroupBox.TabStop = false;
            this.AdditionalItemsGroupBox.Text = "Additional Items";
            // 
            // ExteriorFinishGroupBox
            // 
            this.ExteriorFinishGroupBox.Controls.Add(this.radioButton3);
            this.ExteriorFinishGroupBox.Controls.Add(this.radioButton2);
            this.ExteriorFinishGroupBox.Controls.Add(this.radioButton1);
            this.ExteriorFinishGroupBox.Location = new System.Drawing.Point(268, 154);
            this.ExteriorFinishGroupBox.Name = "ExteriorFinishGroupBox";
            this.ExteriorFinishGroupBox.Size = new System.Drawing.Size(200, 100);
            this.ExteriorFinishGroupBox.TabIndex = 15;
            this.ExteriorFinishGroupBox.TabStop = false;
            this.ExteriorFinishGroupBox.Text = "Exterior Finish";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(7, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(108, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Stereo Systems";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(7, 51);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(108, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Leather Interior";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(7, 76);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(140, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Computer Navigation";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(7, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Standard";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(7, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pearlized";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(7, 69);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(138, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Customized Detailing";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(12, 298);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(87, 33);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(208, 298);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(87, 33);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(381, 298);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(87, 33);
            this.ExitButton.TabIndex = 17;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // CarServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExteriorFinishGroupBox);
            this.Controls.Add(this.AdditionalItemsGroupBox);
            this.Controls.Add(this.AmountDueTextBox);
            this.Controls.Add(this.TradeInAllowance);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SalesTaxTextBox);
            this.Controls.Add(this.SubTotalTextBox);
            this.Controls.Add(this.AdditionalOptionsTextBox);
            this.Controls.Add(this.BasePriceTextBox);
            this.Controls.Add(this.AmountDueLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TradeInAllowanceLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.SubTotalLabel);
            this.Controls.Add(this.BasePriceLabel);
            this.Controls.Add(this.AdditionalOptionsLabel);
            this.Name = "CarServices";
            this.Text = "Car Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AdditionalItemsGroupBox.ResumeLayout(false);
            this.AdditionalItemsGroupBox.PerformLayout();
            this.ExteriorFinishGroupBox.ResumeLayout(false);
            this.ExteriorFinishGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdditionalOptionsLabel;
        private System.Windows.Forms.Label BasePriceLabel;
        private System.Windows.Forms.Label SubTotalLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label TradeInAllowanceLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label AmountDueLabel;
        private System.Windows.Forms.TextBox BasePriceTextBox;
        private System.Windows.Forms.TextBox AdditionalOptionsTextBox;
        private System.Windows.Forms.TextBox SubTotalTextBox;
        private System.Windows.Forms.TextBox SalesTaxTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox TradeInAllowance;
        private System.Windows.Forms.TextBox AmountDueTextBox;
        private System.Windows.Forms.GroupBox AdditionalItemsGroupBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox ExteriorFinishGroupBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

