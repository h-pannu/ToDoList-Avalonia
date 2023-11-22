using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.DataModel;

namespace ToDoList.ViewModels
{
    public class AddItemViewModel :ViewModelBase
    {
        private string _description;

        public string Description
        {
            get => _description;
            set => this.RaiseAndSetIfChanged(ref _description, value);
        }

        public ReactiveCommand<Unit, ToDoItem> OkCommand { get; }
        public ReactiveCommand<Unit, Unit> CancelCommand { get; }

        public AddItemViewModel()
        {
            var isValidObservable = this.WhenAnyValue(
                x => x.Description,
                x => !string.IsNullOrEmpty(x));

            OkCommand = ReactiveCommand.Create(
                () => new ToDoItem { Description = Description}, isValidObservable );

            CancelCommand=ReactiveCommand.Create(() => {  });
        }
    }
}
