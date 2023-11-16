namespace NeveTirzahPrison
{
    public enum Day { sunday, monday, tuesday, wednesday, thursday, friday, saturday }
    public enum Programs { educational, parentingSkills, angerManagement, drugAbuseTreatment, vocationalTraining }//חינוך,הורות,ניהול כעסים,טיפול בשימוש סמים,הכשרה מקצועית
    public class RehabilitationPrograms
    {
        public int Id { get; set; }
        public Programs Programs { get; set; }
        public string Moderator { get; set; }
        public Day DayOfWeek { get; set; }
        public int LengthInMonths { get; set; }

        public RehabilitationPrograms(int id, Programs programs, string moderator, Day dayOfWeek, int lengthInMonths)
        {
            Id = id;
            Programs = programs;
            Moderator = moderator;
            DayOfWeek = dayOfWeek;
            LengthInMonths = lengthInMonths;
        }
        public RehabilitationPrograms()
        {

        }
    }

}
