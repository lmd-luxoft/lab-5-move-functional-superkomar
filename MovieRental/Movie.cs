// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation

namespace MovieRental
{
    internal class Movie
    {
        public enum Type
        {
            NEW_RELEASE,
            REGULAR,
            CHILDREN
        }

        public Movie(string title, Type type)
        {
            Title = title;
            PriceCode = type;
        }

        internal string Title { get; }

        internal Type PriceCode { get; }

        public override string ToString() => Title;
    }
}