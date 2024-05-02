using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Beep();
            Console.WriteLine("welcome to my new  project ");
            var personne = new { Nom = "John", Age = 30 };
            var etudaint = new { cne = "d13534832", solde = 3992 };
            Class1 a = new Class1();
            a.Affiche(personne.Age);
            Console.ReadLine();
        }
    }
}
