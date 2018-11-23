using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login.Servico.Modelo;

namespace Login.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PerfilPage : ContentPage
	{
        private static string EnderecoURL = "https://smpsolutions.000webhostapp.com/Images/{0}";

        public PerfilPage (Resposta resposta)
		{
			InitializeComponent ();

            LabelName.Text = resposta.Name;

            string NovoEnderecoURL = string.Format(EnderecoURL, resposta.Image);

            LabelImage.Source = NovoEnderecoURL;

         }

        
	}
}