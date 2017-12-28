namespace orbits_generator
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkBoxInverses = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioOdd = new System.Windows.Forms.RadioButton();
            this.radioEven = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(59, 35);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(13, 20);
            this.textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(117, 35);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(13, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(175, 35);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(13, 20);
            this.textBoxC.TabIndex = 2;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(139, 79);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(13, 20);
            this.textBoxN.TabIndex = 3;
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(156, 69);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(13, 20);
            this.textBoxK.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "+";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "+";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "modulus:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "2";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(83, 228);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 36);
            this.buttonGenerate.TabIndex = 11;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // checkBoxInverses
            // 
            this.checkBoxInverses.AutoSize = true;
            this.checkBoxInverses.Location = new System.Drawing.Point(69, 131);
            this.checkBoxInverses.Name = "checkBoxInverses";
            this.checkBoxInverses.Size = new System.Drawing.Size(103, 17);
            this.checkBoxInverses.TabIndex = 12;
            this.checkBoxInverses.Text = "Display Inverses";
            this.checkBoxInverses.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-7, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "---------------------------------------------------------------------------------" +
    "----";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(69, 159);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(106, 17);
            this.radioAll.TabIndex = 14;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "All Real Numbers";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioOdd
            // 
            this.radioOdd.AutoSize = true;
            this.radioOdd.Location = new System.Drawing.Point(69, 179);
            this.radioOdd.Name = "radioOdd";
            this.radioOdd.Size = new System.Drawing.Size(104, 17);
            this.radioOdd.TabIndex = 15;
            this.radioOdd.TabStop = true;
            this.radioOdd.Text = "All Odd Numbers";
            this.radioOdd.UseVisualStyleBackColor = true;
            // 
            // radioEven
            // 
            this.radioEven.AutoSize = true;
            this.radioEven.Location = new System.Drawing.Point(69, 199);
            this.radioEven.Name = "radioEven";
            this.radioEven.Size = new System.Drawing.Size(109, 17);
            this.radioEven.TabIndex = 16;
            this.radioEven.TabStop = true;
            this.radioEven.Text = "All Even Numbers";
            this.radioEven.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 276);
            this.Controls.Add(this.radioEven);
            this.Controls.Add(this.radioOdd);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxInverses);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Orbit Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox checkBoxInverses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioOdd;
        private System.Windows.Forms.RadioButton radioEven;
    }
}

