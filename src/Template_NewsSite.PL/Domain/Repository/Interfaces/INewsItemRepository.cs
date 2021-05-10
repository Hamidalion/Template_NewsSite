using System;
using System.Linq;
using Template_NewsSite.PL.Domain.Entities;

namespace Template_NewsSite.PL.Domain.Repository.Interfaces
{
    public interface INewsItemRepository
    {
        IQueryable<NewsItem> GetNewsItem();
        NewsItem GetNewsItemById(Guid id);

        void SaveNewsItem(NewsItem entity);

        void DeleteNewsItem(Guid id);
    }
}
