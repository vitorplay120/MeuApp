using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento_App.Services;
using Treinamento_App.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Treinamento_App.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public string Usuario = "";
        public string Senha = "";
        public Login()
        {
            InitializeComponent();
        }

        void SalvarUsuario(object sender, TextChangedEventArgs e) {

            var entry = (Entry)sender;

            Usuario = entry.Text;
        
        }

        void SalvarUsuarioCompleted(object sender, EventArgs e)
        {

            var entry = (Entry)sender;

            Usuario = entry.Text;

        }

        void SalvarSenha(object sender, TextChangedEventArgs e)
        {

            var entry = (Entry)sender;

            Senha = entry.Text;

        }

        void SalvarSenhaCompleted(object sender, EventArgs e)
        {

            var entry = (Entry)sender;

            Senha = entry.Text;

        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            string method = "Usuario/CadastrarUsuario/?Usuario="+Usuario+"&Senha="+Senha;

            Client cliente = new Client();

            cliente.GET(method);

            Response response = cliente.ResponseAPI;

            if (response != null && !response.erro) {
                await Navigation.PushAsync(new PaginaInicio());
            }
            
        }

    }
}