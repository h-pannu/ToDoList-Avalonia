using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using ToDoList.Model.Services;
using ToDoList.ViewModels;
using ToDoList.Views;

namespace ToDoList;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);

    }

    public override void OnFrameworkInitializationCompleted()
    {
        //var service = new ToDoListService();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {

            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel()
                //DataContext = new ToDoListViewModel(service.getItems())
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel()
                //DataContext = new ToDoListViewModel(service.getItems())
            };
        }

        base.OnFrameworkInitializationCompleted();
    }
}
