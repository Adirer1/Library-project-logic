
namespace Library_project_logic
{
    public abstract class Item
    {
          public Item()
          {
              Isbn = Guid.NewGuid();
              
          }

        
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private Guid _isbn;
        public Guid Isbn
        {
            
            
            get { return _isbn; }
            set { _isbn = value; }
        }
        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        private string _publisher;
        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }
        private DateTime _publishDate;
        public DateTime PublishDate 
        { 
            get { return _publishDate; }
            set { _publishDate = value; }
        }
        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
       
        
           
        
    }
}