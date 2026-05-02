namespace зд5
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
            this.label2 = new System.Windows.Forms.Label();
            this.F = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Массив e";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Массив b";
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(40, 90);
            this.F.Multiline = true;
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(131, 287);
            this.F.TabIndex = 2;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(210, 90);
            this.B.Multiline = true;
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(136, 287);
            this.B.TabIndex = 3;
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(68, 411);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(230, 23);
            this.btn.TabIndex = 4;
            this.btn.Text = "Выполнить";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(691, 142);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(67, 32);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Добавить";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(483, 90);
            this.add.Multiline = true;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(275, 46);
            this.add.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите числа для массива F";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.B);
            this.Controls.Add(this.F);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox F;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Label label3;
    }
}

