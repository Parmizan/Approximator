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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.ApproxChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BuildButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CheckBLS = new System.Windows.Forms.CheckBox();
            this.CheckBLagrange = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ApproxChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ApproxChart
            // 
            legend1.Name = "Legend1";
            this.ApproxChart.Legends.Add(legend1);
            this.ApproxChart.Location = new System.Drawing.Point(0, 0);
            this.ApproxChart.Name = "ApproxChart";
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
            this.ClearButton.Text = "Очистить";
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
            this.CheckBLagrange.Location = new System.Drawing.Point(831, 35);
            this.CheckBLagrange.Name = "CheckBLagrange";
            this.CheckBLagrange.Size = new System.Drawing.Size(71, 17);
            this.CheckBLagrange.TabIndex = 5;
            this.CheckBLagrange.Text = "Лагранж";
            this.CheckBLagrange.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // ApproxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 481);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
    }
}

