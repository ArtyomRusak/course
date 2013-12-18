namespace CourseProject.Core.Entities
{
    public class Currency : Entity
    {
        public int Id { get; set; }
        public string Value { get; set; }

        #region Overrides of Object

        public override string ToString()
        {
            return this.Value;
            return base.ToString();
        }

        #endregion
    }
}
