namespace Approximator
{
    partial class ApproxForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ApproxChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CheckBLS = new System.Windows.Forms.CheckBox();
            this.CheckBLagrange = new System.Windows.Forms.CheckBox();
            this.LabelLS = new System.Windows.Forms.Label();
            this.LabelLagrange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApproxChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproxChart
            // 
            this.ApproxChart.Location = new System.Drawing.Point(0, 0);
            this.ApproxChart.Name = "ApproxChart";
            series1.Name = "Series1";
            this.ApproxChart.Series.Add(series1);
            this.ApproxChart.Size = new System.Drawing.Size(825, 482);
            this.ApproxChart.TabIndex = 0;
            this.ApproxChart.Text = "Text";
            this.ApproxChart.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ApproxChart_MouseDoubleClick);
            this.ApproxChart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ApproxChart_MouseDown);
            this.ApproxChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ApproxChart_MouseMove);
            this.ApproxChart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ApproxChart_MouseUp);
            // 
            // BuildButton
            // 
            this.BuildButton.Location = new System.Drawing.Point(835, 377);
            this.BuildButton.Name = "BuildButton";
            this.BuildButton.Size = new System.Drawing.Size(101, 46);
            this.BuildButton.TabIndex = 2;
            this.BuildButton.Text = "Построить график";
            this.BuildButton.UseVisualStyleBackColor = true;
            this.BuildButton.Click += new System.EventHandler(this.BuildButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(835, 429);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(101, 40);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Очистить точки";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CheckBLS
            // 
            this.CheckBLS.AutoSize = true;
            this.CheckBLS.Location = new System.Drawing.Point(831, 12);
            this.CheckBLS.Name = "CheckBLS";
            this.CheckBLS.Size = new System.Drawing.Size(50, 17);
            this.CheckBLS.TabIndex = 4;
            this.CheckBLS.Text = "МНК";
            this.CheckBLS.UseVisualStyleBackColor = true;
            // 
            // CheckBLagrange
            // 
            this.CheckBLagrange.AutoSize = true;
            this.CheckBLagrange.Location = new System.Drawing.Point(831, 64);
            this.CheckBLagrange.Name = "CheckBLagrange";
            this.CheckBLagrange.Size = new System.Drawing.Size(71, 17);
            this.CheckBLagrange.TabIndex = 5;
            this.CheckBLagrange.Text = "Лагранж";
            this.CheckBLagrange.UseVisualStyleBackColor = true;
            // 
            // LabelLS
            // 
            this.LabelLS.AutoSize = true;
            this.LabelLS.Location = new System.Drawing.Point(831, 36);
            this.LabelLS.Name = "LabelLS";
            this.LabelLS.Size = new System.Drawing.Size(0, 13);
            this.LabelLS.TabIndex = 6;
            // 
            // LabelLagrange
            // 
            this.LabelLagrange.AutoSize = true;
            this.LabelLagrange.Location = new System.Drawing.Point(831, 88);
            this.LabelLagrange.Name = "LabelLagrange";
            this.LabelLagrange.Size = new System.Drawing.Size(0, 13);
            this.LabelLagrange.TabIndex = 7;
            // 
            // ApproxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 481);
            this.Controls.Add(this.LabelLagrange);
            this.Controls.Add(this.LabelLS);
            this.Controls.Add(this.CheckBLagrange);
            this.Controls.Add(this.CheckBLS);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.BuildButton);
            this.Controls.Add(this.ApproxChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ApproxForm";
            this.ShowIcon = false;
            this.Text = "Аппроксиматор";
            ((System.ComponentModel.ISupportInitialize)(this.ApproxChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ApproxChart;
        private System.Windows.Forms.Button BuildButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.CheckBox CheckBLS;
        private System.Windows.Forms.CheckBox CheckBLagrange;
        private System.Windows.Forms.Label LabelLS;
        private System.Windows.Forms.Label LabelLagrange;
    }
}

