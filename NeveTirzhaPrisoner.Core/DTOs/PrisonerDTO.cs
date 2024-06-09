using NeveTirzahPrison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeveTirzhaPrisoner.Core.DTOs
{
    public class PrisonerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateBirth { get; set; }
        public int YearsInPrison { get; set; }
        public Religion Religion { get; set; }
        public PrisonGuard PrisonGuard { get; set; }
    }
}
