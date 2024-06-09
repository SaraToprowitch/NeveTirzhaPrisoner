using NeveTirzahPrison;

namespace NeveTirzhaPrisoner.API.Models
{
    public class RehabilitationProgramsPostModel
    {
        public Programs Programs { get; set; }
        public string Moderator { get; set; }
        public Day DayOfWeek { get; set; }
        public int LengthInMonths { get; set; }
        public int MaxNumOfPrisoners { get; set; }
        public int CurrentNumOfPrisoners { get; set; }

    }
}
