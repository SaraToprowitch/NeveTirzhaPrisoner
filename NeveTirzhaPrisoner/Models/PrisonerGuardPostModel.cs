using NeveTirzahPrison;

namespace NeveTirzhaPrisoner.API.Models
{
    public class PrisonerGuardPostModel
    {
        public string Name { get; set; }
        public Role Role { get; set; }
        public Shift ShiftTime { get; set; }
        public float HourlySalary { get; set; }

    }
}
