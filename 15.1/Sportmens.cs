using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace _15._1
{   /// <summary>
    /// Класс описывающий спорсменов
    /// </summary>
    class Sportmens
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
        /// height
        /// </summary>
        private int height;
        public int Height { get => height; set => height = value; }
        /// <summary>
        /// weight
        /// </summary>
        private int weight;
        public int Weight { get => weight; set => weight = value; }
        /// <summary>
        /// countweight
        /// </summary>
        public static int countweight;
        /// <summary>
        /// Count
        /// </summary>
        public static int count;
        /// <summary>
        /// constructor without parameters
        /// </summary>
        public Sportmens() { }
        /// <summary>
        /// constructor with parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        public Sportmens(string name,  string surname,  int height, int weight)
        {
            this.name = name;this.surname = surname;this.height = height; this.weight = weight;
            if (weight > 70)
                countweight++;
            count++;
        }
        /// <summary>
        /// static constructor
        /// </summary>
        static Sportmens()
        {
            count = 0;
            countweight = 0;
        }
        public void OutPut()
        {
            Write($"Name: {Name}\nSurname: {Surname}\nHeight: {Height}\n Weight: {Weight}\n");
        }
        public static void StOutput()
        {
            Write($"Unsuitable weight: {countweight}\nTotal number: {count}\n");
        }
    }
}
