using System.ComponentModel.DataAnnotations;
using BiblioNetAPP2.Validations;

namespace BiblioNetAPP2.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        [FirstCapitalLetter]
        public string Title { get; set; }
        public string Description { get; set; }
        public int   AuthorId { get; set; }
        public int pages { get; set; }
        public string publicationDate { get; set; }
        public string RegisterDate { get; set; }
        public int CategoryId { get; set; }

    }
}
