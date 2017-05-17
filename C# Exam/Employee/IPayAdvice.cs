using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Samuel McDonald 
//1400147869

namespace Employee
{
    interface IPayAdvice
    {
        double getHoursWorked();
        void setHoursworked(double hoursWorked);
        double getGrossSalary();
        void setGrossSalary(double grossSalary);
        double getNetSalary();
        void setNetSalary(double netSalary);
        double getNHT();
        void setNHT(double NHT);
        double getNIS();
        void setNIS(double NIS);
        double getEdTax();
        void setEdTax(double edTax);
        double getPAYE();
        void setPAYE(double PAYE);

    }
}
