using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Template_NewsSite.PL.Domain.Context;
using Template_NewsSite.PL.Domain.Entities;
using Template_NewsSite.PL.Domain.Repository.Interfaces;

namespace Template_NewsSite.PL.Domain.Repository.EntityFramework
{
    public class EFNewsItemRepository : INewsItemRepository
    {
        private readonly NewsSiteDbContext _context;

        public EFNewsItemRepository(NewsSiteDbContext context)
        {
            _context = context;
        }

        public IQueryable<NewsItem> GetNewsItem()
        {
            return _context.NewsItems;
        }

        public NewsItem GetNewsItemById(Guid id)
        {
            return _context.NewsItems.FirstOrDefault(n => n.Id == id);
        }

        public void SaveNewsItem(NewsItem entity)
        {
            if (entity.Id == default)
            {
                _context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            _context.SaveChanges();
        }

        public void DeleteNewsItem(Guid id)
        {
            _context.NewsItems.Remove(new NewsItem() { Id = id });
            _context.SaveChanges();
        }
    }
}
