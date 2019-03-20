namespace exercicioGraus
{
    partial class graus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(graus));
            this.Rbtn1 = new System.Windows.Forms.RadioButton();
            this.Rbtn2 = new System.Windows.Forms.RadioButton();
            this.Rbtn3 = new System.Windows.Forms.RadioButton();
            this.txt_Valor1 = new System.Windows.Forms.TextBox();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.Rbtn4 = new System.Windows.Forms.RadioButton();
            this.Rbtn5 = new System.Windows.Forms.RadioButton();
            this.Rbtn6 = new System.Windows.Forms.RadioButton();
            this.btnRes = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rbtn1
            // 
            this.Rbtn1.AutoSize = true;
            this.Rbtn1.BackColor = System.Drawing.Color.Transparent;
            this.Rbtn1.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rbtn1.Location = new System.Drawing.Point(70, 12);
            this.Rbtn1.Name = "Rbtn1";
            this.Rbtn1.Size = new System.Drawing.Size(88, 20);
            this.Rbtn1.TabIndex = 0;
            this.Rbtn1.TabStop = true;
            this.Rbtn1.Text = "Celsius";
            this.Rbtn1.UseVisualStyleBackColor = false;
            this.Rbtn1.CheckedChanged += new System.EventHandler(this.Rbtn1_CheckedChanged);
            // 
            // Rbtn2
            // 
            this.Rbtn2.AutoSize = true;
            this.Rbtn2.BackColor = System.Drawing.Color.Transparent;
            this.Rbtn2.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rbtn2.Location = new System.Drawing.Point(178, 12);
            this.Rbtn2.Name = "Rbtn2";
            this.Rbtn2.Size = new System.Drawing.Size(120, 20);
            this.Rbtn2.TabIndex = 1;
            this.Rbtn2.TabStop = true;
            this.Rbtn2.Text = " Fahrenheit";
            this.Rbtn2.UseVisualStyleBackColor = false;
            this.Rbtn2.CheckedChanged += new System.EventHandler(this.Rbtn2_CheckedChanged);
            // 
            // Rbtn3
            // 
            this.Rbtn3.AutoSize = true;
            this.Rbtn3.BackColor = System.Drawing.Color.Transparent;
            this.Rbtn3.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rbtn3.Location = new System.Drawing.Point(320, 12);
            this.Rbtn3.Name = "Rbtn3";
            this.Rbtn3.Size = new System.Drawing.Size(77, 20);
            this.Rbtn3.TabIndex = 2;
            this.Rbtn3.TabStop = true;
            this.Rbtn3.Text = "Kelvin";
            this.Rbtn3.UseVisualStyleBackColor = false;
            this.Rbtn3.CheckedChanged += new System.EventHandler(this.Rbtn3_CheckedChanged);
            // 
            // txt_Valor1
            // 
            this.txt_Valor1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Valor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Valor1.Font = new System.Drawing.Font("BankGothic Lt BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor1.ForeColor = System.Drawing.Color.Chartreuse;
            this.txt_Valor1.Location = new System.Drawing.Point(111, 51);
            this.txt_Valor1.Name = "txt_Valor1";
            this.txt_Valor1.Size = new System.Drawing.Size(260, 37);
            this.txt_Valor1.TabIndex = 3;
            this.txt_Valor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_res
            // 
            this.txt_res.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_res.Font = new System.Drawing.Font("BankGothic Lt BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_res.ForeColor = System.Drawing.Color.Chartreuse;
            this.txt_res.Location = new System.Drawing.Point(111, 259);
            this.txt_res.Name = "txt_res";
            this.txt_res.Size = new System.Drawing.Size(260, 44);
            this.txt_res.TabIndex = 7;
            this.txt_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Rbtn4
            // 
            this.Rbtn4.AutoSize = true;
            this.Rbtn4.BackColor = System.Drawing.Color.Transparent;
            this.Rbtn4.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rbtn4.Location = new System.Drawing.Point(70, 156);
            this.Rbtn4.Name = "Rbtn4";
            this.Rbtn4.Size = new System.Drawing.Size(88, 20);
            this.Rbtn4.TabIndex = 4;
            this.Rbtn4.TabStop = true;
            this.Rbtn4.Text = "Celsius";
            this.Rbtn4.UseVisualStyleBackColor = false;
            this.Rbtn4.CheckedChanged += new System.EventHandler(this.Rbtn4_CheckedChanged);
            // 
            // Rbtn5
            // 
            this.Rbtn5.AutoSize = true;
            this.Rbtn5.BackColor = System.Drawing.Color.Transparent;
            this.Rbtn5.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Rbtn5.Location = new System.Drawing.Point(178, 156);
            this.Rbtn5.Name = "Rbtn5";
            this.Rbtn5.Size = new System.Drawing.Size(120, 20);
            this.Rbtn5.TabIndex = 5;
            this.Rbtn5.TabStop = true;
            this.Rbtn5.Text = " Fahrenheit";
            this.Rbtn5.UseVisualStyleBackColor = false;
            this.Rbtn5.CheckedChanged += new System.EventHandler(this.Rbtn5_CheckedChanged);
            // 
            // Rbtn6
            // 
            this.Rbtn6.AutoSize = true;
            this.Rbtn6.BackColor = System.Drawing.Color.Transparent;
            this.Rbtn6.Font = new System.Drawing.Font("BankGothic Lt BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rbtn6.Location = new System.Drawing.Point(320, 156);
            this.Rbtn6.Name = "Rbtn6";
            this.Rbtn6.Size = new System.Drawing.Size(77, 20);
            this.Rbtn6.TabIndex = 6;
            this.Rbtn6.TabStop = true;
            this.Rbtn6.Text = "Kelvin";
            this.Rbtn6.UseVisualStyleBackColor = false;
            this.Rbtn6.CheckedChanged += new System.EventHandler(this.Rbtn6_CheckedChanged);
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.Color.Transparent;
            this.btnRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRes.BackgroundImage")));
            this.btnRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRes.Font = new System.Drawing.Font("BankGothic Lt BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.Transparent;
            this.btnRes.Location = new System.Drawing.Point(169, 209);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(129, 31);
            this.btnRes.TabIndex = 8;
            this.btnRes.Text = "Converter";
            this.btnRes.UseVisualStyleBackColor = false;
            this.btnRes.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_clear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_clear.BackgroundImage")));
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("BankGothic Lt BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_clear.Location = new System.Drawing.Point(167, 309);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(131, 34);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // graus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(451, 373);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.Rbtn6);
            this.Controls.Add(this.Rbtn5);
            this.Controls.Add(this.Rbtn4);
            this.Controls.Add(this.txt_Valor1);
            this.Controls.Add(this.Rbtn3);
            this.Controls.Add(this.Rbtn2);
            this.Controls.Add(this.Rbtn1);
            this.Name = "graus";
            this.ShowIcon = false;
            this.Text = "Calcular Graus";
            this.Load += new System.EventHandler(this.graus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Rbtn1;
        private System.Windows.Forms.RadioButton Rbtn2;
        private System.Windows.Forms.RadioButton Rbtn3;
        private System.Windows.Forms.TextBox txt_Valor1;
        private System.Windows.Forms.TextBox txt_res;
        private System.Windows.Forms.RadioButton Rbtn4;
        private System.Windows.Forms.RadioButton Rbtn5;
        private System.Windows.Forms.RadioButton Rbtn6;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btn_clear;
    }
}

