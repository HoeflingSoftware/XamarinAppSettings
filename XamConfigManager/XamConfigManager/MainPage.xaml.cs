using Xamarin.Forms;

namespace XamConfigManager
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Message.Text = AppSettingsManager.Settings["service"];
        }
    }
}
