namespace jgarciaExamen.Vistas;

public partial class vRegistro : ContentPage
{

   

    public vRegistro(string usuario)
    {
        InitializeComponent();
        usuario = usuario;
        DisplayAlert("Alerta", "Bienvenido " + usuario, "Cerrar");
        lblUser.Text = "Usuario conectado: " + usuario;

    }

    private void btnCalcularM_Clicked(object sender, EventArgs e)
    {
        const double costoUniversidad = 1500;
        double mInicioValor;
        if (!double.TryParse(mInicial.Text, out mInicioValor) || mInicioValor <= 0 || mInicioValor >= costoUniversidad)
        {
            DisplayAlert("Error", "El monto inicial debe ser mayor que 0 y menor que el costo total $1500.", "Cerrar");
            return;
        }

        double saldoPagar = costoUniversidad - mInicioValor;
        double cuotasinInteres = saldoPagar / 4;
        double cuotaconInteres = cuotasinInteres + (costoUniversidad * 0.04);

        pMensual.Text = cuotaconInteres.ToString("F2");

     
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        if (paisPk.SelectedIndex == -1)
        {
            DisplayAlert("Alerta", "Debe seleccionar un estudiante.", "Cerrar");
            return;
        }

        

        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string edad = txtEdad.Text;
        string fecha = fechaPk.Date.ToString("yyyy-MM-dd");
        
        string pais = paisPk.Items[paisPk.SelectedIndex].ToString();
        string ciudad = ciudadPk.Items[ciudadPk.SelectedIndex].ToString();
        
        string mIniciall = mInicial.Text;
        string pMensuall = pMensual.Text;
       

        vResumen resumenPage = new vResumen(nombre, apellido, edad, fecha, pais, ciudad, mIniciall, pMensuall);
        Navigation.PushAsync(resumenPage);
    }
}