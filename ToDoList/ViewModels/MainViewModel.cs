using ReactiveUI;
using System.Reactive.Linq;
using ToDoList.Model.DataModel;
using ToDoList.Model.Services;
using System;

namespace ToDoList.ViewModels;

public class MainViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;
    public ToDoListViewModel ToDoList {  get;}
    public MainViewModel()
    {
        var service = new ToDoListService();
        ToDoList = new ToDoListViewModel(service.getItems());
        _contentViewModel = ToDoList;
    }

    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }

    public void AddItem()
    {
        AddItemViewModel addItemViewModel = new();

        Observable.Merge(
            addItemViewModel.OkCommand,
            addItemViewModel.CancelCommand.Select(_ => (ToDoItem?)null))
            .Take(1)
            .Subscribe(newItem =>
            {
                if (newItem != null)
                {
                    ToDoList.ListItems.Add(newItem);
                }
                ContentViewModel = ToDoList;
            });

        ContentViewModel = addItemViewModel;
    }

}
