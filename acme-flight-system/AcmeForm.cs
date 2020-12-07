using System.Windows.Forms;

namespace acme_flight_system
{
    public partial class AcmeForm : Form
    {
        private DataBaseManager dataBaseManager;
        public AcmeForm()
        {
            InitializeComponent();
            dataBaseManager = new DataBaseManager("acme_database");
            PopulateFlightDataGridView();
        }

        public async void PopulateFlightDataGridView()
        {
            flightDataGridView.DataSource = await dataBaseManager.ResgataTodosRegistrosDeVoos();
        }
    }
}
