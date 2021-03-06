﻿using System;

namespace CourseProject.Core.Entities
{
    public class OptionLoan : Entity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
        public int DurationInMonth { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
