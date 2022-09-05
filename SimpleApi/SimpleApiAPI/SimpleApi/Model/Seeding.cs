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

                if (!_context.Persons.Any())
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

                    _context.Persons.AddRange(persons);
                    _context.SaveChanges();
                }
            }
        }
    }
}
