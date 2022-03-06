using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLog.Domain.Repositories.Abstract;

namespace WebLog.Domain.Repositories
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }
        public DataManager(ITextFieldsRepository textFields, IServiceItemsRepository serviceItems) 
        {
            TextFields = textFields;
            ServiceItems = serviceItems;
        }
    }
}
