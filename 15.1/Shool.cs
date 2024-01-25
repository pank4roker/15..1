using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _15._1
{
    /// <summary>
    /// Класс описывающий школьников
    /// </summary>
    class Shool
    {
        /// <summary>
        /// Name
        /// </summary>
        private string name;
        public string Name { get => (name != "" && name != " ") ? name : "Unknown"; set => name = value; }
        /// <summary>
        /// Surname
        /// </summary>
        private string surname;
        public string Surname { get => (surname != "" && surname != " ") ? surname : "Unknown"; set => surname = value; }
        /// <summary>
        /// Gender
        /// </summary>
        private string gender;
        public string Gender { get => gender; set => gender = value; }
        /// <summary>
        /// Year
        /// </summary>
        private int year;
        public int Year { get => year; set => year = value; }
        /// <summary>
        /// Female number
        /// </summary>
        public static int countF;

        /// <summary>
        /// The number of males
        /// </summary>
        public static int countM;

        /// <summary>
        /// Count
        /// </summary>
        public static int count;
       
        /// <summary>
        /// constructor without parameters
        /// </summary>
        public Shool() { }
        /// <summary>
        /// constructor with parameter
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="gender"></param>
        /// <param name="year"></param>
        public Shool(string name, string surname, string gender, int year) 
        { 
            this.name = name; this.surname = surname; this.gender = gender; this.year = year;
            if(gender=="Male")
            {
                countM++;
            }
            else if(gender=="Female")
            {
                countF++;
            }
            count++;
        }
        /// <summary>
        ///  static constructor
        /// </summary>
        static Shool()
        {
            count = 0;
            countF = 0;
            countM = 0;
        }
        public void ShowInfo()
        {
            WriteLine($"Name: {Name}\nSurname: {Surname}\nGender: {Gender}\nYear of birth: {Year}");
        }
        public static void ShowCount()
        {
            WriteLine($"Number of girls: {countF}\nNumber of boys: {countM}\nTotal number: {count}");
        }


    }
}
