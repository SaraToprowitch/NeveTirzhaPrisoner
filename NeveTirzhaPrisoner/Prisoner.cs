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

        public Prisoner(int id, string name, DateTime dateBirth, int yearsInPrison, Religion religion)
        {
            Id = id;
            Name = name;
            DateBirth = dateBirth;
            YearsInPrison = yearsInPrison;
            Religion = religion;
        }
        public Prisoner()
        {

        }

        internal static object Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }

}
