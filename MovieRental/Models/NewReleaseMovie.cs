namespace MovieRental.Models
{
    internal class NewReleaseMovie : RentCalculatorBase
    {
        public override int DayCost => 3;

        public override int RentCost => 0;

        public override int FreeDays => 0;

        public override double CountRentPrice(int daysRent)
        {
            return daysRent * DayCost;
        }

        public override int CountRentPoints(int daysRent)
        {
            return daysRent == 2 ? 2 : 1;
        }
    }
}
