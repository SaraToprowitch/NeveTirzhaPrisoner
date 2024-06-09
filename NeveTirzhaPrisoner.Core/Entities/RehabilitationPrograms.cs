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
        public int MaxNumOfPrisoners { get; set; }
        public int CurrentNumOfPrisoners { get; set; }
        public List<Prisoner> prisoners { get; set; }//לכל תכנית שיקום יש רשימת אסירים

      
    }

}
