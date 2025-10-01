using System.ComponentModel.DataAnnotations;

namespace Wordle.Models
{
    public class WordModel
    {
        public int Id { get; set; }
        public string Letters { get; set; }
        public int Length { get; set; }
        public DateTime Created { get; set; }
        public int TimesGuessed { get; set; }
    }
}
