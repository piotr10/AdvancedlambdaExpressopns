using System.Collections.Generic;

namespace AdvancedLambdaEpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title = "Smerfy", Price = 1},
                new Book() {Title = "Podróż do wnętrza ziemi", Price = 3},
                new Book() {Title = "Była sobie ziemia", Price = 11},
                new Book() {Title = "Too much too young", Price = 5},
                new Book() {Title = "Elo for de after live", Price = 15}
            };
        }

      //  public List<Book> GetBooks()
      //  {
      //      return new List<Book>()
      //      {
      //          new Book() {Title = "Title 1", Price = 5},
      //          new Book() {Title = "Title 2", Price = 7},
      //          new Book() {Title = "Title 3", Price = 17},
      //      };
      //  }
        
    }
}