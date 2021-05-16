// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections.Generic;
using System.Text;

namespace MovieRental
{
    public class Customer
    {
        private readonly List<Rental> rentals = new List<Rental>();

        public Customer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        internal void AddRental(Rental rental)
        {
           rentals.Add(rental);
        }

        internal string GetReport()
        {
            var report = new StringBuilder();

            report.Append($"учет аренды для {Name}\n");
            
            double totalRenta = 0;
            int rentPoints = 0;
            foreach (var item in rentals)
            {
                double itemRent = item.CountRentPrice();
                totalRenta += itemRent;

                rentPoints += item.GetRentPoints();

                report.Append($"\t{item.Movie}\t{itemRent}\n");
            }

            report.Append($"Сумма задолженности составляет {totalRenta}\nВы заработали {rentPoints} очков за активность");

            return report.ToString();
        }
    }
}