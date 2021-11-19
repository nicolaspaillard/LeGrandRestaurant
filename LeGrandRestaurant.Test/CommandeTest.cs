using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeGrandRestaurant.Test
{
    public class CommandeTest
    {
		[Fact(DisplayName = "ÉTANT DONNE un serveur dans un restaurant " +
					"QUAND il prend une commande de nourriture " +
					"ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant")]
		public void CommandeNourriture()
		{
			//ÉTANT DONNE un serveur dans un restaurant
			Serveur serveur = new Serveur();
			Restaurant restaurant = new Restaurant();
			restaurant.AjouteServeur(serveur);

			//QUAND il prend une commande de nourriture
			Commande commande = new Commande(20, true);
			serveur.PrendCommande(commande, restaurant, new Franchise());

			//ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant
			Assert.Contains<Commande>(commande, restaurant.commandes);
		}

		[Fact(DisplayName = "ÉTANT DONNE un serveur dans un restaurant " +
			"QUAND il prend une commande de boissons " +
			"ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant")]
		public void CommandeBoisson()
		{
			//ÉTANT DONNE un serveur dans un restaurant
			Serveur serveur = new Serveur();
			Restaurant restaurant = new Restaurant();
			restaurant.AjouteServeur(serveur);

			//QUAND il prend une commande de boissons
			Commande commande = new Commande(20, false);
			serveur.PrendCommande(commande, restaurant, new Franchise());

			//ALORS cette commande n'apparaît pas dans la liste de tâches de la cuisine de ce restaurant
			Assert.DoesNotContain<Commande>(commande, restaurant.commandes);
		}
	}
}
