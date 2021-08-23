using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitLoop.Models
{
    public class Habit
    {
        public int Id { get; set; }
        public int UserId {get; set;}
        public string Name { get; set; }
        public int Frequency { get; set; }
        public DateTime Start { get; set; }
        public bool GoodHabit { get; set; }
        public string Cue { get; set; }
        public string Reward { get; set; }
    }
}
