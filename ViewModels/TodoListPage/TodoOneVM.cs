using CommunityToolkit.Maui.Storage;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Alerts;
using todomaui.Common;
using todomaui.Enums;

namespace todomaui.ViewModels.TodoListPage
{
    public partial class TodoOneVM : ObservableObject, IQueryAttributable
    {
        private readonly IFileSaver _fileSaver;
        private readonly IFolderPicker _folderPicker;
        [ObservableProperty] private DateTime createTime;

        [ObservableProperty] private DateTime updateTime;

        [ObservableProperty] private string title;

        [ObservableProperty] private string content;

        [ObservableProperty] private EditEnum editEnum;

        private string id;

        public TodoOneVM()
        {
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            this.EditEnum = (EditEnum)query["mode"];
            this.id = query["id"] as string;
        }


        [RelayCommand]
        private async Task onSave()
        {
            //直接保存数据到android的内部文件夹内
            


        }
    }
}