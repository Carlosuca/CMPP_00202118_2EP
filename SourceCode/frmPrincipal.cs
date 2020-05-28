using System.Windows.Forms;

namespace SourceCode
{
    public partial class frmPrincipal : Form
    {
        private Usuario  username;
        public frmPrincipal(Usuario pUsuario)
        {
            InitializeComponent();
            username = pUsuario;
        }
    }
}