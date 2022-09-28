namespace Demo.ViewModel
{
    public class PersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public DateTime Birthday { get; set; }
    }

    public class PersonByIdViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string DocumentNumber { get; set; }
        public int DocumentTypeId { get; set; }
        public DateTime Birthday { get; set; }
    }
}