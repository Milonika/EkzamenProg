
namespace EkzamenProg
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoanaAmount = new System.Windows.Forms.TextBox();
            this.Days = new System.Windows.Forms.TextBox();
            this.InterestRate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите желаемую сумму:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "На какой срок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Процентная ставка:";
            // 
            // LoanaAmount
            // 
            this.LoanaAmount.Location = new System.Drawing.Point(207, 39);
            this.LoanaAmount.Name = "LoanaAmount";
            this.LoanaAmount.Size = new System.Drawing.Size(100, 20);
            this.LoanaAmount.TabIndex = 4;
            this.LoanaAmount.TextChanged += new System.EventHandler(this.LoanaAmount_TextChanged);
            // 
            // Days
            // 
            this.Days.Location = new System.Drawing.Point(207, 90);
            this.Days.Name = "Days";
            this.Days.Size = new System.Drawing.Size(100, 20);
            this.Days.TabIndex = 5;
            this.Days.TextChanged += new System.EventHandler(this.Days_TextChanged);
            // 
            // InterestRate
            // 
            this.InterestRate.Location = new System.Drawing.Point(207, 139);
            this.InterestRate.Name = "InterestRate";
            this.InterestRate.Size = new System.Drawing.Size(100, 20);
            this.InterestRate.TabIndex = 6;
            this.InterestRate.TextChanged += new System.EventHandler(this.InterestRate_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 304);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InterestRate);
            this.Controls.Add(this.Days);
            this.Controls.Add(this.LoanaAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoanaAmount;
        private System.Windows.Forms.TextBox Days;
        private System.Windows.Forms.TextBox InterestRate;
        private System.Windows.Forms.Button button2;
    }
}

