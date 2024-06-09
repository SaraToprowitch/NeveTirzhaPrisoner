using NeveTirzahPrison;

namespace NeveTirzhaPrisoner.API.Models
{
    public class PrisonerPostModel
    {
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public int YearsInPrison { get; set; }
        public Religion Religion { get; set; }
        public PrisonGuard PrisonGuard { get; set; }
    }
}
