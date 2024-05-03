using System.ComponentModel.DataAnnotations.Schema;

namespace ClassLibrary1.Entities
{
    public class BookEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
}
