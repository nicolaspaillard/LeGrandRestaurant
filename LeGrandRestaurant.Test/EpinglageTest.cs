using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant.Test
{
    internal class EpinglageTest
    {
		//ÉTANT DONNE un serveur ayant pris une commande
		//QUAND il la déclare comme non-payée
		//ALORS cette commande est marquée comme épinglée

		//ÉTANT DONNE un serveur ayant épinglé une commande
		//QUAND elle date d'il y a au moins 15 jours
		//ALORS cette commande est marquée comme à transmettre gendarmerie

		//ÉTANT DONNE une commande à transmettre gendarmerie
		//QUAND on consulte la liste des commandes à transmettre du restaurant
		//ALORS elle y figure

		//ÉTANT DONNE une commande à transmettre gendarmerie
		//QUAND elle est marquée comme transmise à la gendarmerie
		//ALORS elle ne figure plus dans la liste des commandes à transmettre du restaurant
	}
}
