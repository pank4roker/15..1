using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _15._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            /*Write("Enter the number of schoolchilds: ");
            int n = Convert.ToInt32(ReadLine());
            Shool[] shools = new Shool[n];
            for (int i = 0; i < shools.Length; i++)
            {
                Write("Enter name: ");
                string name = ReadLine();
                Write("Enter surname: ");
                string surname = ReadLine();
                Write("Enter gender Male or Female : ");
                string gender = ReadLine();
                Write("Enter year of birth: ");
                int year = Convert.ToInt32(ReadLine());
                shools[i] = new Shool(name,surname,gender,year);
                WriteLine();
            }
            WriteLine($"Number of boys: {Shool.countM}\nNumber of girls: {Shool.countF}\nTotal number: {Shool.count}\n");
            WriteLine("Boys: \n");
            foreach (var shool in shools)
            {
                if (shool.Gender == "Male")
                {
                    shool.ShowInfo();
                }
            }
            WriteLine("Girls: \n");
            foreach (var shool in shools)
            {
                if (shool.Gender == "Female")
                {
                    shool.ShowInfo();
                }
            }*/
            //Task2
            Write("Enter the number of sportsmens: ");
            int n2 = Convert.ToInt32(ReadLine());
            Sportmens[] sportsmens = new Sportmens[n2];
            for (int i = 0; i < sportsmens.Length; i++)
            {
                Write("Enter name: ");
                string name = ReadLine();
                Write("Enter surname: ");
                string surname = ReadLine();
                Write("Enter tall in cm: ");
                int tall = Convert.ToInt32(ReadLine());
                Write("Enter weight in kg: ");
                int weight = Convert.ToInt32(ReadLine());
                sportsmens[i] = new Sportmens(name, surname, tall, weight);
                WriteLine();
            }
            WriteLine($"Total number: {Sportmens.count}\nUnsuitable weight: {Sportmens.countweight}\n");
            Write("Information on all: \n");
            foreach (var sportsmen in sportsmens)
            {
                sportsmen.OutPut();
            }
            ReadKey();
        }
    }
}
