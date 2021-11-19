using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant
{
    internal class Commande
    {
        public float Montant { get; set; }
        public bool IsNourriture { get; set; }

        public Commande(float montant, bool isNourriture)
        {
            Montant = montant;
            IsNourriture = isNourriture;
        }
    }
}
