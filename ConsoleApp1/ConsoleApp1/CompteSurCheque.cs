using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CompteSurCheque : Compte
    {
        public decimal Numerocheque { get; set; }
        public decimal NumeroCarte{ get; set; }
        public DateTime DateFinValiditeCarte { get; set; }

        public CompteSurCheque(decimal numerocheque, decimal numeroCarte, DateTime dateFinValiditeCarte, int Numeropara, string Titulairepara, double soldepara):base(Numeropara,Titulairepara,soldepara)
        {
           
            Numerocheque = numerocheque;
            NumeroCarte = numeroCarte;
            DateFinValiditeCarte = dateFinValiditeCarte;
        }

        public override void Crediter(double somme)
        {
            solde += somme;
        }

        public override void Debiter(double somme)
        {
            if (somme > solde)
            {

                throw new Exception("solde > somme");
            }
            solde -= somme;
        }
    }
}
