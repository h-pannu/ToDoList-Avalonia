using ReactiveUI;
using ToDoList.Model.Services;

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
        ContentViewModel = new AddItemViewModel();
    }

}
