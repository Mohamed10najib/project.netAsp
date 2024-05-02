using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   abstract class Compte
    {
        public int Numero { get; set; }
        public string Titulaire { get; set; }
        public double solde  { get; set; }
        public  Compte (int  Numeropara   , string Titulairepara  , double  soldepara)
        {
            Numero = Numeropara;
            Titulaire = Titulairepara;
            solde = soldepara;

        }
        public override string ToString()
        {
            return "solde : {solde} , Titulaire :{Titulaire} , Numero = {Numero}  ";
        }
        public abstract void Crediter(double somme);
        public abstract void Debiter(double somme);

    }
}
