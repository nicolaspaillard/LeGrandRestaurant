using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant
{
    public class Serveur
    {
        public float chiffreDaffaire { get; set; } = 0;
        public List<Commande> commandes { get; set; } = new List<Commande>();
        public Serveur() { }
           
        public void PrendCommande(Commande commande, Restaurant restaurant, Franchise franchise)
        {
            this.commandes.Add(commande);
            this.chiffreDaffaire += commande.Montant;
            if (commande.IsNourriture)
            {
                restaurant.AjouteCommande(commande, franchise);
            }
            else
            {
                //bar ?
            }
        }
    }
}