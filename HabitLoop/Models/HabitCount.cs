using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitLoop.Models
{
    public class HabitCount
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual int HabitId { get; set; }
    }
}
