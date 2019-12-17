using Xamarin.Forms;

namespace TbiTest
{
  public class App : Application
  {
    public App()
    {
      MainPage = new NavigationPage(new MainPage());
    }
  }
}
