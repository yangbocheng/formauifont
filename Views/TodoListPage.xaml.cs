using System.Collections.ObjectModel;
using System.Diagnostics;
using todomaui.ViewModels;

namespace todomaui.Views;

/// <summary>
/// ���ذ�
/// </summary>
public partial class TodoListPage : ContentPage
{
    private TodoListPageVM vm;
    public TodoListPage(TodoListPageVM _vm)
    {
        InitializeComponent();
        this.vm = _vm;
        this.BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        vm.List.Add(new ViewModels.TodoListPage.TodoOneVM()
        {
            Title = "asd",
            CreateTime = DateTime.Now,
            UpdateTime = DateTime.Now.AddDays(20),
            Content="zzzzz"
        });
        vm.List.Add(new ViewModels.TodoListPage.TodoOneVM()
        {
            Title = "asd111",
            CreateTime = DateTime.Now,
            UpdateTime = DateTime.Now.AddDays(20),
            Content = "zzzzz222"
        });
        base.OnAppearing();
    }

    private async void on_tap1(object sender, TappedEventArgs e)
    {
        Debug.WriteLine($"is tap================== {DateTime.Now:HH:mm:ss.fff}");

        var bor = (Border)sender;
        var w = bor.Width;
        var w1 = bor.WidthRequest;
        await bor.ScaleTo(1.05,60);
        await bor.ScaleTo(1, 30);

        var w2 = bor.Width;
        var w3 = bor.WidthRequest;
        Debug.WriteLine("isend");

        Debug.WriteLine($"{w} {w1} {w2} {w3}");
    }
}