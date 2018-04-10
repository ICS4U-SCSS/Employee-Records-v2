using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeeRecords
{
    public partial class mainForm : Form
    {
        List<Employee> employeeDB = new List<Employee>();

        public mainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newID = idInput.Text;
            string newFirstName = fnInput.Text;
            string newLastName = lnInput.Text;
            string newStartDate = dateInput.Text;
            string newSalary = salaryInput.Text;

            Employee newEmployee = new Employee(newID, newFirstName, newLastName, newSalary, newSalary);
            employeeDB.Add(newEmployee);

            ClearLabels();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < employeeDB.Count(); i++)
            {
                if (employeeDB[i].id == idInput.Text)
                {
                    found = true;
                    outputLabel.Text = "Employee " + employeeDB[i].id + " removed";

                    employeeDB.RemoveAt(i);
                }
            }

            if (!found)
            {
                outputLabel.Text = "Employee ID not found";
            }

            ClearLabels();
        }

        private void listButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";

            for (int i = 0; i < employeeDB.Count(); i++)
            {
                outputLabel.Text += employeeDB[i].id + " ";
                outputLabel.Text += employeeDB[i].firstName + " ";
                outputLabel.Text += employeeDB[i].lastName + " ";
                outputLabel.Text += employeeDB[i].date + " ";
                outputLabel.Text += employeeDB[i].salary + "\n";
            }
        }

        private void ClearLabels()
        {
            idInput.Text = "";
            fnInput.Text = "";
            lnInput.Text = "";
            dateInput.Text = "";
            salaryInput.Text = "";
        }
    }
}
