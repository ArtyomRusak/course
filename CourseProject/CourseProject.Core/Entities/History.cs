﻿namespace CourseProject.Core.Entities
{
    public class History : Entity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public virtual Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
