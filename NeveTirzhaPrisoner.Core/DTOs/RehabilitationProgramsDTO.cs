using NeveTirzahPrison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Core.DTOs
{
    public class RehabilitationProgramsDTO
    {
        public int Id { get; set; }
        public Programs Programs { get; set; }
        public string Moderator { get; set; }
        public Day DayOfWeek { get; set; }
        public int LengthInMonths { get; set; }
        public int MaxNumOfPrisoners { get; set; }
        public int CurrentNumOfPrisoners { get; set; }
    }
}
