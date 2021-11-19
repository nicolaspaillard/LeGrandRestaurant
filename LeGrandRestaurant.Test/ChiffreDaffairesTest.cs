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
		[Fact(DisplayName = "ÉTANT DONNÉ un restaurant ayant X serveurs QUAND tous les serveurs prennent une commande dun montant Y ALORS le chiffre d'affaires de la franchise est X * Y")]
		public void CAServeurFranchise()
		{
			int CA = 0;
			// ÉTANT DONNÉ un restaurant ayant X serveurs
			List<Serveur> lesServeurs = new List<Serveur>();



		[Fact(DisplayName = "ÉTANT DONNÉ un nouveau serveur " +
					"QUAND il prend une commande " +
					"ALORS son chiffre d'affaires est le montant de celle-ci")]
		public void MiseAJourChiffreDaffaires()
		{
			//ÉTANT DONNÉ un nouveau serveur
			Serveur serveur = new Serveur();

			//QUAND il prend une commande
			Commande commande = new Commande(20, true);
			serveur.PrendCommande(commande, new Restaurant());

			//ALORS son chiffre d'affaires est le montant de celle-ci
			Assert.Equal(commande.Montant, serveur.chiffreDaffaire);
		}
			// QUAND tous les serveurs prennent une commande dun montant Y
			foreach (var serveurCA )
				RecuperationChiffreDaffaires(serveurCA);
			CA = serveurCA + serveurCA;

			// ALORS le chiffre d'affaires de la franchise est X * Y
			Assert.N
		}
		//	ÉTANT DONNÉ un nouveau serveur
		//	QUAND il prend une commande
		//	ALORS son chiffre d'affaires est le montant de celle-ci

		//	ÉTANT DONNÉ un serveur ayant déjà pris une commande
		//	QUAND il prend une nouvelle commande
		//	ALORS son chiffre d'affaires est la somme des deux commandes

		//SCOPE Restaurant
		//	ÉTANT DONNÉ un restaurant ayant X serveurs
		//	QUAND tous les serveurs prennent une commande d'un montant Y
		//	ALORS le chiffre d'affaires de la franchise est X * Y
		//	CAS(X = 0; X = 1; X = 2; X = 100)
		//	CAS(Y = 1.0)

		//SCOPE Franchise
		//	ÉTANT DONNÉ une franchise ayant X restaurants de Y serveurs chacuns
		//	QUAND tous les serveurs prennent une commande d'un montant Z
		//	ALORS le chiffre d'affaires de la franchise est X * Y * Z
		//	CAS(X = 0; X = 1; X = 2; X = 1000)
		//	CAS(Y = 0; Y = 1; Y = 2; Y = 1000)
		//	CAS(Z = 1.0)

	}
}
