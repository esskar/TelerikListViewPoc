using System.Collections.ObjectModel;
using System.Windows.Input;
using TelerikListViewPoc.Components;
using Xamarin.Forms;

namespace TelerikListViewPoc.ViewModels
{
    public class MainViewModel : Bindable
    {
        private ObservableCollection<Book> _books;
        private ICommand _addCommand;

        public MainViewModel()
        {
            for (var i = 0; i < 30; i++) 
            {
                this.Bocks.Add(CreateBook(i));
            }
        }

        public ICommand AddCommand => _addCommand
            ?? (_addCommand = new Command(this.OnAdd));

        public ObservableCollection<Book> Bocks => _books
            ?? (_books = new ObservableCollection<Book>());

        public void OnAdd()
        {
            this.Bocks.Insert(0, CreateBook(this.Bocks.Count));
        }

        private static Book CreateBook(int id)
        {
            return new Book 
            {
                Author = "Charlie " + id,
                Title = "Book #" + id,
                Year = 1956 + id
            };
        }
    }
}
