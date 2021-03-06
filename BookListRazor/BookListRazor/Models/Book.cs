using System;
namespace BookListRazor.Models
{
    public class Book
    {
        [System.ComponentModel.DataAnnotations.Key] // ?
        public int id { get; set; }
        [System.ComponentModel.DataAnnotations.Required] 
        public string Name { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }
        public Book()
        {
        }
    }
}
