namespace зд2
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
            this.ves = new System.Windows.Forms.TextBox();
            this.rost = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите вес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите рост";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ves
            // 
            this.ves.Location = new System.Drawing.Point(138, 62);
            this.ves.Name = "ves";
            this.ves.Size = new System.Drawing.Size(163, 20);
            this.ves.TabIndex = 2;
            this.ves.TextChanged += new System.EventHandler(this.ves_TextChanged);
            // 
            // rost
            // 
            this.rost.Location = new System.Drawing.Point(138, 119);
            this.rost.Name = "rost";
            this.rost.Size = new System.Drawing.Size(163, 20);
            this.rost.TabIndex = 3;
            this.rost.TextChanged += new System.EventHandler(this.rost_TextChanged);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(37, 201);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(80, 35);
            this.OK.TabIndex = 4;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(206, 209);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(227, 20);
            this.result.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.rost);
            this.Controls.Add(this.ves);
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
        private System.Windows.Forms.TextBox ves;
        private System.Windows.Forms.TextBox rost;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox result;
    }
}

