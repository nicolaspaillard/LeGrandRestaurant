using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant
{
    public class Franchise
    {
        public float chiffreDaffaires { get; set; } = 0;
        public List<Restaurant> restaurants { get; set; } = new List<Restaurant>();
        public void AjouteCommande(Commande commande)
        {
            this.chiffreDaffaires += commande.Montant;
        }
        public void AjouteRestaurant(Restaurant restaurant)
        {
            this.restaurants.Add(restaurant);
        }
    }
}
