using Xamarin.Forms;

namespace TrySlidingMenu
{
    public partial class TrySlidingMenuPage : MasterDetailPage
    {
        public TrySlidingMenuPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Page1());

            IsPresented = false;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page1());

            IsPresented = false;
        }

        void Handle_Clicked2(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page_2());

            IsPresented = false;
        }
    }
}
