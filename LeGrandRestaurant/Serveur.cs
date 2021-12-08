using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeGrandRestaurant
{
    public class Serveur
    {
        public float chiffreDaffaire { get; set; } = 0;
        public List<Commande> commandes { get; set; } = new List<Commande>();
        public List<Table> tables { get; set; } = new List<Table>();
        public Serveur() { }
           
        public void PrendCommande(Commande commande, Restaurant restaurant, Franchise franchise)
        {
            this.commandes.Add(commande);
            this.chiffreDaffaire += commande.Montant;
            if (commande.IsNourriture)
            {
                restaurant.AjouteCommande(commande, franchise);
            }
            else
            {
                //bar ?
            }
        }
        public void AjouterTables(Table table)
        {
            this.tables.Add(table);
        }

        public void AjouterTable(List<Table> tables)
        {
            this.tables.AddRange(tables);
        }
        public Table RetirerTable(Table table)
        {
            Table t = this.tables[this.tables.IndexOf(table)];
            this.tables.Remove(t);
            return t;
        }
        public  List<Table> RetirerTables()
        {
            List<Table> tables = new List<Table>(this.tables);
            this.tables = new();
            return tables;
        }
    }
}