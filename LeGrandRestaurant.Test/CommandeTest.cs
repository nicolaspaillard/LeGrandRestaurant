using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeGrandRestaurant.Test
{
    internal class CommandeTest
    {
		[Fact(DisplayName = "ÉTANT DONNE un serveur dans un restaurant " +
					"QUAND il prend une commande de nourriture " +
					"ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant")]
		public void RecuperationChiffreDaffaires()
		{
			//ÉTANT DONNE un serveur dans un restaurant
			Serveur serveur = new Serveur();

			//QUAND il prend une commande de nourriture
			serveur.PrendCommande(new Commande());

			//ALORS cette commande apparaît dans la liste de tâches de la cuisine de ce restaurant
			Assert.Equal(0, chiffreDaffaires);
		}
		//
		//
		//

		//ÉTANT DONNE un serveur dans un restaurant
		//QUAND il prend une commande de boissons
		//ALORS cette commande n'apparaît pas dans la liste de tâches de la cuisine de ce restaurant
	}
}
