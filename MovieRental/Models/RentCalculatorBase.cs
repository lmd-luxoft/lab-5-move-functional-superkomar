using System;

namespace MovieRental.Models
{
    internal abstract class RentCalculatorBase
    {
        public abstract int DayCost { get; }

        public abstract int RentCost { get; }

        public abstract int FreeDays { get; }

        public abstract double CountRentPrice(int daysRent);

        public abstract int CountRentPoints(int daysRent);

        public static RentCalculatorBase Construct(Movie.Type type)
        {
            switch (type)
            {
                case Movie.Type.REGULAR:     return new RegularMovie();
                case Movie.Type.CHILDREN:    return new ChildrenMovie();
                case Movie.Type.NEW_RELEASE: return new NewReleaseMovie();
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
