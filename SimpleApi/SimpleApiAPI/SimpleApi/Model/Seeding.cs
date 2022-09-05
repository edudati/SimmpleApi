using SimpleApi.Model.Context;

namespace SimpleApi.Model
{
    public class Seeding
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var _context = serviceScope.ServiceProvider.GetService<MySqlContext>();

                if (!_context.Persons.Any() && !_context.Books.Any())
                {
                    List<Person> persons = new List<Person>
                    {
                        new Person("Pepe", "Legal"),
                        new Person("Tinoco", "Oco"),
                        new Person("Monica", "Barbuda"),
                        new Person("Chica", "da Silva"),
                        new Person("Pedro", "Olha o gás"),
                        new Person("Tania", "Letícia")
                    };

                    List<Book> books = new List<Book>
                    {
                        new Book("A casa caiu", "Canduco"),
                        new Book("sem dó nenhum", "Matildo"),
                        new Book("Titanic", "Fundo mar"),
                        new Book("Qualquer um pode ser eu", "ninguem")
                    };
                    
                    _context.Persons.AddRange(persons);
                    _context.Books.AddRange(books);
                    _context.SaveChanges();
                }
            }
        }
    }
}
