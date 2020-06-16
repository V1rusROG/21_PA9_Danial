namespace _21_Danial_PA9
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
        private void InitializeComponent()
        {
            this.AmountLabel = new System.Windows.Forms.Label();
            this.SelectCurrencyLabel = new System.Windows.Forms.Label();
            this.ConvertedAmountLabel = new System.Windows.Forms.Label();
            this.Btn_Convert = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.Txt_Converted = new System.Windows.Forms.TextBox();
            this.Rb_USDollars = new System.Windows.Forms.RadioButton();
            this.Rb_JapaneseYen = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(175, 61);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(56, 17);
            this.AmountLabel.TabIndex = 0;
            this.AmountLabel.Text = "Amount";
            // 
            // SelectCurrencyLabel
            // 
            this.SelectCurrencyLabel.AutoSize = true;
            this.SelectCurrencyLabel.Location = new System.Drawing.Point(123, 139);
            this.SelectCurrencyLabel.Name = "SelectCurrencyLabel";
            this.SelectCurrencyLabel.Size = new System.Drawing.Size(112, 17);
            this.SelectCurrencyLabel.TabIndex = 1;
            this.SelectCurrencyLabel.Text = "Select Currency:";
            // 
            // ConvertedAmountLabel
            // 
            this.ConvertedAmountLabel.AutoSize = true;
            this.ConvertedAmountLabel.Location = new System.Drawing.Point(106, 277);
            this.ConvertedAmountLabel.Name = "ConvertedAmountLabel";
            this.ConvertedAmountLabel.Size = new System.Drawing.Size(125, 17);
            this.ConvertedAmountLabel.TabIndex = 2;
            this.ConvertedAmountLabel.Text = "Converted Amount";
            // 
            // Btn_Convert
            // 
            this.Btn_Convert.Location = new System.Drawing.Point(422, 270);
            this.Btn_Convert.Name = "Btn_Convert";
            this.Btn_Convert.Size = new System.Drawing.Size(75, 23);
            this.Btn_Convert.TabIndex = 3;
            this.Btn_Convert.Text = "Convert";
            this.Btn_Convert.UseVisualStyleBackColor = true;
            this.Btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(422, 317);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.Btn_Clear.TabIndex = 4;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Location = new System.Drawing.Point(247, 56);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(100, 22);
            this.Txt_Amount.TabIndex = 5;
            this.Txt_Amount.TextChanged += new System.EventHandler(this.Txt_Amount_TextChanged);
            // 
            // Txt_Converted
            // 
            this.Txt_Converted.Location = new System.Drawing.Point(247, 272);
            this.Txt_Converted.Name = "Txt_Converted";
            this.Txt_Converted.Size = new System.Drawing.Size(100, 22);
            this.Txt_Converted.TabIndex = 6;
            this.Txt_Converted.TextChanged += new System.EventHandler(this.Txt_Converted_TextChanged);
            // 
            // Rb_USDollars
            // 
            this.Rb_USDollars.AutoSize = true;
            this.Rb_USDollars.Location = new System.Drawing.Point(247, 139);
            this.Rb_USDollars.Name = "Rb_USDollars";
            this.Rb_USDollars.Size = new System.Drawing.Size(96, 21);
            this.Rb_USDollars.TabIndex = 7;
            this.Rb_USDollars.TabStop = true;
            this.Rb_USDollars.Text = "US Dollars";
            this.Rb_USDollars.UseVisualStyleBackColor = true;
            this.Rb_USDollars.CheckedChanged += new System.EventHandler(this.Rb_USDollars_CheckedChanged);
            // 
            // Rb_JapaneseYen
            // 
            this.Rb_JapaneseYen.AutoSize = true;
            this.Rb_JapaneseYen.Location = new System.Drawing.Point(247, 166);
            this.Rb_JapaneseYen.Name = "Rb_JapaneseYen";
            this.Rb_JapaneseYen.Size = new System.Drawing.Size(120, 21);
            this.Rb_JapaneseYen.TabIndex = 8;
            this.Rb_JapaneseYen.TabStop = true;
            this.Rb_JapaneseYen.Text = "Japanese Yen";
            this.Rb_JapaneseYen.UseVisualStyleBackColor = true;
            this.Rb_JapaneseYen.CheckedChanged += new System.EventHandler(this.Rb_JapaneseYen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 364);
            this.Controls.Add(this.Rb_JapaneseYen);
            this.Controls.Add(this.Rb_USDollars);
            this.Controls.Add(this.Txt_Converted);
            this.Controls.Add(this.Txt_Amount);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Convert);
            this.Controls.Add(this.ConvertedAmountLabel);
            this.Controls.Add(this.SelectCurrencyLabel);
            this.Controls.Add(this.AmountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label SelectCurrencyLabel;
        private System.Windows.Forms.Label ConvertedAmountLabel;
        private System.Windows.Forms.Button Btn_Convert;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.TextBox Txt_Converted;
        private System.Windows.Forms.RadioButton Rb_USDollars;
        private System.Windows.Forms.RadioButton Rb_JapaneseYen;
    }
}

