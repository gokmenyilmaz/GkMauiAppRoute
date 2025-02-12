using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp14.PersonelModule
{
    public partial class PersonelListVM : ObservableObject
    {

        [ObservableProperty]
        public List<Personel> _personelList;


        [ObservableProperty]
        public string title;
        public PersonelListVM()
        {
            PersonelList = new List<Personel>();
            PersonelList.Add(new Personel { Id = 1, Name = "Ali", Surname = "Yılmaz", Age = 25 });
            PersonelList.Add(new Personel { Id = 2, Name = "Veli", Surname = "Kara", Age = 30 });
            PersonelList.Add(new Personel { Id = 3, Name = "Ayşe", Surname = "Beyaz", Age = 35 });
            PersonelList.Add(new Personel { Id = 4, Name = "Fatma", Surname = "Kara", Age = 40 });


            Title= "Personel Listesi";

        }
    }
}
