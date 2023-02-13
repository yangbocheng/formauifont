using todomaui.Views;

namespace todomaui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		//注册tod
		Routing.RegisterRoute("todoone",typeof(TodoOnePage));
	}
}
