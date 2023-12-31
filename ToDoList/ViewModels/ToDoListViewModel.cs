﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.DataModel;

namespace ToDoList.ViewModels
{
    public class ToDoListViewModel : ViewModelBase
    {
        public ObservableCollection<ToDoItem> ListItems { get; set; }
        public ToDoListViewModel(IEnumerable<ToDoItem> items)
        {
            ListItems = new ObservableCollection<ToDoItem>(items);
        }
    }
}
