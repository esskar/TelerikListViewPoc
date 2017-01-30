namespace TelerikListViewPoc.Components
{
    public class Book : Bindable
    {
        private string _author;
        private string _title;
        private int _year;

        public string Author 
        {
            get { return _author; }
            set { this.SetValue (ref _author, value); }
        }

        public string Title 
        {
            get { return _title; }
            set { this.SetValue (ref _title, value); }
        }

        public int Year 
        {
            get { return _year; }
            set { this.SetValue (ref _year, value); }
        }
    }
}