using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLog.Domain.Entities;
using WebLog.Domain.Repositories.Abstract;

namespace WebLog.Domain.Repositories.EntityFramework
{
    public class EFTextFieldsRepository: ITextFieldsRepository
    {
        private readonly AppDBContext context;
        public EFTextFieldsRepository(AppDBContext context) 
        {
            this.context = context;
        }
        public IQueryable<TextField> GetTextFields() 
        {
            return context.TextFields;
        }
        public TextField GetTextFieldById(Guid id) 
        {
            return context.TextFields.FirstOrDefault(x => x.Id == id);
        }
        public TextField GetTextFieldByCodeWord(string codeword)
        {
            return context.TextFields.FirstOrDefault(x => x.CodeWord == codeword);
        }
        public void SaveTextField(TextField entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteTextField(Guid id)
        {
            context.TextFields.Remove(new TextField { Id = id});
            context.SaveChanges();
        }
    }
}
