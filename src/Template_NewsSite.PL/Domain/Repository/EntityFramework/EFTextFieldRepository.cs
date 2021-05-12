using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Template_NewsSite.PL.Domain.Context;
using Template_NewsSite.PL.Domain.Entities;
using Template_NewsSite.PL.Domain.Repository.Interfaces;

namespace Template_NewsSite.PL.Domain.Repository.EntityFramework
{
    public class EFTextFieldRepository : ITextFieldRepository
    {
        private readonly NewsSiteDbContext _context;

        public EFTextFieldRepository(NewsSiteDbContext context)
        {
            _context = context;
        }

        public IQueryable<TextField> GetTextField()
        {
            return _context.TextFields;
        }

        public TextField GetTextFieldById(Guid id)
        {
            return _context.TextFields.FirstOrDefault(t => t.Id == id);
        }

        public TextField GetTextFieldByCodeWord(string codeword)
        {
            return _context.TextFields.FirstOrDefault(t => t.CodeWord == codeword);
        }

        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                _context.Entry(entity).State = EntityState.Added;
            else
                _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteTextField(Guid id)
        {
            _context.TextFields.Remove(new TextField() { Id = id });
            _context.SaveChanges();
        }
    }
}
