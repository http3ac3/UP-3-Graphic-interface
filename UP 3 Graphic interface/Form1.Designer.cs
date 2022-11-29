namespace UP_3_Graphic_interface
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
            this.AValueBox = new System.Windows.Forms.TextBox();
            this.BValueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GetTableButton = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите а:";
            // 
            // AValueBox
            // 
            this.AValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AValueBox.Location = new System.Drawing.Point(94, 10);
            this.AValueBox.Name = "AValueBox";
            this.AValueBox.Size = new System.Drawing.Size(100, 23);
            this.AValueBox.TabIndex = 1;
            // 
            // BValueBox
            // 
            this.BValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BValueBox.Location = new System.Drawing.Point(94, 38);
            this.BValueBox.Name = "BValueBox";
            this.BValueBox.Size = new System.Drawing.Size(100, 23);
            this.BValueBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите b:";
            // 
            // GetTableButton
            // 
            this.GetTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetTableButton.Location = new System.Drawing.Point(200, 10);
            this.GetTableButton.Name = "GetTableButton";
            this.GetTableButton.Size = new System.Drawing.Size(158, 51);
            this.GetTableButton.TabIndex = 4;
            this.GetTableButton.Text = "Получить значения функции";
            this.GetTableButton.UseVisualStyleBackColor = true;
            this.GetTableButton.Click += new System.EventHandler(this.GetTableButton_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerBox.Location = new System.Drawing.Point(12, 72);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(346, 132);
            this.AnswerBox.TabIndex = 5;
            this.AnswerBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 216);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.GetTableButton);
            this.Controls.Add(this.BValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AValueBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "3.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AValueBox;
        private System.Windows.Forms.TextBox BValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GetTableButton;
        private System.Windows.Forms.RichTextBox AnswerBox;
    }
}

