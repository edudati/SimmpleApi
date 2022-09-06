using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleApi.Model
{
    [Table("book")]
    public class Book :BaseEntity
    {
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        public Book()
        {

        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
