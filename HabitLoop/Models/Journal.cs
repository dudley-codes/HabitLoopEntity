using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HabitLoop.Models
{
    public class Journal
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string Habit { get; set; }
        public string Entry { get; set; }
    }
}
