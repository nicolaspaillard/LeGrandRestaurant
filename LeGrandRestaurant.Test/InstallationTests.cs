using System;
using System.Collections.Generic;
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
            var restaurant = new Restaurant(table);

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
        [Fact(DisplayName = "ÉTANT DONNÉ un restaurant ayant X serveurs QUAND tous les serveurs prennent une commande dun montant Y ALORS le chiffre d'affaires de la franchise est X * Y")]






        public void CAServeurFranchise()
        {
            // ÉTANT DONNÉ un restaurant ayant X serveurs
            Serveur serveur = new Serveur();
            List <Serveur> lesServeurs = new();
            for (int i = 0; i < 3; i++)
            {
                lesServeurs.Add(serveur);
            }

            // QUAND tous les serveurs prennent une commande dun montant Y
            void Act() => table.InstallerClient();

            // ALORS le chiffre d'affaires de la franchise est X * Y
            Assert.Throws<InvalidOperationException>(Act);
        }
    }
}
