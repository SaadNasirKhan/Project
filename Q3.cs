using System;

namespace Q3
{

    class ElectricBill
    {
        public double units;
        public string TypeBill;

        //public double unit
        //{
         //   get { return units; }
          //  set { units = value; }
        //}

        public string Type
        {
            get { return TypeBill; }
            set { TypeBill = value; }
        }

    }

    // Derived class
    class Resedential : ElectricBill
    {
        public double unit
        {
            get { return units; }
            set { units = value; }
        }
        public double ResidentialBill()
        {
            unit = units;
            if (unit <= 100)
            {
                return unit * 5;
            }

            else if (unit > 100 && unit <= 200)
            {
                return (100 * 5) +
               (unit - 100) * 17;
            }

            else if (unit > 200 && unit <= 500)
            {
                return (100 * 5) +
               (17 * 100) +
               (unit - 300) * 23;
            }

            else if (unit > 500)
            {
                return (100 * 5) +
               (17 * 100) +
               (23 * 400) +
               (unit - 500) * 69;
            }

            return 0;
        }


    }

    class Commercial : ElectricBill
    {
        public double unit
        {
            get { return units; }
            set { units = value; }
        }
        public double CommercialBill()
        {
            unit = units;
            if (unit <= 100)
            {
                return unit * 8;
            }

            else if (unit > 100 && unit <= 200)
            {
                return (100 * 8) +
               (unit - 100) * 21;
            }

            else if (unit > 200 && unit <= 500)
            {
                return (100 * 5) +
               (17 * 100) +
               (unit - 300) * 23;
            }

            else if (unit > 500)
            {
                return (100 * 5) +
               (17 * 100) +
               (23 * 400) +
               (unit - 500) * 79;
            }

            return 0;
        }
    }



    class Tester
    {

        static void Main(string[] args)
        {

            ElectricBill e = new ElectricBill();
            Resedential r = new Resedential();
            Commercial c = new Commercial();
            Console.WriteLine("Are you Resedential or Commercial: ");
            e.Type = Console.ReadLine();


            

            if (e.Type == "Resedential")
            {
                Console.WriteLine("Insert unit: ");
                r.units = Convert.ToInt32(Console.ReadLine());
                r.ResidentialBill();
                Console.WriteLine("Residential Bill is " + r.ResidentialBill());
                double newresidential = r.ResidentialBill() + r.ResidentialBill() * 0.13;
                Console.WriteLine("New Residential Bill is " + newresidential);

            }
            else if (e.Type == "Commercial")
            {
                Console.WriteLine("Insert unit: ");
                c.units = Convert.ToInt32(Console.ReadLine());
                c.CommercialBill();
                Console.WriteLine("Residential Bill is " + c.CommercialBill());
                double newcommercial = c.CommercialBill() + c.CommercialBill() * 0.17;
                Console.WriteLine("New Residential Bill is " + newcommercial);
            }

        }
    }
}
