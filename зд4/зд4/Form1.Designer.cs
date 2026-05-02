namespace зд4
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
            this.label1 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mass = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.txt_sum = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ввод чисел";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(80, 110);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(153, 20);
            this.num.TabIndex = 1;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Массив";
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(567, 96);
            this.mass.Multiline = true;
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(192, 299);
            this.mass.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(133, 163);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 28);
            this.add.TabIndex = 4;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // txt_sum
            // 
            this.txt_sum.Location = new System.Drawing.Point(35, 413);
            this.txt_sum.Name = "txt_sum";
            this.txt_sum.Size = new System.Drawing.Size(460, 20);
            this.txt_sum.TabIndex = 5;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(35, 377);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(90, 30);
            this.sum.TabIndex = 6;
            this.sum.Text = "Сумма";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.txt_sum);
            this.Controls.Add(this.add);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txt_sum;
        private System.Windows.Forms.Button sum;
    }
}

