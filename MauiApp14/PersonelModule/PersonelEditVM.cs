using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp14.Models;

namespace MauiApp14.PersonelModule
{
    [QueryProperty("Id", "id")]
    public partial class PersonelEditVM : ObservableObject
    {
        [ObservableProperty]
        public int id;

        [ObservableProperty]
        public Personel personelEdit;

        public PersonelEditVM()
        {
            PersonelEdit = new Personel();
        }

        [RelayCommand]
        public async void Kaydet()
        {
            PersonelEdit.Id = Id;
            PersonelEdit.Name = "xxxxxAli";
            PersonelEdit.Surname = "xxxYılmaz";

            var navigationParameter = new ShellNavigationQueryParameters
            {
                { "kaydet", PersonelEdit },
            };
            await Shell.Current.GoToAsync($"..?kaydet", navigationParameter);
        }
    }
}
