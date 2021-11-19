using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant
{
    public class Commande
    {
        public float Montant { get; } = 0;
        public bool IsNourriture { get; } = false;

        public Commande(float montant, bool isNourriture)
        {
            Montant = montant;
            IsNourriture = isNourriture;
        }
    }
}
