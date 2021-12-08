using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeGrandRestaurant.Test
{
    public class DebutServiceTest
    {
		[Fact(DisplayName = "ÉTANT DONNE un restaurant ayant 3 tables " +
							"QUAND le service commence " +
							"ALORS elles sont toutes affectées au Maître d'Hôtel")]
		public void CAServeurFranchise()
		{
			// ÉTANT DONNE un restaurant ayant 3 tables
			Restaurant restaurant = new Restaurant();
			List<Table> tables = new List<Table>();
            for (int i = 0; i < 3; i++)
            {
				tables.Add(new Table());
            }
			restaurant.AjouteTable(tables);

			// QUAND le service commence
			restaurant.DébuterService();

			// ALORS elles sont toutes affectées au Maître d'Hôtel
			Assert.Equal(restaurant.maitreHotel.tables, tables);			
		}

		[Fact(DisplayName = "ÉTANT DONNÉ un restaurant ayant 3 tables dont une affectée à un serveur" +
							"QUAND le service débute" +
							"ALORS la table éditée est affectée au serveur et les deux autres au maître d'hôtel")]
		public void AffectationTtablesServeur()
		{
			//ÉTANT DONNÉ un restaurant ayant 3 tables dont une affectée à un serveur
			Restaurant restaurant = new();
			Serveur serveur = new();

			Table table1 = new();
			Table table2 = new();
			Table table3 = new();
			List<Table> tables = new List<Table> { table2, table3 };
			serveur.AjouterTable(table1);
			restaurant.AjouteServeur(serveur);
			restaurant.AjouteTable(tables);

			//QUAND le service débute
			restaurant.DébuterService();

			//ALORS la table éditée est affectée au serveur et les deux autres au maître d'hôtel
			Assert.Contains(table1, restaurant.serveurs[restaurant.serveurs.IndexOf(serveur)].tables);
			tables.ForEach(t =>
			{
				Assert.Contains(t, restaurant.maitreHotel.tables);
			});
		}

		//ÉTANT DONNÉ un restaurant ayant 3 tables dont une affectée à un serveur
		//QUAND le service débute
		//ALORS il n'est pas possible de modifier le serveur affecté à la table

		//ÉTANT DONNÉ un restaurant ayant 3 tables dont une affectée à un serveur
		//ET ayant débuté son service
		//QUAND le service se termine
		//ET qu'une table est affectée à un serveur
		//ALORS la table éditée est affectée au serveur et les deux autres au maître d'hôtel
	}
}
