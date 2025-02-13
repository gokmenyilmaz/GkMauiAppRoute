using System.Xml.Linq;

namespace MauiApp14.PersonelModule;

public partial class PersonelListView : ContentPage
{
	public PersonelListView()
	{
		InitializeComponent();

        
		txtData.Text =DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


    }
}