using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace BdikotWork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
            
          
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int SIZE = 5; 
            Worker[] workersArray = new Worker[SIZE];
            for (int i = 0; i < SIZE; i++)
            {

                workersArray[i] = new Worker(i + 1, "worker" + i + 1, "worker" + i + 1, "worker" + 1 + i + "@gmail.com", random.Next(), "House number " + i + random.Next(), random.Next(15000, 300000));

                //checking input for 5 workers
                //MessageBox.Show("Worker number " + i + 1 + "Information:\n " + "ID: " + workersArray[i].ID + " Private Name: " + workersArray[i].PName + "Surname: " + workersArray[i].SName + "Email: " + workersArray[i].EMail + "Phone: " + workersArray[i].Phone + "Adress: " + workersArray[i].Adress + "Salary: " + workersArray[i].Salary);


                

            }
            //PRINT SALARIES BEFORE BABBLE SORT

            //string CheckArray = "The salaries are: \n";
            //for (int i = 0; i < SIZE; i++)
            //{
            //    CheckArray += " " + workersArray[i].Salary + ", ";
            //}
            //MessageBox.Show(CheckArray);

            // System.currentTimeMillis() - To mesure time
            //Babble Sort
                
                
                for (int i = workersArray.Length - 1; i > 0; i--)
                {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (workersArray[j].Salary > workersArray[j + 1].Salary)
                    {
                        Worker highValue = workersArray[j];

                        workersArray[j] = workersArray[j + 1];
                        workersArray[j + 1] = highValue;
                    }
                }
                }

            //PRINT SALARIES AFTER BABBLE SORT

            //string AfterCheck = "The salaries are: \n";
            //for (int i = 0; i < SIZE; i++)
            //{
            //    AfterCheck += " " + workersArray[i].Salary + ", ";
            //}
            //MessageBox.Show(AfterCheck);

        }

        private void button1_Click(object sender, EventArgs e )
        {
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
