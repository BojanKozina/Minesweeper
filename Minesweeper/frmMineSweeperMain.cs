namespace Minesweeper
{
    public partial class frmMinesweeperMain : Form
    {
        public frmMinesweeperMain()
        {
            InitializeComponent();
        }

        private void frmMinesweeperMain_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //MakeHover
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            //MakeIconsChange
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbMineSweeperLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
