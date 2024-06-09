namespace NeveTirzahPrison
{
    public enum Religion { christianity, islam, judaism }
    public class Prisoner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public int YearsInPrison { get; set; }
        public Religion Religion { get; set; }
        public PrisonGuard PrisonGuard { get; set; }//סוהר שאחראי עליו
        public List<RehabilitationPrograms> Programs { get; set; }//לכל אסיר יש רשימת תוכניות שיקום


      
    }

}
