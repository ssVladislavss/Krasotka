using Microsoft.EntityFrameworkCore;
using OnlineKrasotka.Domain.Entities;
using OnlineKrasotka.Domain.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineKrasotka.Domain.Repository.EntityFramework
{    
    public class EFTextFieldsRepository : ITextFields
    {
        private readonly AppDb context;
        public EFTextFieldsRepository(AppDb db) => context = db;
        public void DeleteTextField(Guid id)
        {
            var entity = context.TextFields.FirstOrDefault(x => x.Id == id);
            context.TextFields.Remove(entity/*new TextField { Id = id }*/);
            context.SaveChanges();
        }
        public TextField GetTextFieldByCodeWord(string codeWord)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
        }
        public TextField GetTextFieldById(Guid id)
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }
        public IQueryable<TextField> GetTextFields()
        {
            return context.TextFields;
        }
        public void SaveTextField(TextField entity)
        {
            //if (entity.Id == default)
            //    context.Entry(entity).State = EntityState.Added;
            //else
            //    context.Entry(entity).State = EntityState.Modified;
            context.TextFields.AddRange(entity);
            context.SaveChanges();
        }
    }
}
