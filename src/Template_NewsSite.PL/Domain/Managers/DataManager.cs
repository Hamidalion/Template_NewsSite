using Template_NewsSite.PL.Domain.Repository.Interfaces;

namespace Template_NewsSite.PL.Domain.Managers
{
    public class DataManager
    {
        public ITextFieldRepository TextFields { get; set; }
        public INewsItemRepository NewsItems { get; set; }

        public DataManager(ITextFieldRepository textFieldRepository, INewsItemRepository newsItem)
        {
            TextFields = textFieldRepository;
            NewsItems = newsItem;
        }

    }
}
