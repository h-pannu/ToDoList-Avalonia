using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.DataModel;

namespace ToDoList.Model.Services
{
    public class ToDoListService
    {
        public IEnumerable<ToDoItem> getItems() => new[]
        {
            new ToDoItem { Description = "Wal the dog"},
            new ToDoItem {Description = "Buy some milk"},
            new ToDoItem { Description ="Learn Avalonia", IsChecked = true},
        };
    }
}
