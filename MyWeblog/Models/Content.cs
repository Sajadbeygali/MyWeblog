namespace MyWeblog.Models
{
    public class Content
    {

        public Content(Guid Id,string contentName, string contentDescription, DateTime datecreate)
        {
            Id = Guid.NewGuid();
            ContentName = contentName;
            ContentDescription = contentDescription;
            Datecreate = datecreate;
        }

        public Guid Id { get; set; }
        public string ContentName { get; set; }
        public string ContentDescription { get; set; }
        public DateTime Datecreate { get; set; }

        private Content()
        {

        }

    }
}
