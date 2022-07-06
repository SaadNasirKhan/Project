using System;

namespace Q2
{

    class SalarySlip
    {
        protected double baseSal = 1500;
        protected int medical;
        public string designation;
        protected int fuel;
        public double total;
        public int i;
        public int j;




        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }


        public int Medical
        {
            get { return medical; }
            set { medical = value; }
        }

        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public void Total(int medical, int fuel)
        {
            total = medical + fuel + baseSal;
        }

    }

    // Derived class
    class Engineer : SalarySlip
    {

        public double grossengineer()
        {
            //medical = 500;
            //fuel=100;

            Console.WriteLine("Write medical allowance : ");
            i = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Write fuel allowance: ");
            j = Convert.ToInt32(Console.ReadLine());

            this.Total(i, j);
            Console.WriteLine("Gross Salary of an Engineer is: " + total);
            return total;
        }
    }

    class Manager : SalarySlip
    {

        public double grossmanager()
        {
            //medical = 1000;
            //fuel = 250;

            Console.WriteLine("Write medical allowance : ");
            i = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Write fuel allowance: ");
            j = Convert.ToInt32(Console.ReadLine());

            this.Total(i, j);
            Console.WriteLine("Gross Salary of an Manager is: " + total);

            return 0;
        }
    }

    class Analyst : SalarySlip
    {

        public double grossanalyst()
        {
            //medical = 800;
            //fuel = 150;

            Console.WriteLine("Write medical allowance : ");
            i = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Write fuel allowance: ");
            j = Convert.ToInt32(Console.ReadLine());

            this.Total(i, j);
            Console.WriteLine("Gross Salary of an Analyst is: " + total);

            return total;
        }
    }

    class Tester
    {

        static void Main(string[] args)
        {
            Engineer e = new Engineer();
            Manager m = new Manager();
            Analyst a = new Analyst();
            SalarySlip s = new SalarySlip();

            Console.WriteLine("Type your designation: ");
            s.designation = Console.ReadLine();

            if (s.designation == "Engineer")
            {
                e.grossengineer();
            }
            else if (s.designation == "Manager")
            {
                m.grossmanager();
            }
            else if (s.designation == "Analyst")
            {
                a.grossanalyst();
            }
        }
    }
}