using System;
using System.ComponentModel.DataAnnotations;

namespace Gamgee.Models
{
    public class Post
    {
        [Key]
        public long PostID { get; set; }
        [Required]
        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Title must be between 5 and 100 characters long")]
        public string Title { get; set; }
        [Display(Name = "Posted")]
        [DataType(DataType.DateTime)]
        public DateTime PostedDate { get; set; }
        public string Author { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MinLength(5, ErrorMessage = "Post must be at least 5 characters long")]
        public string Body { get; set; }

        [Timestamp]
        public Byte[] TimeStampDate { get; set; }

        public int ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
