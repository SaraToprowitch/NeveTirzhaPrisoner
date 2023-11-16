using System.Data;
using System;

namespace NeveTirzahPrison
{
    public class DataContext
    {
        public static List<Prisoner> prisoners = new List<Prisoner>()
{
    new Prisoner { Id = 1, Name = "Emily Johnson", DateBirth = new DateTime(1990, 5, 15), YearsInPrison = 8, Religion = Religion.christianity },
    new Prisoner { Id = 2, Name = "Mariam Al-Aziz", DateBirth = new DateTime(1987, 9, 21), YearsInPrison = 12, Religion = Religion.islam },
    new Prisoner { Id = 3, Name = "Luna Taylor", DateBirth = new DateTime(1982, 2, 7), YearsInPrison = 5, Religion = Religion.judaism },
};

        public static List<PrisonGuard> prisonGuards = new List<PrisonGuard>()
        {
    new PrisonGuard { Id = 1, Name = "John Doe", Role = Role.prisonOfficers, ShiftTime = Shift.morning, HourlySalary = 15.50f },
    new PrisonGuard { Id = 2, Name = "Jane Smith", Role = Role.supervisors, ShiftTime = Shift.evening, HourlySalary = 18.75f },
    new PrisonGuard { Id = 3, Name = "Mike Johnson", Role = Role.support, ShiftTime = Shift.noon, HourlySalary = 14.25f },
    new PrisonGuard { Id = 4, Name = "Emily Davis", Role = Role.mentalHealth, ShiftTime = Shift.night, HourlySalary = 16.80f }
};
        public static List<RehabilitationPrograms> rehabilitationPrograms = new List<RehabilitationPrograms>()
        {
    new RehabilitationPrograms(1, Programs.educational, "Emily Wilson", Day.sunday, 6),
    new RehabilitationPrograms(2, Programs.parentingSkills,"Emma Johnson" , Day.monday, 3),
    new RehabilitationPrograms(3, Programs.angerManagement,"Olivia Roberts" , Day.tuesday, 4),
    new RehabilitationPrograms(4, Programs.drugAbuseTreatment, "Sophia Davis", Day.wednesday, 12)
};
    }
}
