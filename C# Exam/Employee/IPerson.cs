using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    interface IPerson
    {

        string getFname();
        void setFname(string Fname);
        string getLname();
        void setLname(string Lname);
    }
}
