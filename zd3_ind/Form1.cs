using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zd3_ind
{
    public partial class Form1 : Form
    {
        private List<Car> cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
            cars.Add(new Car(130000, 0.08, "BMW"));
            cars.Add(new CarYear(170000, 0.1, "Honda", 2025));
        }

        private void button1_Click(object sender, EventArgs e)//добавить
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                if (Validation.CarNull(textBox1.Text) == string.Empty && Validation.CarNull(textBox2.Text) == string.Empty && Validation.CarNull(textBox3.Text) == string.Empty)
                {
                    if (Validation.TolkoNum(textBox1.Text) == string.Empty && Validation.TolkoNum(textBox2.Text) == string.Empty && Validation.TolkoBukv(textBox3.Text) == string.Empty)
                    {
                        cars.Add(new Car(double.Parse(textBox1.Text), double.Parse(textBox2.Text), textBox3.Text));
                    }
                    else
                    {
                        MessageBox.Show("Неправильный ввод данных", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Поля пустые, заполните их", "Ошибка");
                }
            }
            else
            {
                if (Validation.CarNull(textBox1.Text) == string.Empty)
                {
                    if (Validation.TolkoNum(textBox1.Text) == string.Empty && Validation.TolkoNum(textBox2.Text) == string.Empty && Validation.TolkoBukv(textBox3.Text) == string.Empty && Validation.TolkoNum(textBox4.Text) == string.Empty)
                    {
                        cars.Add(new CarYear(double.Parse(textBox1.Text), double.Parse(textBox2.Text), textBox3.Text, int.Parse(textBox4.Text)));
                    }
                    else
                    {
                        MessageBox.Show("Неправильный ввод данных", "Ошибка");
                    }
                }
                else
                {
                    MessageBox.Show("Поля пустые, заполните их", "Ошибка");
                }
            }
            UpdateList();
        }

        private void button2_Click(object sender, EventArgs e)//удалить
        {
            if(listBox1.SelectedIndex != -1)
            {
                cars.RemoveAt(listBox1.SelectedIndex);
            }
            UpdateList();
        }
        private void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (var car in cars)
            {
                listBox1.Items.Add(car.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)//вывести
        {
            UpdateList();
        }
    }
}
