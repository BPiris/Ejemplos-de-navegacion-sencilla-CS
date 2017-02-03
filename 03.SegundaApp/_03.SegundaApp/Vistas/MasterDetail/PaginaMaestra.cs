using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using _03.SegundaApp.Model;

namespace _03.SegundaApp.Vistas
{
    public class PaginaMaestra: ContentPage
    {
        public ListView ListView { get { return listView; } }

        ListView listView;

        public PaginaMaestra()
        {
            var elementosMasterPage = new List<ElementoMasterPageModel>();

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Simple",
                EnlacePagina = typeof(Inicio)               
            });

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Tabbed",
                EnlacePagina = typeof(InicioTabbed)
            });

            elementosMasterPage.Add(new ElementoMasterPageModel
            {
                Titulo = "Inicio Carrousel",
                EnlacePagina = typeof(InicioCarrousel)
            });

            listView = new ListView
            {
                ItemsSource = elementosMasterPage,
                ItemTemplate = new DataTemplate(() =>
                {
                    var texto = new TextCell();
                    texto.SetBinding(TextCell.TextProperty, "Titulo");
                    return texto;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.None
            };

            Padding = new Thickness(0, 0, 0, 0);
            Title = "Personal Organiser";
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };
        }
    }
}
