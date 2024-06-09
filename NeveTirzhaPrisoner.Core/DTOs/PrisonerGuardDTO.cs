using NeveTirzahPrison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Core.DTOs
{
    public class PrisonerGuardDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }
        public Shift ShiftTime { get; set; }
        public float HourlySalary { get; set; }
    }
}
