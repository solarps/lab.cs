namespace lab.cs
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.InputM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OutN = new System.Windows.Forms.RichTextBox();
            this.OutM = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.BtnGenerate.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BtnGenerate.Location = new System.Drawing.Point(454, 11);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(109, 53);
            this.BtnGenerate.TabIndex = 17;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // InputM
            // 
            this.InputM.Location = new System.Drawing.Point(350, 44);
            this.InputM.Name = "InputM";
            this.InputM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InputM.Size = new System.Drawing.Size(61, 20);
            this.InputM.TabIndex = 16;
            this.InputM.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(13, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter the number of equilateral triangles";
            // 
            // InputN
            // 
            this.InputN.Location = new System.Drawing.Point(350, 13);
            this.InputN.Name = "InputN";
            this.InputN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InputN.Size = new System.Drawing.Size(61, 20);
            this.InputN.TabIndex = 14;
            this.InputN.Text = "0";
            this.InputN.TextChanged += new System.EventHandler(this.InputN_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter the number of triangles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExit.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BtnExit.Location = new System.Drawing.Point(684, 391);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(104, 40);
            this.BtnExit.TabIndex = 10;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Triangles:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(350, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Equilateral triangles:";
            // 
            // OutN
            // 
            this.OutN.Location = new System.Drawing.Point(16, 123);
            this.OutN.Name = "OutN";
            this.OutN.Size = new System.Drawing.Size(326, 317);
            this.OutN.TabIndex = 22;
            this.OutN.Text = "";
            // 
            // OutM
            // 
            this.OutM.Location = new System.Drawing.Point(354, 123);
            this.OutM.Name = "OutM";
            this.OutM.Size = new System.Drawing.Size(326, 317);
            this.OutM.TabIndex = 23;
            this.OutM.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OutM);
            this.Controls.Add(this.OutN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.InputM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnExit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.TextBox InputM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox OutN;
        private System.Windows.Forms.RichTextBox OutM;
    }
}

