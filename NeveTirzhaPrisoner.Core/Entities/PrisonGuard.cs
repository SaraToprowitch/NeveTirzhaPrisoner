namespace NeveTirzahPrison
{
    public enum Role { prisonOfficers, supervisors, support, mentalHealth, emergency }
    public enum Shift { morning, noon, evening, night }
    public class PrisonGuard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public Shift ShiftTime { get; set; }
        public float HourlySalary { get; set; }
        public List<Prisoner> prisoners { get; set; }//רשימת אסירים שאחראי עליהם

        
    }
}
