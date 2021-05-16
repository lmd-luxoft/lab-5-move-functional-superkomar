// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

using MovieRental.Models;

namespace MovieRental
{
    internal class Rental
    {
        private readonly RentCalculatorBase _rentCalculator;

        public Rental(Movie movie, int daysRental)
        {
            Movie = movie;
            DaysRented = daysRental;

            _rentCalculator = RentCalculatorBase.Construct(Movie.PriceCode);
        }

        public Movie Movie { get; }

        public int DaysRented { get; }

        public double CountRentPrice() => _rentCalculator.CountRentPrice(DaysRented);

        public int GetRentPoints() => _rentCalculator.CountRentPoints(DaysRented);
    }
}