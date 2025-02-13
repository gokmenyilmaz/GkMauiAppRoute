using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp14.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp14.PersonelModule
{
    public partial class PersonelListVM : ObservableObject, IQueryAttributable
    {

        [ObservableProperty]
        public List<Personel> _personelList;


        [ObservableProperty]
        public string title;
        public PersonelListVM()
        {

            Random random = new Random();
            int rastgeleSayi = random.Next(1, 101);

            PersonelList = new List<Personel>();
            PersonelList.Add(new Personel { Id = 1, Name = "Ali", Surname = "Yılmaz", Age = rastgeleSayi });
            PersonelList.Add(new Personel { Id = 2, Name = "Veli", Surname = "Kara", Age = 30 });
            PersonelList.Add(new Personel { Id = 3, Name = "Ayşe", Surname = "Beyaz", Age = 35 });
            PersonelList.Add(new Personel { Id = 4, Name = "Fatma", Surname = "Kara", Age = 40 });


            Title= "Personel Listesi";

        }




    
        [RelayCommand]
        private async void SelectionChanged(Personel selectedPersonel)
        {
            await Shell.Current.GoToAsync("PersonelEdit?id=" + selectedPersonel.Id);

        }


        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query.ContainsKey("kaydet") && query["kaydet"] is Personel updatedPersonel)
            {
                UpdatePersonel(updatedPersonel);
            }
        }

        private void UpdatePersonel(Personel updatedPersonel)
        {
            var existing = PersonelList.FirstOrDefault(p => p.Id == updatedPersonel.Id);
            if (existing != null)
            {
                // Var olanı güncelle

                existing.Name = updatedPersonel.Name;
                existing.Surname = updatedPersonel.Surname;
                existing.Age = updatedPersonel.Age;
            }
            else
            {
                // Listeye yeni ekle
                PersonelList.Add(updatedPersonel);
            }
        }


    }
}
