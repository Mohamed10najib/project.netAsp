using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class CompteSurCarnet : Compte
    {
        public decimal NumeroCanret { get; set; }
        public double Plafond { get; set; }
        public DateTime DateFinValiditeCarte { get; set; }
        public override void Crediter(double somme)
        {
            throw new NotImplementedException();
        }

        public override void Debiter(double somme)
        {
            throw new NotImplementedException();
        }
    }
}
