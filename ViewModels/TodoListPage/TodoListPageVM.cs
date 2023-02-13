using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todomaui.Enums;
using todomaui.ViewModels.TodoListPage;

//using System.Collections.ObjectModel;
namespace todomaui.ViewModels;

public partial class TodoListPageVM : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<TodoOneVM> list = new ObservableCollection<TodoOneVM>();

    [RelayCommand]
    private async Task toEdit()
    {
        await Shell.Current.GoToAsync("todoone", new Dictionary<string, object>
        {
            ["mode"] = EditEnum.New,
            ["id"] = ""
        });
    }

    
}
