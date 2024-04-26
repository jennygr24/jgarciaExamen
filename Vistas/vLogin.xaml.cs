namespace jgarciaExamen.Vistas;

public partial class vLogin : ContentPage
{

    string[] user = { "estudiante2024", "examen1", "NombreEstudiante" };
    string[] pass = { "uisrael2024", "parcial1", "2024" };


    public vLogin()
    {
        InitializeComponent();
    }

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string userInicio = txtUser.Text;
        string passInicio = txtPass.Text;

        bool usuarioValido = false;

        for (int i = 0; i < user.Length; i++)
        {
            if (userInicio == user[i] && passInicio == pass[i])
            {
                usuarioValido = true;
                break;
            }
        }

        if (usuarioValido)
        {
            Navigation.PushAsync(new vRegistro(userInicio));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario/Contraseña incorrectos", "Cerrar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vAcerca());
    }
}