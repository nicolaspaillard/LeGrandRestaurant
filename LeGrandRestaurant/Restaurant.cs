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
        private bool serviceDébuté = false;
        //ALORS la table éditée est affectée au serveur et les deux autres au maître d'hôtel
        public Restaurant(Table table)
        {
        }
        public Restaurant()
        {
        }
        public void DébuterService()
        {
            this.maitreHotel.tables = this.tables;
            serviceDébuté = true;
        }
        public void TerminerService()
        {
            //this.tables = this.maitreHotel.RetirerTables();
            serviceDébuté = false;
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
        public void AjouteTables(Table table, Serveur serveur = null)
        {
            if (serveur == null)
            {
                this.tables.Add(table);
            }
            else
            {
                serveur.AjouterTables(table);
            }
        }
        public void AjouteTables(List<Table> tables, Serveur serveur = null)
        {
            if(serveur == null)
            {
                this.tables.AddRange(tables);
            }
            else
            {
                serveur.AjouterTable(tables);
            }   
        }
        public bool RetirerTableServeur(Table table, Serveur serveur)
        {
            if (!serviceDébuté)
            {
                this.tables.Add(serveur.RetirerTable(table));
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
