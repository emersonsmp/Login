using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Login.Paginas;
using Login.Servico.Modelo;
using Login.Servico;

namespace Login.Paginas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{

		public LoginPage()
		{
			InitializeComponent ();
            BOTAO.Clicked += GoLogin;
        }

        public void GoLogin(object sender, EventArgs args)
        {
            Resposta end;

            //VALIDACOES
            if (string.IsNullOrWhiteSpace(EmailEntry.Text) == false && string.IsNullOrWhiteSpace(PassEntry.Text) == false)
            {
                string password = PassEntry.Text.Trim();
                string email = EmailEntry.Text.Trim();

                //EXCEÇÕES--------------------------------------------------------------
                try { 
                    end = LoginServico.LoginJson(email, password);

                    if (end.Success == "true")
                    {
                        App.Current.MainPage = new NavigationPage(new PerfilPage(end));
                    }
                    else
                    {
                        DisplayAlert("Alerta", "Erro senha ou email", "OK");
                    }
                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO:", e.Message, "OK");
                }
                //-----------------------------------------------------------------------
            }
            else
            {
                DisplayAlert("Alerta", "Campos não podem ficar em branco", "OK");
            }
          

        }

        public void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            DisplayAlert("Alerta", "You have been alerted", "OK");
        }

   
        public void GoRegistro(object sender, EventArgs args)
        {
            //Navigation.PushAsync(new CadastroPage());
            Navigation.PushModalAsync(new CadastroPage());
        }


    }
}