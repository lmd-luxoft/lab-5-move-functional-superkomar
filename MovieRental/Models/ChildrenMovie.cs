namespace MovieRental.Models
{
    internal class ChildrenMovie : RentCalculatorBase
    {
        public override int DayCost => 15;

        public override int RentCost => 15;

        public override int FreeDays => 3;

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
