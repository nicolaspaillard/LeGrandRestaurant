using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant
{
    public class Serveur
    {
        private int montant = 0;
        public float chiffreDaffaire { get; set; } = 0;
        public List<Commande> commandes { get; set; } = new List<Commande>();
        public Serveur() { }
           
        public void PrendCommande(Commande commande, Restaurant restaurant)
        {
            this.commandes.Add(commande);
            this.chiffreDaffaire += commande.Montant;
            if (commande.IsNourriture)
            {
                restaurant.AjouteCommande(commande);
            }
            else
            {
                //bar ?
            }
        }
    }
}