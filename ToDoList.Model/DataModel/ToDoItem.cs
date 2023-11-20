﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Model.DataModel
{
    public class ToDoItem
    {
        public string Description { get; set; } = string.Empty;
        public bool IsChecked { get; set; }
    }
}
