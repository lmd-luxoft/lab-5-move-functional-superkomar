namespace MovieRental.Models
{
    internal class RegularMovie : RentCalculatorBase
    {
        public override int DayCost => 15;

        public override int RentCost => 2;

        public override int FreeDays => 2;

        public override double CountRentPrice(int daysRent)
        {
            var result = RentCost;
            if (daysRent > FreeDays)
            {
                result += (daysRent - FreeDays) * DayCost;
            }

            return result;
        }

        public override int CountRentPoints(int daysRent) => 1;
    }
}
