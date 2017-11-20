using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BdikotWork1
{
    class Worker
    {
        public long ID;
        public string PName;
        public string SName;
        public string EMail;
        public long Phone;
        public string Adress;
        public long Salary;

        public Worker()
        {

        }

        public Worker(long id , string pname, string sname , string email, long phone , string adress, long salary)
        {
            this.ID = id;
            this.PName = pname;
            this.SName = sname;
            this.EMail = email;
            this.Phone = phone;
            this.Adress = adress;
            this.Salary = salary;
        }

        
    }
}
