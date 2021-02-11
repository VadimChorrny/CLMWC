using System;


namespace Job
{

    class Workers
    {

        static string name, surname, profession;
        static int age;
        static void Bio()
        {
            Console.WriteLine("Enter name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter surname : ");
            surname = Console.ReadLine();
            Console.WriteLine("Enter age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter profession : ");
            profession = Console.ReadLine();
        }

        static void print()
        {
            Console.WriteLine("___PRINT___");
            Console.WriteLine($" Name : {name} \n Surname : {surname} \n Age : {age}");
        }
    }
}


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("1.Input Persone");
                Console.WriteLine("2.Input Number");
                Console.WriteLine("3.Info app\n\n");
                Console.WriteLine("Enter action : ");
                int action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                    Person();
                else if (action == 2)
                    PhoneNumber();
                else if (action == 3)
                    info();
                else
                    Console.WriteLine("Error with number ! :D ");

                Console.ReadKey(); // for don't close console
            } while (true);
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

        static void info()
        {
            //Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello in my app!\n\n");
            Console.WriteLine("It's my first project on C# language.\n");
            Console.WriteLine("My program worked for bio workers.\n");
            Console.WriteLine("Thanks!");
            Console.ReadKey();
            Console.Clear();
        }

    }

}

//Convert.ToInt32()(преобразует к типу int)
//Convert.ToDouble()(преобразует к типу double)
//Convert.ToDecimal()(преобразует к типу decimal)