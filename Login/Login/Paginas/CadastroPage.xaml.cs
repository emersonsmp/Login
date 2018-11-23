using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CadastroPage : ContentPage
	{
		public CadastroPage ()
		{
			InitializeComponent ();
		}

        public void ReturnAction(object sender, EventArgs args )
        {
            Navigation.PopModalAsync();
        }
    }
}