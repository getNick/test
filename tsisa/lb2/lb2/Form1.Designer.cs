namespace lb2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnRandomValue = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCountExp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCountObj = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCountObj2 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(979, 373);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Location = new System.Drawing.Point(825, 434);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(141, 47);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(983, 516);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.btnRandomValue);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbCountExp);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbCountObj);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(975, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Метод ранжирования";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Спирмена",
            "Конкордации"});
            this.comboBox1.Location = new System.Drawing.Point(24, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(240, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "выберите метод для рассчетов";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnRandomValue
            // 
            this.btnRandomValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomValue.Location = new System.Drawing.Point(625, 434);
            this.btnRandomValue.Name = "btnRandomValue";
            this.btnRandomValue.Size = new System.Drawing.Size(179, 47);
            this.btnRandomValue.TabIndex = 4;
            this.btnRandomValue.Text = "Заполнить данными и рассчитать";
            this.btnRandomValue.UseVisualStyleBackColor = true;
            this.btnRandomValue.Click += new System.EventHandler(this.btnRandomValue_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(485, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Количество экспертов";
            // 
            // tbCountExp
            // 
            this.tbCountExp.Location = new System.Drawing.Point(485, 24);
            this.tbCountExp.MaxLength = 3;
            this.tbCountExp.Name = "tbCountExp";
            this.tbCountExp.Size = new System.Drawing.Size(152, 22);
            this.tbCountExp.TabIndex = 4;
            this.tbCountExp.TextChanged += new System.EventHandler(this.tbCountObj_TextChanged);
            this.tbCountExp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressDigit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество объектов";
            // 
            // tbCountObj
            // 
            this.tbCountObj.Location = new System.Drawing.Point(294, 24);
            this.tbCountObj.MaxLength = 3;
            this.tbCountObj.Name = "tbCountObj";
            this.tbCountObj.Size = new System.Drawing.Size(152, 22);
            this.tbCountObj.TabIndex = 2;
            this.tbCountObj.TextChanged += new System.EventHandler(this.tbCountObj_TextChanged);
            this.tbCountObj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressDigit);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbCountObj2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(975, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Метод парного сравнения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(625, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Заполнить данными и рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox2.Location = new System.Drawing.Point(317, 437);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(288, 44);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 437);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(288, 44);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(823, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 47);
            this.button2.TabIndex = 6;
            this.button2.Text = "Рассчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-10, -88);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Количество объектов";
            // 
            // tbCountObj2
            // 
            this.tbCountObj2.Location = new System.Drawing.Point(6, 24);
            this.tbCountObj2.MaxLength = 3;
            this.tbCountObj2.Name = "tbCountObj2";
            this.tbCountObj2.Size = new System.Drawing.Size(152, 22);
            this.tbCountObj2.TabIndex = 4;
            this.tbCountObj2.TextChanged += new System.EventHandler(this.tbCountObj2_TextChanged);
            this.tbCountObj2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pressDigit);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.Location = new System.Drawing.Point(0, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 5;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(975, 376);
            this.dataGridView2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(823, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "Коррекстировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRandomValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCountObj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCountExp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCountObj2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}

