using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpsons
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 15;
            bool isCar = true;
            double myConstant = 4.58;
            float myChangingNum = 2.46f;
            string name = "Karina";


            Console.WriteLine(myNumber);
            Console.WriteLine(isCar);
            Console.WriteLine(myConstant);
            Console.WriteLine(myChangingNum);
            Console.WriteLine(name);

            Console.WriteLine(myConstant + myChangingNum);

            //----------------------------------------

            int myNumber1 = 4;
            int myNumber2 = 6;

            int sum1 = myNumber1 + myNumber2;

            Console.WriteLine(sum1);

            string name1 = "Hell";
            string name2 = "from code";

            string namesTogether = name1 + " " + name2;

            Console.WriteLine(namesTogether);

            int withPluses = 4;
            withPluses++;

            Console.WriteLine(withPluses);



            int myNumber5 = 14;
            int myNumber6 = 17;

            bool isEgualNumber = myNumber5 == myNumber6;

            Console.WriteLine(isEgualNumber);

            int myNumber7 = 15;
            int myNumber8 = 17;

            bool isEgualNumber2 = myNumber7 > myNumber8;

            Console.WriteLine(isEgualNumber2);



            bool iAmTrue = true;
            bool iAmFalse = false;

            bool both = iAmTrue && iAmFalse;
            bool or = iAmTrue || iAmFalse;
            bool bothReversed = !both;

            Console.WriteLine(both);
            Console.WriteLine(or);
            Console.WriteLine(bothReversed);

            //------------------------------

            Console.WriteLine("Kads ir tavs vards ");
            string userName = Console.ReadLine();
            Console.WriteLine("Sveiks," + userName);

            Console.WriteLine("Kāds ir tavs vecums?");

            string ageText = Console.ReadLine();

            int age = int.Parse(ageText);
            int previosYearAge = age - 1;

            Console.WriteLine("Sveiks tev iepriekšējā gadā bija:  " + previosYearAge);

            //-------------------------------------------

            int maxNumber1 = 15;
            int maxNumber2 = 6;

            int maxResult = Math.Max(maxNumber1, maxNumber2);

            Console.WriteLine(maxResult);


            int absWithMinus = -45;
            int absAfter = Math.Abs(absWithMinus);

            Console.WriteLine(absAfter);


            double numberToRound = 14.258;

            double rounded = Math.Round(numberToRound, 2);

            Console.WriteLine(rounded);

            //------------------------------

        }



    }
    

}
