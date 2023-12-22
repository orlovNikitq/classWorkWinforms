namespace WindowsFormsApp5
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameT = new System.Windows.Forms.TextBox();
            this.madeT = new System.Windows.Forms.TextBox();
            this.priceT = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Производитель ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // nameT
            // 
            this.nameT.Location = new System.Drawing.Point(49, 37);
            this.nameT.Name = "nameT";
            this.nameT.Size = new System.Drawing.Size(150, 20);
            this.nameT.TabIndex = 3;
            // 
            // madeT
            // 
            this.madeT.Location = new System.Drawing.Point(49, 95);
            this.madeT.Name = "madeT";
            this.madeT.Size = new System.Drawing.Size(150, 20);
            this.madeT.TabIndex = 4;
            // 
            // priceT
            // 
            this.priceT.Location = new System.Drawing.Point(49, 145);
            this.priceT.Name = "priceT";
            this.priceT.Size = new System.Drawing.Size(150, 20);
            this.priceT.TabIndex = 5;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(266, 37);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(153, 38);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(266, 131);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(153, 34);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 206);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.priceT);
            this.Controls.Add(this.madeT);
            this.Controls.Add(this.nameT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameT;
        private System.Windows.Forms.TextBox madeT;
        private System.Windows.Forms.TextBox priceT;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button cancel;
    }
}