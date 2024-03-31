using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace наслідування_1
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            students.Add(new Student { Name = "Іван", Age = 20, StudentId = 1 });
            students.Add(new Student { Name = "Марія", Age = 22, StudentId = 2 });

            employees.Add(new Employee { Name = "Петро", Age = 30, Workplace = "Компанія А", Salary = 400 });
            employees.Add(new Employee { Name = "Оксана", Age = 35, Workplace = "Компанія Б", Salary = 6000 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var student in students)
            {
                listBox1.Items.Add($"Студент: {student.Name}, Вік: {student.Age}");
            }

            foreach (var employee in employees)
            {
                listBox1.Items.Add($"Працівник: {employee.Name}, Вік: {employee.Age}, Дохід: {employee.CalculateIncome()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            double maxIncome = 5000;
            foreach (var employee in employees)
            {
                if (employee.CalculateIncome() < maxIncome)
                {
                    listBox1.Items.Add($"Працівник: {employee.Name}, Вік: {employee.Age}, Дохід: {employee.CalculateIncome()}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int maxAge = 25;
            foreach (var student in students)
            {
                if (student.Age < maxAge)
                {
                    listBox1.Items.Add($"Студент: {student.Name}, Вік: {student.Age}");
                }
            }

            foreach (var employee in employees)
            {
                if (employee.Age < maxAge)
                {
                    listBox1.Items.Add($"Працівник: {employee.Name}, Вік: {employee.Age}, Дохід: {employee.CalculateIncome()}");
                }
            }
        }
    }
}
