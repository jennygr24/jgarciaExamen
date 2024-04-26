namespace jgarciaExamen.Vistas;

public partial class vResumen : ContentPage
{
    public vResumen(string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoInicial, string pagoMensual)
    {
        InitializeComponent();

        nombre1.Text = nombre;
        apellido1.Text = apellido;
        edad1.Text = edad;
        fecha1.Text = fecha;
        pais1.Text = pais;
        ciudad1.Text = ciudad;
        montoInicial1.Text = montoInicial;
        pagoMensual1.Text = pagoMensual;

        double mInicial = Convert.ToDouble(montoInicial);
        double pMensual = Convert.ToDouble(pagoMensual);
        double cuotasTotales = 4; 
        double pagoTotal = (pMensual * cuotasTotales) + mInicial;
        pagoTotal1.Text = pagoTotal.ToString();
    }

    private async void Cerrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}