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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "-1,23";
            textBox2.Text = "2,4";
            textBox3.Text = "0,3";
            textBox4.Text = "-12,6";
        }

        private void button2_Click(object sender, EventArgs e)
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
                y1[i] = (15.28 * Math.Pow(Math.Abs(x[i]), -3 / 2)) + (Math.Cos(Math.Log(Math.Abs(x[i])) + b));
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
