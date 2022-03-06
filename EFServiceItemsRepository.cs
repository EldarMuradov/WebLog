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
    public class EFServiceItemsRepository: IServiceItemsRepository
    {

        private readonly AppDBContext context;
        public EFServiceItemsRepository(AppDBContext context)
        {
            this.context = context;
        }
        public IQueryable<ServiceItem> GetServiceItem()
        {
            return context.ServiceItems;
        }
        public ServiceItem GetServiceItemById(Guid id) 
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }
        public void SaveServiceItem(ServiceItem entity)
        {
           if (entity.Id == default)
               context.Entry(entity).State = EntityState.Added;
           else
               context.Entry(entity).State = EntityState.Modified;
           context.SaveChanges();
        }
        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem { Id = id });
            context.SaveChanges();
        }
    }
}
