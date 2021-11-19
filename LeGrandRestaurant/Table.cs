using System;

namespace LeGrandRestaurant
{
    public class Table
    {
        internal bool EstOccupée { get; private set; }

        public void InstallerClient()
        {
            if (EstOccupée) throw new InvalidOperationException();
            EstOccupée = true;
        }

        public void Libérer()
        {
            EstOccupée = false;
        }
    }
}
