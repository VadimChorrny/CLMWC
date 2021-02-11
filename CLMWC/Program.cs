using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello in my app!\n\n");
            Console.WriteLine("1.Input Persone");
            Console.WriteLine("2.Input Number");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
                Person();
            else if (action == 2)
                PhoneNumber();
            else
                Console.WriteLine("Error with number ! :D ");

            Console.ReadKey(); // for don't close console
        }

        static void Person()
        {
            Console.Clear();
            Console.WriteLine("Enter name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter surname : ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter age : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("_____OUTPUT_____");
            Console.WriteLine($" Name : {name} \n Surname : {surname} \n Age : {age}");
        }

        static void PhoneNumber()
        {
            Console.Clear();
            int[] numb = new int[8]; // init array
            Console.WriteLine("Enter your number : ");
            for (int i = 0; i < numb.Length; i++)
            {
                Console.Write(" Number : ");
                numb[i] = Int32.Parse(Console.ReadLine());
            }
            Console.Clear();
            Console.WriteLine(" After input ... ");
            for (int i = 0; i < numb.Length; i++)
            {
                Console.WriteLine(numb[i]);
            }
        }
    }
}

//Convert.ToInt32()(преобразует к типу int)

//Convert.ToDouble()(преобразует к типу double)

//Convert.ToDecimal()(преобразует к типу decimal)