namespace LeGrandRestaurant
{
    public class Restaurant
    {
        public Restaurant(Table table)
        {
        }

        public void DébuterService()
        {
        }

        public bool LaTableEstLibre(Table table)
            => !table.EstOccupée;
    }
}
