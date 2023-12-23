
namespace Tyuiu.PolyanskiyDE.Sprint7.Project.V13
{
    partial class FormMain_PDE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxBD_PDE = new System.Windows.Forms.GroupBox();
            this.dataGridViewBD_PDE = new System.Windows.Forms.DataGridView();
            this.iconButtonSave_PDE = new FontAwesome.Sharp.IconButton();
            this.iconButtonHelp_PDE = new FontAwesome.Sharp.IconButton();
            this.groupBoxPanel_PDE = new System.Windows.Forms.GroupBox();
            this.iconButtonSearch_PDE = new FontAwesome.Sharp.IconButton();
            this.labelSearch_PDE = new System.Windows.Forms.Label();
            this.textBoxSearch_PDE = new System.Windows.Forms.TextBox();
            this.iconButtonInfo_PDE = new FontAwesome.Sharp.IconButton();
            this.iconButtonBrowse_PDE = new FontAwesome.Sharp.IconButton();
            this.saveFileDialog_PDE = new System.Windows.Forms.SaveFileDialog();
            this.iconButtonAverage_PDE = new FontAwesome.Sharp.IconButton();
            this.textBoxAverage_PDE = new System.Windows.Forms.TextBox();
            this.labelAverage_PDE = new System.Windows.Forms.Label();
            this.iconButtonGraf_PDE = new FontAwesome.Sharp.IconButton();
            this.chartGraf_PDE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxBD_PDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD_PDE)).BeginInit();
            this.groupBoxPanel_PDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_PDE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBD_PDE
            // 
            this.groupBoxBD_PDE.Controls.Add(this.dataGridViewBD_PDE);
            this.groupBoxBD_PDE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxBD_PDE.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBD_PDE.Name = "groupBoxBD_PDE";
            this.groupBoxBD_PDE.Size = new System.Drawing.Size(579, 314);
            this.groupBoxBD_PDE.TabIndex = 0;
            this.groupBoxBD_PDE.TabStop = false;
            this.groupBoxBD_PDE.Text = "База данных";
            // 
            // dataGridViewBD_PDE
            // 
            this.dataGridViewBD_PDE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBD_PDE.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewBD_PDE.Name = "dataGridViewBD_PDE";
            this.dataGridViewBD_PDE.Size = new System.Drawing.Size(567, 283);
            this.dataGridViewBD_PDE.TabIndex = 0;
            // 
            // iconButtonSave_PDE
            // 
            this.iconButtonSave_PDE.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconButtonSave_PDE.IconColor = System.Drawing.Color.Black;
            this.iconButtonSave_PDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave_PDE.Location = new System.Drawing.Point(6, 25);
            this.iconButtonSave_PDE.Name = "iconButtonSave_PDE";
            this.iconButtonSave_PDE.Size = new System.Drawing.Size(179, 53);
            this.iconButtonSave_PDE.TabIndex = 1;
            this.iconButtonSave_PDE.Text = "Сохранить";
            this.iconButtonSave_PDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave_PDE.UseVisualStyleBackColor = true;
            this.iconButtonSave_PDE.Click += new System.EventHandler(this.iconButtonSave_PDE_Click);
            // 
            // iconButtonHelp_PDE
            // 
            this.iconButtonHelp_PDE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconButtonHelp_PDE.IconChar = FontAwesome.Sharp.IconChar.ClipboardQuestion;
            this.iconButtonHelp_PDE.IconColor = System.Drawing.Color.Black;
            this.iconButtonHelp_PDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonHelp_PDE.Location = new System.Drawing.Point(6, 84);
            this.iconButtonHelp_PDE.Name = "iconButtonHelp_PDE";
            this.iconButtonHelp_PDE.Size = new System.Drawing.Size(179, 53);
            this.iconButtonHelp_PDE.TabIndex = 2;
            this.iconButtonHelp_PDE.Text = "Помощь";
            this.iconButtonHelp_PDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHelp_PDE.UseVisualStyleBackColor = true;
            this.iconButtonHelp_PDE.Click += new System.EventHandler(this.iconButtonHelp_PDE_Click);
            // 
            // groupBoxPanel_PDE
            // 
            this.groupBoxPanel_PDE.Controls.Add(this.iconButtonGraf_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.labelAverage_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.textBoxAverage_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.iconButtonAverage_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.iconButtonSearch_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.labelSearch_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.textBoxSearch_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.iconButtonInfo_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.iconButtonBrowse_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.iconButtonSave_PDE);
            this.groupBoxPanel_PDE.Controls.Add(this.iconButtonHelp_PDE);
            this.groupBoxPanel_PDE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxPanel_PDE.Location = new System.Drawing.Point(597, 12);
            this.groupBoxPanel_PDE.Name = "groupBoxPanel_PDE";
            this.groupBoxPanel_PDE.Size = new System.Drawing.Size(377, 517);
            this.groupBoxPanel_PDE.TabIndex = 3;
            this.groupBoxPanel_PDE.TabStop = false;
            this.groupBoxPanel_PDE.Text = "Панель управления";
            // 
            // iconButtonSearch_PDE
            // 
            this.iconButtonSearch_PDE.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButtonSearch_PDE.IconColor = System.Drawing.Color.Black;
            this.iconButtonSearch_PDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearch_PDE.Location = new System.Drawing.Point(192, 143);
            this.iconButtonSearch_PDE.Name = "iconButtonSearch_PDE";
            this.iconButtonSearch_PDE.Size = new System.Drawing.Size(179, 51);
            this.iconButtonSearch_PDE.TabIndex = 6;
            this.iconButtonSearch_PDE.Text = "Поиск";
            this.iconButtonSearch_PDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSearch_PDE.UseVisualStyleBackColor = true;
            this.iconButtonSearch_PDE.Click += new System.EventHandler(this.iconButtonSearch_PDE_Click);
            // 
            // labelSearch_PDE
            // 
            this.labelSearch_PDE.AutoSize = true;
            this.labelSearch_PDE.Location = new System.Drawing.Point(6, 141);
            this.labelSearch_PDE.Name = "labelSearch_PDE";
            this.labelSearch_PDE.Size = new System.Drawing.Size(54, 21);
            this.labelSearch_PDE.TabIndex = 5;
            this.labelSearch_PDE.Text = "Поиск";
            // 
            // textBoxSearch_PDE
            // 
            this.textBoxSearch_PDE.Location = new System.Drawing.Point(10, 165);
            this.textBoxSearch_PDE.Name = "textBoxSearch_PDE";
            this.textBoxSearch_PDE.Size = new System.Drawing.Size(175, 29);
            this.textBoxSearch_PDE.TabIndex = 4;
            // 
            // iconButtonInfo_PDE
            // 
            this.iconButtonInfo_PDE.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.iconButtonInfo_PDE.IconColor = System.Drawing.Color.Black;
            this.iconButtonInfo_PDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInfo_PDE.Location = new System.Drawing.Point(192, 84);
            this.iconButtonInfo_PDE.Name = "iconButtonInfo_PDE";
            this.iconButtonInfo_PDE.Size = new System.Drawing.Size(179, 53);
            this.iconButtonInfo_PDE.TabIndex = 3;
            this.iconButtonInfo_PDE.Text = "О приложении";
            this.iconButtonInfo_PDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonInfo_PDE.UseVisualStyleBackColor = true;
            this.iconButtonInfo_PDE.Click += new System.EventHandler(this.iconButtonInfo_PDE_Click);
            // 
            // iconButtonBrowse_PDE
            // 
            this.iconButtonBrowse_PDE.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            this.iconButtonBrowse_PDE.IconColor = System.Drawing.Color.Black;
            this.iconButtonBrowse_PDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBrowse_PDE.Location = new System.Drawing.Point(191, 25);
            this.iconButtonBrowse_PDE.Name = "iconButtonBrowse_PDE";
            this.iconButtonBrowse_PDE.Size = new System.Drawing.Size(179, 53);
            this.iconButtonBrowse_PDE.TabIndex = 1;
            this.iconButtonBrowse_PDE.Text = "Открыть файл";
            this.iconButtonBrowse_PDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBrowse_PDE.UseVisualStyleBackColor = true;
            this.iconButtonBrowse_PDE.Click += new System.EventHandler(this.iconButtonBrowse_PDE_Click);
            // 
            // saveFileDialog_PDE
            // 
            this.saveFileDialog_PDE.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // iconButtonAverage_PDE
            // 
            this.iconButtonAverage_PDE.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.iconButtonAverage_PDE.IconColor = System.Drawing.Color.Black;
            this.iconButtonAverage_PDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAverage_PDE.Location = new System.Drawing.Point(192, 200);
            this.iconButtonAverage_PDE.Name = "iconButtonAverage_PDE";
            this.iconButtonAverage_PDE.Size = new System.Drawing.Size(179, 51);
            this.iconButtonAverage_PDE.TabIndex = 7;
            this.iconButtonAverage_PDE.Text = "Ср. значение населения";
            this.iconButtonAverage_PDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAverage_PDE.UseVisualStyleBackColor = true;
            this.iconButtonAverage_PDE.Click += new System.EventHandler(this.iconButtonAverage_PDE_Click);
            // 
            // textBoxAverage_PDE
            // 
            this.textBoxAverage_PDE.Location = new System.Drawing.Point(11, 222);
            this.textBoxAverage_PDE.Name = "textBoxAverage_PDE";
            this.textBoxAverage_PDE.ReadOnly = true;
            this.textBoxAverage_PDE.Size = new System.Drawing.Size(175, 29);
            this.textBoxAverage_PDE.TabIndex = 8;
            // 
            // labelAverage_PDE
            // 
            this.labelAverage_PDE.AutoSize = true;
            this.labelAverage_PDE.Location = new System.Drawing.Point(8, 200);
            this.labelAverage_PDE.Name = "labelAverage_PDE";
            this.labelAverage_PDE.Size = new System.Drawing.Size(145, 21);
            this.labelAverage_PDE.TabIndex = 9;
            this.labelAverage_PDE.Text = "Среднее значение:";
            // 
            // iconButtonGraf_PDE
            // 
            this.iconButtonGraf_PDE.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.iconButtonGraf_PDE.IconColor = System.Drawing.Color.Black;
            this.iconButtonGraf_PDE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonGraf_PDE.Location = new System.Drawing.Point(6, 257);
            this.iconButtonGraf_PDE.Name = "iconButtonGraf_PDE";
            this.iconButtonGraf_PDE.Size = new System.Drawing.Size(365, 51);
            this.iconButtonGraf_PDE.TabIndex = 10;
            this.iconButtonGraf_PDE.Text = "График";
            this.iconButtonGraf_PDE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonGraf_PDE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonGraf_PDE.UseVisualStyleBackColor = true;
            this.iconButtonGraf_PDE.Click += new System.EventHandler(this.iconButtonGraf_PDE_Click);
            // 
            // chartGraf_PDE
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraf_PDE.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraf_PDE.Legends.Add(legend1);
            this.chartGraf_PDE.Location = new System.Drawing.Point(12, 332);
            this.chartGraf_PDE.Name = "chartGraf_PDE";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartGraf_PDE.Series.Add(series1);
            this.chartGraf_PDE.Size = new System.Drawing.Size(579, 197);
            this.chartGraf_PDE.TabIndex = 1;
            // 
            // FormMain_PDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 541);
            this.Controls.Add(this.chartGraf_PDE);
            this.Controls.Add(this.groupBoxPanel_PDE);
            this.Controls.Add(this.groupBoxBD_PDE);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_PDE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт #7 | Проект | Вариант 13 | Полянский Д. Э.";
            this.groupBoxBD_PDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBD_PDE)).EndInit();
            this.groupBoxPanel_PDE.ResumeLayout(false);
            this.groupBoxPanel_PDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraf_PDE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBD_PDE;
        private System.Windows.Forms.DataGridView dataGridViewBD_PDE;
        private FontAwesome.Sharp.IconButton iconButtonSave_PDE;
        private FontAwesome.Sharp.IconButton iconButtonHelp_PDE;
        private System.Windows.Forms.GroupBox groupBoxPanel_PDE;
        private FontAwesome.Sharp.IconButton iconButtonInfo_PDE;
        private FontAwesome.Sharp.IconButton iconButtonBrowse_PDE;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_PDE;
        private System.Windows.Forms.Label labelSearch_PDE;
        private System.Windows.Forms.TextBox textBoxSearch_PDE;
        private FontAwesome.Sharp.IconButton iconButtonSearch_PDE;
        private System.Windows.Forms.Label labelAverage_PDE;
        private System.Windows.Forms.TextBox textBoxAverage_PDE;
        private FontAwesome.Sharp.IconButton iconButtonAverage_PDE;
        private FontAwesome.Sharp.IconButton iconButtonGraf_PDE;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_PDE;
    }
}

