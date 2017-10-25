using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        public void OnDoneButtonClicked(object sender, EventArgs args)
        {

            ((App)Application.Current).SwitchTheme();

        }

        public async void MiEspe(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new miEspe());

        }

       
        public async void Reglamento(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Reglamento());
        }
        public async void Utilidades(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Utilidad());
        }
        public async void Carreras(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Carreras());
        }
        public async void Matriculacion(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Matriculacion());
        }
        public async void Preguntas(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Preguntas());
        }
    }
}