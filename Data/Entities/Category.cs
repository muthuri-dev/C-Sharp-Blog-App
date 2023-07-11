using System.ComponentModel.DataAnnotations;

namespace Blog_App.Data.Entities{
    public class Category{
        [Key]
        public int Id{get;set;}
        [Required,MaxLength(100)]
        public string Name{get;set;}
        public string Slug{get; set;}
    }
}