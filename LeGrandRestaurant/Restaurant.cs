using System;
using System.Collections.Generic;

namespace LeGrandRestaurant
{
    public class Restaurant
    {
        public List<Commande> commandes { get; set; } = new List<Commande>();
        public List<Serveur> serveurs { get; set; } = new List<Serveur>();
        public MaitreHotel maitreHotel { get; set; } = new MaitreHotel();
        public List<Table> tables { get; set; } = new List<Table>();
        public Restaurant(Table table)
        {
        }
        public Restaurant()
        {
        }
        public void DébuterService()
        {
            this.maitreHotel.tables = this.tables;
        }


        public bool LaTableEstLibre(Table table)
            => !table.EstOccupée;
        public void AjouteServeur(Serveur serveur)
        {
            this.serveurs.Add(serveur);
        }
        public void AjouteCommande(Commande commande, Franchise franchise)
        {
            franchise.AjouteCommande(commande);
            this.commandes.Add(commande);
        }
        public void AjouteTable(Table table)
        {
            this.tables.Add(table);
        }
        public void AjouteTables(List<Table> tables)
        {
            this.tables.AddRange(tables);
        }
    }
}
