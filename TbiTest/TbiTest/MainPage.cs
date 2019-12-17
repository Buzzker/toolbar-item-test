using Xamarin.Forms;

namespace TbiTest
{
  class MainPage : ContentPage
  {
    public MainPage()
    {
      Title = nameof(MainPage);
      ToolbarItems.Add(new ToolbarItem("Help", "ic_info", () => { }));
      ToolbarItems.Add(new ToolbarItem("Share", "ic_share", () => { }));
    }
  }
}
