using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();

            //guthub test
            //laptop test
        }

        async void translateButon_Clicked(object sender, EventArgs e)
        {
            var network = DependencyService.Get<INetwork>();

            string networkstatus = network.getNetwork();
            await this.DisplayAlert("Network", $"The network state is {networkstatus}", "ok");
        }
    }
}