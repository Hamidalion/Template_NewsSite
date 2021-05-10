using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_NewsSite.PL.Domain.Entities;

namespace Template_NewsSite.PL.Domain.Repository.Interfaces
{
    public interface ITextFieldRepository
    {
        IQueryable<TextField> GetTextField();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeword);

        void SaveTextField(TextField entity);

        void DeleteTextField(Guid id);
    }
}
