using System;

namespace CourseProject.Core.Entities
{
    public class OptionDeposit : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
        public TimeSpan Duration { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
