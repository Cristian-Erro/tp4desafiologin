using tp4desafiologin.Views;

namespace tp4desafiologin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }
    }
}
