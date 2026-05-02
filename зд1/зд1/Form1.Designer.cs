namespace зд1
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
            this.be = new System.Windows.Forms.Button();
            this.zk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // be
            // 
            this.be.Location = new System.Drawing.Point(0, 122);
            this.be.Name = "be";
            this.be.Size = new System.Drawing.Size(99, 23);
            this.be.TabIndex = 0;
            this.be.Text = "Вычислить";
            this.be.UseVisualStyleBackColor = true;
            this.be.Click += new System.EventHandler(this.button1_Click);
            // 
            // zk
            // 
            this.zk.Location = new System.Drawing.Point(109, 123);
            this.zk.Name = "zk";
            this.zk.Size = new System.Drawing.Size(102, 22);
            this.zk.TabIndex = 1;
            this.zk.Text = "Закрыть";
            this.zk.UseVisualStyleBackColor = true;
            this.zk.Click += new System.EventHandler(this.zk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название мороженного";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена одной порции";
            // 
            // txt
            // 
            this.txt.ForeColor = System.Drawing.Color.Red;
            this.txt.Location = new System.Drawing.Point(0, 151);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(211, 236);
            this.txt.TabIndex = 4;
            this.txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(8, 97);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(203, 20);
            this.price.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(7, 58);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(204, 20);
            this.name.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 387);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zk);
            this.Controls.Add(this.be);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button be;
        private System.Windows.Forms.Button zk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
    }
}

