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
        public Restaurant()
        {
        }
        public void DébuterService()
        {
        }

        public bool LaTableEstLibre(Table table)
            => !table.EstOccupée;
        public void AjouteServeur(Serveur serveur)
        {
            this.serveurs.Add(serveur);
        }
        public void AjouteCommande(Commande commande)
        {
            this.commandes.Add(commande);
        }
        public void AfficheCommandes()
        {
            this.commandes.ForEach(commande => System.Console.WriteLine(commande));
        }
    }
}
