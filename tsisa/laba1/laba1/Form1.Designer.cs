namespace laba1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbOpt2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOpt1 = new System.Windows.Forms.TextBox();
            this.tbAdequacy2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAdequacy1 = new System.Windows.Forms.TextBox();
            this.tbValueBefore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbValueAfter = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1149, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnLoadData);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.tbOpt2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbOpt1);
            this.tabPage1.Controls.Add(this.tbAdequacy2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbAdequacy1);
            this.tabPage1.Controls.Add(this.tbValueBefore);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbValueAfter);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1141, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Исходные данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLoadData
            // 
            this.btnLoadData.Location = new System.Drawing.Point(49, 22);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(195, 37);
            this.btnLoadData.TabIndex = 1;
            this.btnLoadData.Text = "Загрузить мой вариант";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(214, 315);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(289, 63);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbOpt2
            // 
            this.tbOpt2.Location = new System.Drawing.Point(506, 149);
            this.tbOpt2.Name = "tbOpt2";
            this.tbOpt2.Size = new System.Drawing.Size(100, 22);
            this.tbOpt2.TabIndex = 8;
            this.tbOpt2.Text = "y2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Оптимальные значения характеристик";
            // 
            // tbOpt1
            // 
            this.tbOpt1.Location = new System.Drawing.Point(506, 110);
            this.tbOpt1.Name = "tbOpt1";
            this.tbOpt1.Size = new System.Drawing.Size(100, 22);
            this.tbOpt1.TabIndex = 6;
            this.tbOpt1.Text = "y1";
            // 
            // tbAdequacy2
            // 
            this.tbAdequacy2.Location = new System.Drawing.Point(266, 149);
            this.tbAdequacy2.Name = "tbAdequacy2";
            this.tbAdequacy2.Size = new System.Drawing.Size(100, 22);
            this.tbAdequacy2.TabIndex = 5;
            this.tbAdequacy2.Text = "y2";
            this.tbAdequacy2.Enter += new System.EventHandler(this.tbAdequacy2_Enter);
            this.tbAdequacy2.Leave += new System.EventHandler(this.tbAdequacy2_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Границы области адекватности";
            // 
            // tbAdequacy1
            // 
            this.tbAdequacy1.Location = new System.Drawing.Point(266, 110);
            this.tbAdequacy1.Name = "tbAdequacy1";
            this.tbAdequacy1.Size = new System.Drawing.Size(100, 22);
            this.tbAdequacy1.TabIndex = 3;
            this.tbAdequacy1.Text = "y1";
            this.tbAdequacy1.Enter += new System.EventHandler(this.tbAdequacy1_Enter);
            this.tbAdequacy1.Leave += new System.EventHandler(this.tbAdequacy1_Leave);
            // 
            // tbValueBefore
            // 
            this.tbValueBefore.Location = new System.Drawing.Point(49, 149);
            this.tbValueBefore.Name = "tbValueBefore";
            this.tbValueBefore.Size = new System.Drawing.Size(100, 22);
            this.tbValueBefore.TabIndex = 2;
            this.tbValueBefore.Text = "y2";
            this.tbValueBefore.Enter += new System.EventHandler(this.tbValue2_Enter);
            this.tbValueBefore.Leave += new System.EventHandler(this.tbValue2_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Характеристики системы";
            // 
            // tbValueAfter
            // 
            this.tbValueAfter.Location = new System.Drawing.Point(49, 110);
            this.tbValueAfter.Name = "tbValueAfter";
            this.tbValueAfter.Size = new System.Drawing.Size(100, 22);
            this.tbValueAfter.TabIndex = 0;
            this.tbValueAfter.Text = "y1";
            this.tbValueAfter.Enter += new System.EventHandler(this.tbValue1_Enter);
            this.tbValueAfter.Leave += new System.EventHandler(this.tbValue1_Leave);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1141, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Результат";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 15);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.LegendText = "Превосходная система";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.MarkerSize = 15;
            series1.Name = "perfectPoint";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.LegendText = "Оптимальная система";
            series2.MarkerColor = System.Drawing.Color.DodgerBlue;
            series2.MarkerSize = 15;
            series2.Name = "OptimaPoint";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.LegendText = "Пригодная система";
            series3.MarkerColor = System.Drawing.Color.LimeGreen;
            series3.MarkerSize = 15;
            series3.Name = "adequacyPoint";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Legend = "Legend1";
            series4.LegendText = "Непригодная система";
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerSize = 15;
            series4.Name = "nonAdequacyPoint";
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.BorderWidth = 6;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.LabelBorderWidth = 6;
            series5.Legend = "Legend1";
            series5.LegendText = "Границы адекватности";
            series5.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.MarkerSize = 10;
            series5.Name = "adequacy1";
            series6.BorderWidth = 6;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.IsVisibleInLegend = false;
            series6.LabelBorderWidth = 6;
            series6.Legend = "Legend1";
            series6.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series6.Name = "adequacy2";
            series7.BorderWidth = 6;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series7.IsVisibleInLegend = false;
            series7.LabelBorderWidth = 6;
            series7.Legend = "Legend1";
            series7.Name = "adequacy3";
            series8.BorderWidth = 6;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series8.IsVisibleInLegend = false;
            series8.LabelBorderWidth = 6;
            series8.Legend = "Legend1";
            series8.Name = "adequacy4";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.LegendText = "Границы оптимальности";
            series9.Name = "Series9";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Blue;
            series10.IsVisibleInLegend = false;
            series10.Legend = "Legend1";
            series10.Name = "Series10";
            series11.BorderWidth = 2;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Blue;
            series11.IsVisibleInLegend = false;
            series11.Legend = "Legend1";
            series11.Name = "Series11";
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Blue;
            series12.IsVisibleInLegend = false;
            series12.Legend = "Legend1";
            series12.Name = "Series12";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(1021, 559);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 666);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа 1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbValueBefore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbValueAfter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox tbAdequacy2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAdequacy1;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbOpt2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOpt1;
    }
}

