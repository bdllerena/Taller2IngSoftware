using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EspePocket.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reglamento : ContentPage
    {
        public Reglamento()
        {
            Title = "Reglamentos";
            var browser = new CustomWebView
            {
                Uri = "https://goo.gl/wjpD7L",
            };
              Content = browser;
           
            
        }
    }

}
