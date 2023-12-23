using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.PolyanskiyDE.Sprint7.Project.V13.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint7.Project.V13
{
    public partial class FormMain_PDE : Form
    {
        public FormMain_PDE()
        {
            InitializeComponent();
        }

        

        private DataTable ReadCSVFile(string pathToCsvFile)
        {
            //создаём таблицу
            DataTable dt = new DataTable("countries");
            //создаём колонки
            DataColumn country;
            country = new DataColumn("Страна", typeof(String));
            DataColumn capital;
            capital = new DataColumn("Столица", typeof(String));
            DataColumn population;
            population = new DataColumn("Население(млн)", typeof(Int32));
            DataColumn square;
            square = new DataColumn("Площадь(км^2)", typeof(Int32));
            DataColumn currency;
            currency = new DataColumn("Валюта", typeof(String));
            DataColumn nationality;
            nationality = new DataColumn("Национальность");

            //добавляем колонки в таблицу
            dt.Columns.AddRange(new DataColumn[] {country, capital, population, square, currency, nationality });
            try
            {
                DataRow dr = null;
                string[] value = null;
                string[] countries = File.ReadAllLines(pathToCsvFile);
                for (int i = 0; i < countries.Length; i++)
                {
                    if (!String.IsNullOrEmpty(countries[i]))
                    {
                        value = countries[i].Split(',');
                        //создаём новую строку
                        dr = dt.NewRow();
                        dr["Страна"] = value[0];
                        dr["Столица"] = value[1];
                        dr["Население(млн)"] = Int32.Parse(value[2]);
                        dr["Площадь(км^2)"] = Int32.Parse(value[3]);
                        dr["Валюта"] = (value[4]);
                        dr["Национальность"] = (value[5]);
                        //добавляем строку в таблицу
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private void iconButtonBrowse_PDE_Click(object sender, EventArgs e)
        {
            dataGridViewBD_PDE.DataSource = ReadCSVFile($@"{Directory.GetCurrentDirectory()}\DataBase.csv");
        }

        private void iconButtonSave_PDE_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog_PDE.FileName = "DataBase.csv";
                saveFileDialog_PDE.InitialDirectory = @":C";
                if (saveFileDialog_PDE.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialog_PDE.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewBD_PDE.RowCount;
                    int columns = dataGridViewBD_PDE.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewBD_PDE.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(",");
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void iconButtonInfo_PDE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void iconButtonHelp_PDE_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();
        }

        private void iconButtonSearch_PDE_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridViewBD_PDE.RowCount; i++)
            {
                dataGridViewBD_PDE.Rows[i].Selected = false;
                for (int j = 0; j < dataGridViewBD_PDE.ColumnCount; j++)
                    if (dataGridViewBD_PDE.Rows[i].Cells[j].Value != null)
                        if (dataGridViewBD_PDE.Rows[i].Cells[j].Value.ToString().Contains(textBoxSearch_PDE.Text))
                        {
                            dataGridViewBD_PDE.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        

        private void iconButtonAverage_PDE_Click(object sender, EventArgs e)
        {
            int c = 0;
            for (int i = 0; i < dataGridViewBD_PDE.Rows.Count; i++)
            {
                c += Convert.ToInt32(dataGridViewBD_PDE.Rows[i].Cells[2].Value);
            }
            int rows = dataGridViewBD_PDE.Rows.Count - 1;
            double avg = c / rows;
            avg = Math.Round(avg, 2);
            textBoxAverage_PDE.Text = avg.ToString();
        }

        private void iconButtonGraf_PDE_Click(object sender, EventArgs e)
        {
            chartGraf_PDE.Series[0].Points.Clear();

            foreach (DataGridViewRow row in dataGridViewBD_PDE.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    string xValue = row.Cells[0].Value.ToString();
                    double yValue = Convert.ToDouble(row.Cells[2].Value);

                    chartGraf_PDE.Series["Series1"].Points.AddXY(xValue, yValue);
                }
            }
        }
    }

}
