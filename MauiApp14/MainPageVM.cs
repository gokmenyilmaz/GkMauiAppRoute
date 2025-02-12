using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp14
{
    public partial class MainPageVM : ObservableObject
    {
        [ObservableProperty]
        public string title;


        [ObservableProperty]
        public string message;


        

        public MainPageVM()
        {
            Title = "Hello Gökmen";
        }


        [RelayCommand]
        public async void PersonelListesiGoster()
        {
           await Shell.Current.GoToAsync("PersonelListPage");

        }

    }
}
