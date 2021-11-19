using System.Collections.Generic;

namespace LeGrandRestaurant
{
    public class Restaurant
    {
        public List<Commande> commandes { get; set; } = new List<Commande>();
        public List<Serveur> serveurs { get; set; } = new List<Serveur>();
        public Restaurant(Table table)
        {
        }

        public void DébuterService()
        {
        }

        public bool LaTableEstLibre(Table table)
            => !table.EstOccupée;

        public void AjouteCommande(Commande commande)
        {
            this.commandes.Add(commande);
        }
    }
}
