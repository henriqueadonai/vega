using System.ComponentModel.DataAnnotations;

namespace vega.Core.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        [Required]
        public string Url { get; set; }
    }
}