using System;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstWeight = 0;
            int SecondWeight = 0;
            string myName ="";
            string yourName ="";

            Console.Write("Enter my Name -");
            myName = Console.ReadLine();

            Console.Write("Enter your Name -");
            yourName = Console.ReadLine();
            

            Console.Write("Please enter the first Weight: ");
            FirstWeight = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second Weight: ");
            SecondWeight = int.Parse(Console.ReadLine());

            Console.WriteLine(" My Weight is " + FirstWeight+ " and my sister Weight is " + SecondWeight);


      Console.WriteLine("My Name is" + myName+ " and your name is" + yourName);      
        }
    }
}
