namespace Demo.Model
{
    public class Person
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string DocumentNumber { get; set; }
        public int DocumentTypeId { get; set; }
        public DateTime? Birthday { get; set; }
    }
}