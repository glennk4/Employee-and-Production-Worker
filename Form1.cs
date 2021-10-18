using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_and_Production_Worker
{
    public partial class Form1 : Form
    {
        private List<ProductionWorker> workerList = new List<ProductionWorker>();
        private const string DAY = "Day Shift";
        private const string NIGHT = "Night Shift"; 


        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string name;
            int number;
            int shiftType;
            decimal hourlyRate;

            if (NameInput.Text.Trim().Length > 0)
            {
                name = NameInput.Text;

                if (int.TryParse(NumberInput.Text, out number))
                {

                    if (ShiftInput.SelectedIndex != -1)
                    {
                        shiftType = int.Parse(ShiftInput.SelectedItem.ToString());

                        if (decimal.TryParse(RateInput.Text, out hourlyRate))
                        {
                            MessageBox.Show("New employee Added");
                            ProductionWorker newWorker = new ProductionWorker(name, number, shiftType, hourlyRate);

                            workerList.Add(newWorker);
                            EmployeeListBox.Items.Add(newWorker.Name);
                            ClearAll();
                        }
                        else
                        {
                            MessageBox.Show("Error. Please enter a numerical value for hourly rate."); 
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a shift type"); 
                    }
                }
                else
                {
                    MessageBox.Show("Error. Please enter a numeric Value"); 
                }

            }

            else
            {
                MessageBox.Show("Error with name");
            }

        }

        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeListBox.SelectedIndex != -1)
            {
                NameOutput.Text = workerList[EmployeeListBox.SelectedIndex].Name;
                NumberOutput.Text = workerList[EmployeeListBox.SelectedIndex].Number.ToString();

                if (workerList[EmployeeListBox.SelectedIndex].ShiftType == 1)
                {
                    ShiftOutput.Text = DAY;
                }
                else
                {
                    ShiftOutput.Text = NIGHT; 
                }

                RateOutput.Text = workerList[EmployeeListBox.SelectedIndex].HourlyRate.ToString("C"); 

            }
        }

        private void ClearAll()
        {
            NameInput.Text = "";
            NumberInput.Text = "";
            ShiftInput.Text = "";
            RateInput.Text = ""; 
            NameInput.Focus(); 
        }


        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
    }
}