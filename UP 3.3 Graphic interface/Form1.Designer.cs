namespace UP_3._3_Graphic_interface
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
            this.HValueBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnswerBox = new System.Windows.Forms.RichTextBox();
            this.GetTableButton = new System.Windows.Forms.Button();
            this.BValueBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HValueBox
            // 
            this.HValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HValueBox.Location = new System.Drawing.Point(97, 63);
            this.HValueBox.Name = "HValueBox";
            this.HValueBox.Size = new System.Drawing.Size(100, 23);
            this.HValueBox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Введите h:";
            // 
            // AnswerBox
            // 
            this.AnswerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerBox.Location = new System.Drawing.Point(15, 105);
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(327, 132);
            this.AnswerBox.TabIndex = 18;
            this.AnswerBox.Text = "";
            // 
            // GetTableButton
            // 
            this.GetTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetTableButton.Location = new System.Drawing.Point(203, 20);
            this.GetTableButton.Name = "GetTableButton";
            this.GetTableButton.Size = new System.Drawing.Size(139, 51);
            this.GetTableButton.TabIndex = 17;
            this.GetTableButton.Text = "Получить таблицу значений";
            this.GetTableButton.UseVisualStyleBackColor = true;
            this.GetTableButton.Click += new System.EventHandler(this.GetTableButton_Click);
            // 
            // BValueBox
            // 
            this.BValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BValueBox.Location = new System.Drawing.Point(97, 34);
            this.BValueBox.Name = "BValueBox";
            this.BValueBox.Size = new System.Drawing.Size(100, 23);
            this.BValueBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Введите b:";
            // 
            // AValueBox
            // 
            this.AValueBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AValueBox.Location = new System.Drawing.Point(97, 6);
            this.AValueBox.Name = "AValueBox";
            this.AValueBox.Size = new System.Drawing.Size(100, 23);
            this.AValueBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите а:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 245);
            this.Controls.Add(this.HValueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnswerBox);
            this.Controls.Add(this.GetTableButton);
            this.Controls.Add(this.BValueBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AValueBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "3.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HValueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox AnswerBox;
        private System.Windows.Forms.Button GetTableButton;
        private System.Windows.Forms.TextBox BValueBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AValueBox;
        private System.Windows.Forms.Label label1;
    }
}

