using System.Threading.Tasks;

namespace NotasMatiasMonteros
{
    public partial class MainPage : ContentPage
    {
        private FileRepository _fileRepository;
        public MainPage()
        {
            _fileRepository = new FileRepository();
            InitializeComponent();
            CargarInformacionArchivo();
        }


        private async void CargarInformacionArchivo()
        {
            string texto = await _fileRepository.DevuelveInformacionArchivoAsync();
            LabelArchivo.Text = texto;
        }
        private async void BtnGuardarArchivo_Clicked(object sender, EventArgs e)
        {
            string texto = TxtArchivo.Text;
            await _fileRepository.GenerarArchivoAsync(texto);
            CargarInformacionArchivo();
        }
    }
}
