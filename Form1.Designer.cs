namespace WindowsFormsApp5
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.redact = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(364, 238);
            this.listBox1.TabIndex = 0;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(110, 256);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(160, 23);
            this.add.TabIndex = 1;
            this.add.Text = "add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // redact
            // 
            this.redact.Location = new System.Drawing.Point(110, 285);
            this.redact.Name = "redact";
            this.redact.Size = new System.Drawing.Size(160, 23);
            this.redact.TabIndex = 2;
            this.redact.Text = "redact";
            this.redact.UseVisualStyleBackColor = true;
            this.redact.Click += new System.EventHandler(this.redact_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(110, 314);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(160, 23);
            this.del.TabIndex = 3;
            this.del.Text = "del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(110, 343);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(160, 23);
            this.clear.TabIndex = 4;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.del);
            this.Controls.Add(this.redact);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button redact;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button clear;
    }
}

