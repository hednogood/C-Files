using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Samuel McDonald 
//1400147869

namespace Employee
{
    public abstract class EmployeeDetail: IPerson, IPayAdvice
    {
        public abstract string getFname();
        public abstract void setFname(string Fname);
        public abstract string getLname();
        public abstract void setLname(string Lname);
        public abstract double getHoursWorked();
        public abstract void setHoursworked(double hoursWorked);
        public abstract double getGrossSalary();
        public abstract void setGrossSalary(double grossSalary);
        public abstract double getNetSalary();
        public abstract void setNetSalary(double netSalary);
        public abstract double getNHT();
        public abstract void setNHT(double NHT);
        public abstract double getNIS();
        public abstract void setNIS(double NIS);
        public abstract double getEdTax();
        public abstract void setEdTax(double edTax);
        public abstract double getPAYE();
        public abstract void setPAYE(double PAYE);
    }
    public class EmployeeRawData : EmployeeDetail
    {
        //-------------Employee Raw Data-----------------//
        string title;
        string Fname;
        string Lname;
        double hoursWorked = 0.0;
        double grossSalary = 0.0;
        double netSalary = 0.0;
        double NHT = 0.0;
        double NIS = 0.0;
        double edTax = 0.0;
        double PAYE = 0.0;
        double totalDed = 0.0;
        double hourRate = 0.0;
        double fulltime;
        string status;


        public override string getFname()
        {
            return this.Fname;
        }
        public override void setFname(string Fname)
        {
            this.Fname = Fname;
        }
        public override string getLname()
        {
            return this.Lname;
        }
        public override void setLname(string Lname)
        {
            this.Lname = Lname;
        }
        public override double getHoursWorked()
        {
            return hoursWorked;
        }
        public override void setHoursworked(double hoursWorked)
        {
            this.hoursWorked = hoursWorked;
        }
        public override double getGrossSalary()
        {
            return this.grossSalary;
        }
        public override void setGrossSalary(double grossSalary)
        {
            this.grossSalary = grossSalary;
        }
        public override double getNetSalary()
        {
            return this.grossSalary;
        }
        public override void setNetSalary(double netSalary)
        {
            this.netSalary = netSalary;
        }
        public override double getNHT()
        {
            return this.NHT;
        }
        public override void setNHT(double NHT)
        {
            this.NHT = NHT;
        }
        public override double getNIS()
        {
            return this.NIS;
        }
        public override void setNIS(double NIS)
        {
            this.NIS = NIS;
        }
        public override double getEdTax()
        {
            return this.edTax;
        }
        public override void setEdTax(double edTax)
        {
            this.edTax = edTax;
        }
        public override double getPAYE()
        {
            return this.PAYE;
        }
        public override void setPAYE(double PAYE)
        {
            this.PAYE = PAYE;
        }
       public string getTitle()
        {
            return this.title;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getStatus()
        {
            return this.status;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }

  
        public string EmTitle
        {
            set { this.EmTitle = value; }
            get { return this.EmTitle; }
        }


     

        public void CalculateCost()
        {
            if (status == "Full time")
            {
                hourRate = 200000.00;
            }
            if(status == "Part time")
            {
                hourRate = 4000.98 * hoursWorked;
            }
            grossSalary = hourRate;
            setGrossSalary(grossSalary);
            NHT = grossSalary * 0.02;
            NIS = grossSalary * 0.025;
            edTax = grossSalary * 0.0225;
            PAYE = grossSalary * 0.25;
            totalDed = NHT + NIS + edTax + PAYE;
            netSalary = grossSalary - totalDed;


        }
       
        public double nht
        {
            get { return this.NHT; }
        }
        public double nis
        {
            get { return this.NIS; }
        }
        public double edtax
        {
            get { return this.edTax; }
        }
        public double paye
        {
            get { return this.PAYE; }
        }
        public double FULLTIMEGROSS
        {
            get { return this.fulltime; }
        }
        public double HOURLYRATE
        {
            get { return this.hourRate; }
        }
        public double totalDeduction
        {
            get { return this.totalDed; }
        }





    }
}
