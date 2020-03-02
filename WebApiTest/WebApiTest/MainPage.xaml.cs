using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebApiTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //Servicio consumido: https://jsonplaceholder.typicode.com/photos
    //Instalar JsonProperty, para cuando viene en minuscula las propiedades.
    //Instalar Microsft.Net.Http
    //Crea las propiedades: http://json2csharp.com/
    //Convierte en formato Json ordenado: http://jsonviewer.stack.hu/
    //Convierte de Json a C# usando array: https://app.quicktype.io/
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetFotos();
        }

        private async void GetFotos()
        {
            HttpClient cliente = new HttpClient();
            var response = await cliente.GetStringAsync("https://jsonplaceholder.typicode.com/photos");
            var archivo = JsonConvert.DeserializeObject<List<PhotoModel>>(response);

            listaFotos.ItemsSource = archivo;
        }
    }
}
