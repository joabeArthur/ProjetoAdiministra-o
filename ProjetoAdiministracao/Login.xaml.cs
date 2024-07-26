using Microsoft.Maui.Controls;

namespace ProjetoAdiministracao
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void OnConfirmarClicked(object sender, EventArgs e)
        {
            string email = EmailEntry.Text;
            string senha = SenhaEntry.Text;

            // Lógica de validação e processamento do login
            if (IsValidLogin(email, senha))
            {
                DisplayAlert("Sucesso", "Login realizado com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Email ou senha inválidos", "OK");
            }
        }

        private bool IsValidLogin(string email, string senha)
        {
            // Adicione sua lógica de validação aqui
            return !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha);
        }
    }
}
