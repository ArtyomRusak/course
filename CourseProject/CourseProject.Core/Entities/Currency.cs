namespace CourseProject.Core.Entities
{
    public class Currency : Entity
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
    }
}
