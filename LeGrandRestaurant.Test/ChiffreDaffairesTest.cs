using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LeGrandRestaurant.Test
{
    public class ChiffreDaffairesTest
    {
		[Fact(DisplayName = "ÉTANT DONNÉ un nouveau serveur " +
							"QUAND on récupére son chiffre d'affaires " +
							"ALORS celui-ci est à 0")]
		public void RecuperationChiffreNouveauServeur()
		{
			//ÉTANT DONNÉ un nouveau serveur
			Serveur serveur = new Serveur();

			//QUAND on récupére son chiffre d'affaires
			float chiffreDaffaires = serveur.chiffreDaffaire;

			//ALORS celui-ci est à 0
			Assert.Equal(0, chiffreDaffaires);
		}

		[Fact(DisplayName = "ÉTANT DONNÉ un restaurant ayant X serveurs " +
							"QUAND tous les serveurs prennent une commande dun montant Y " +
							"ALORS le chiffre d'affaires de la franchise est X * Y")]
		public void CAServeurFranchise()
		{
			// ÉTANT DONNÉ un restaurant ayant X serveurs
			List<Serveur> lesServeurs = new List<Serveur>();
            for (int i = 0; i < 20; i++)
            {
				lesServeurs.Add(new Serveur());
            }

			// QUAND tous les serveurs prennent une commande dun montant Y
			int montant = 20;
			Commande commande = new Commande(montant, true);
			Franchise franchise = new Franchise();
			foreach (Serveur s in lesServeurs)
			{			
				s.PrendCommande(commande, new Restaurant(), franchise);
			}

			// ALORS le chiffre d'affaires de la franchise est X * Y
			Assert.Equal(lesServeurs.Count * montant, franchise.chiffreDaffaires);
		}

		[Fact(DisplayName = "ÉTANT DONNÉ un nouveau serveur " +
							"QUAND il prend une commande " +
							"ALORS son chiffre d'affaires est le montant de celle-ci")]
		public void CreationChiffreNouveauServeur()
		{
			//ÉTANT DONNÉ un nouveau serveur
			Serveur serveur = new Serveur();

			//QUAND il prend une commande
			Commande commande = new Commande(20, true);
			serveur.PrendCommande(commande, new Restaurant(), new Franchise());

			//ALORS son chiffre d'affaires est le montant de celle-ci
			Assert.Equal(commande.Montant, serveur.chiffreDaffaire);
		}

		[Fact(DisplayName = "ÉTANT DONNÉ un serveur ayant déjà pris une commande " +
					"QUAND il prend une nouvelle commande " +
					"ALORS son chiffre d'affaires est la somme des deux commandes")]
		public void MiseAJourChiffreAncienServeur()
		{
			//ÉTANT DONNÉ un serveur ayant déjà pris une commande
			Serveur serveur = new Serveur();

			//QUAND il prend une nouvelle commande
			Commande commande = new Commande(20, true);
			serveur.PrendCommande(commande, new Restaurant(), new Franchise());

			//ALORS son chiffre d'affaires est la somme des deux commandes
			Assert.Equal(commande.Montant, serveur.chiffreDaffaire);
		}

		[Fact(DisplayName ="ÉTANT DONNÉ une franchise ayant 3 restaurants de 5 serveurs chacuns " +
			"QUAND tous les serveurs prennent une commande d'un montant 10 " +
			"ALORS le chiffre d'affaires de la franchise est X * Y * Z")]
		public void MiseAJourChiffreFranchise()
        {
			//	ÉTANT DONNÉ une franchise ayant 3 restaurants de 5 serveurs chacuns
			Franchise franchise = new Franchise();
            for (int i = 0; i < 4; i++)
            {
				Restaurant leRestaurant = new Restaurant();
                for (int j = 0; j < 5; j++)
                {
					leRestaurant.AjouteServeur(new Serveur());
                }
				franchise.AjouteRestaurant(leRestaurant);
            }

			//	QUAND tous les serveurs prennent une commande d'un montant 10
			Commande commande = new Commande(10, true);
			franchise.restaurants.ForEach(restaurant => restaurant.serveurs.ForEach(s => s.PrendCommande(commande, restaurant, franchise)));

			//	ALORS le chiffre d'affaires de la franchise est X * Y * Z
			Assert.Equal(franchise.chiffreDaffaires,	franchise.restaurants.Count * 
														franchise.restaurants.First().serveurs.Count * 
														franchise.restaurants.First().serveurs.First().commandes.First().Montant);
		}

		[Fact(DisplayName = "ÉTANT DONNÉ une franchise ayant 3 restaurants de 5 serveurs chacuns " +
	"QUAND tous les serveurs prennent une commande d'un montant 10 " +
	"ALORS le chiffre d'affaires de la franchise est X * Y * Z")]
		public void MiseAJourChiffreFranchiseTousRestaurants()
		{
			//	ÉTANT DONNÉ une franchise ayant 3 restaurants de 5 serveurs chacuns
			Franchise franchise = new Franchise();
			for (int i = 0; i < 4; i++)
			{
				Restaurant leRestaurant = new Restaurant();
				for (int j = 0; j < 5; j++)
				{
					leRestaurant.AjouteServeur(new Serveur());
				}
				franchise.AjouteRestaurant(leRestaurant);
			}

			//	QUAND tous les serveurs prennent une commande d'un montant 10
			Commande commande = new Commande(10, true);
			franchise.restaurants.ForEach(restaurant => restaurant.serveurs.ForEach(s => s.PrendCommande(commande, restaurant, franchise)));

			//	ALORS le chiffre d'affaires de la franchise est X * Y * Z
			Assert.Equal(franchise.chiffreDaffaires, franchise.restaurants.Count *
														franchise.restaurants.First().serveurs.Count *
														franchise.restaurants.First().serveurs.First().commandes.First().Montant);
		}
		//SCOPE Restaurant
		//	ÉTANT DONNÉ un restaurant ayant X serveurs
		//	QUAND tous les serveurs prennent une commande d'un montant Y
		//	ALORS le chiffre d'affaires de la franchise est X * Y
		//	CAS(X = 0; X = 1; X = 2; X = 100)
		//	CAS(Y = 1.0)
		[Fact(DisplayName = "ÉTANT DONNÉ un restaurant ayant X serveurs " +
							"QUAND tous les serveurs prennent une commande d'un montant Y " +
							"ALORS le chiffre d'affaires de la franchise est X * Y")]
		public void MiseAJourChiffreFranchiseRestaurant()
		{
			//	ÉTANT DONNÉ un restaurant ayant 5 serveurs
			Restaurant leRestaurant = new Restaurant();
			for (int j = 0; j < 5; j++)
			{
				leRestaurant.AjouteServeur(new Serveur());
			}

			//	QUAND tous les serveurs prennent une commande d'un montant 10
			Commande commande = new Commande(10, true);
			Franchise franchise = new Franchise();
			leRestaurant.serveurs.ForEach(s => s.PrendCommande(commande, leRestaurant, franchise));

			//	ALORS le chiffre d'affaires de la franchise est X * Y
			Assert.Equal(franchise.chiffreDaffaires, leRestaurant.serveurs.Count * commande.Montant);
		}
	}
}
