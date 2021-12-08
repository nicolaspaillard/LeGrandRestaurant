using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LeGrandRestaurant.Test
{
    public class InstallationTests
    {
        [Fact(DisplayName = "ÉTANT DONNE une table dans un restaurant ayant débuté son service " +
                            "QUAND un client est affecté à une table " +
                            "ALORS cette table n'est plus sur la liste des tables libres du restaurant")]
        public void AffectationClient()
        {
            // ÉTANT DONNE une table dans un restaurant ayant débuté son service
            var table = new Table();
            var restaurant = new Restaurant(table);
            restaurant.DébuterService();

            // QUAND un client est affecté à une table
            table.InstallerClient();

            // ALORS cette table n'est plus sur la liste des tables libres du restaurant
            Assert.False(restaurant.LaTableEstLibre(table));
        }

        [Fact(DisplayName = "ÉTANT DONNE une table occupée par un client " +
                            "QUAND la table est libérée " +
                            "ALORS cette table appraît sur la liste des tables libres du restaurant")]
        public void DesaffectationClient()
        {
            // ÉTANT DONNE une table occupée par un client
            var table = new Table();
            var restaurant = new Restaurant();

            restaurant.DébuterService();
            table.InstallerClient();

            // QUAND la table est libérée
            table.Libérer();

            // ALORS cette table n'est plus sur la liste des tables libres du restaurant
            Assert.True(restaurant.LaTableEstLibre(table));
        }

        [Fact(DisplayName = "ÉTANT DONNE une table occupée par un client " +
                            "QUAND on veut installer un client " +
                            "ALORS une exception est lancée")]
        public void AlreadyPresentClient()
        {
            // ÉTANT DONNE une table occupée par un client
            var table = new Table();
            table.InstallerClient();

            // QUAND on veut installer un client
            void Act() => table.InstallerClient();

            // ALORS une exception est lancée
            Assert.Throws<InvalidOperationException>(Act);
        }

        [Fact(DisplayName = "ÉTANT DONNE une table dans un restaurant ayant débuté son service" +
                            "QUAND un client est affecté à une table" +
                            "ALORS cette table n'est plus sur la liste des tables libres du restaurant")]

        public void TableOccupée()
        {
            //ÉTANT DONNE une table dans un restaurant ayant débuté son service
            Table table = new Table();
            Restaurant leRestaurant = new Restaurant();
            leRestaurant.AjouteTable(table); 
            leRestaurant.DébuterService();

            //QUAND un client est affecté à une table
            table.InstallerClient();

            //ALORS cette table n'est plus sur la liste des tables libres du restaurant
            Assert.DoesNotContain(table, leRestaurant.tables.Where(t => !t.EstOccupée));
        }

        [Fact(DisplayName = "ÉTANT DONNE une table occupée par un client" +
                            "QUAND la table est libérée" +
                            "ALORS cette table appraît sur la liste des tables libres du restaurant")]
        public void TableLibérée()
        {
            //ÉTANT DONNE une table occupée par un client
            Table table = new Table();
            Restaurant restaurant = new Restaurant();
            restaurant.AjouteTable(table);
            table.InstallerClient();

            //QUAND la table est libérée
            table.Libérer();

            //ALORS cette table appraît sur la liste des tables libres du restaurant
            Assert.Contains(table, restaurant.tables.Where(t => !t.EstOccupée));
        }
    }
}
