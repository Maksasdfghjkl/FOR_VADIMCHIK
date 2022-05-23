using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_17_18_для_делда
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-2,35";
            textBox2.Text = "-2";
            textBox3.Text = "0,05";
            textBox4.Text = "74,2";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Считываем с формы требуемые значения
            double Xmin = double.Parse(textBox1.Text);
            double Xmax = double.Parse(textBox2.Text);
            double Step = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);
            // Количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;
            // Массив значений X – общий для обоих графиков
            double[] x = new double[count];
            // Два массива Y – по одному для каждого графика
            double[] y1 = new double[count];
            // Расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                // Вычисляем значение X
                x[i] = Xmin + Step * i;
                // Вычисляем значение функций в точке X
                y1[i] = 0.00084 * (Math.Log(Math.Pow(Math.Abs(x[i]),5/4)) + b) / (Math.Pow(x[i],2) + 3.82);
            }
            // Настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;
            // Определяем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;
            // Добавляем вычисленные значения в графики
            chart1.Series[0].Points.DataBindXY(x, y1);
        }
    }
}
