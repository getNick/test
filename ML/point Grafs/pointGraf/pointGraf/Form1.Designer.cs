namespace pointGraf
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
            this.function = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.TextBox();
            this.before = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.countPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(451, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(121, 35);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(247, 22);
            this.function.TabIndex = 2;
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(38, 110);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(100, 22);
            this.from.TabIndex = 3;
            this.from.Text = "-10";
            // 
            // before
            // 
            this.before.Location = new System.Drawing.Point(171, 110);
            this.before.Name = "before";
            this.before.Size = new System.Drawing.Size(100, 22);
            this.before.TabIndex = 4;
            this.before.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Интервал от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(176, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(65, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "y(x)=";
            // 
            // countPoint
            // 
            this.countPoint.Location = new System.Drawing.Point(287, 110);
            this.countPoint.Name = "countPoint";
            this.countPoint.Size = new System.Drawing.Size(100, 22);
            this.countPoint.TabIndex = 4;
            this.countPoint.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(266, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество точек";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 190);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.before);
            this.Controls.Add(this.from);
            this.Controls.Add(this.function);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Отрисовка графиков";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox before;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox countPoint;
        private System.Windows.Forms.Label label4;
    }
}

