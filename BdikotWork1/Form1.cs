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
            Worker[] workersArray = new Worker[5];
            for (int i = 0; i < 5; i++)
            {
                workersArray[i] = new Worker(i + 1, "worker" + i + 1, "worker" + i + 1, "worker" + 1 + i + "@gmail.com", random.Next(), "House number " + i + random.Next(), random.Next(15000, 300000));
                
            }
            

        }

        private void button1_Click(object sender, EventArgs e )
        {
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
