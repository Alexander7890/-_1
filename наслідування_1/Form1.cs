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
        // Базовий клас Людина
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        // Похідний клас Студент
        public class Student : Person
        {
            public int StudentId { get; set; }
        }

        // Похідний клас Працівник
        public class Employee : Person
        {
            public string Workplace { get; set; }
            public double Salary { get; set; }

            // Розрахунок доходу
            public double CalculateIncome()
            {
                return Salary * 12;
            }
        }
        // Колекції для студентів і працівників
        private List<Student> students = new List<Student>();
        private List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();

            // Додамо деяких студентів і працівників для демонстрації
            students.Add(new Student { Name = "Іван", Age = 20, StudentId = 1 });
            students.Add(new Student { Name = "Марія", Age = 22, StudentId = 2 });

            employees.Add(new Employee { Name = "Петро", Age = 30, Workplace = "Компанія А", Salary = 400 });
            employees.Add(new Employee { Name = "Оксана", Age = 35, Workplace = "Компанія Б", Salary = 6000 });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Очищаємо ListBox перед виведенням
            listBox1.Items.Clear();

            // Виводимо всіх студентів
            foreach (var student in students)
            {
                listBox1.Items.Add($"Студент: {student.Name}, Вік: {student.Age}");
            }

            // Виводимо всіх працівників
            foreach (var employee in employees)
            {
                listBox1.Items.Add($"Працівник: {employee.Name}, Вік: {employee.Age}, Дохід: {employee.CalculateIncome()}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Очищаємо ListBox перед виведенням
            listBox1.Items.Clear();

            // Фільтруємо за доходом
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
}
