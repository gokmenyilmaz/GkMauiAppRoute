using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp14.PersonelModule
{



    [QueryProperty("Id", "id")]
    public partial class PersonelEditVM:ObservableObject
    {
        [ObservableProperty]

        public int id;

        public PersonelEditVM()
        {
            
        }
    }
}
