using System.Windows.Forms;
using Martium.FuneralServiceHistory.Database;

namespace Martium.FuneralServiceHistory
{
    public partial class ServiceListForm : Form
    {
        public ServiceListForm()
        {
            InitializeComponent();

            new DatabaseInitializer().InitializeDatabaseIfNotExist();
        }
    }
}
