using System.ComponentModel.DataAnnotations;

namespace Template_NewsSite.PL.Domain.Entities
{
    public class NewsItem : EntityBase
    {
        [Required(ErrorMessage = "Add the name of News")]
        [Display(Name = "News title")]
        public override string Title { get; set; }

        [Display(Name = "Short description")]
        public override string Subtitle { get; set; }

        [Display(Name = "Full description")]
        public override string Text { get; set; }
    }
}
