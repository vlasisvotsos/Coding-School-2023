using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WinForms.UserControlls;

namespace WinForms
{
    public partial class Form1 : Form
    {
        NavigationControl navigationControl;
        NavigationButtons navigationButtons;
        Color buttonDefaultColor = Color.FromKnownColor(KnownColor.ControlLight);
        Color buttonSelectedColor = Color.FromKnownColor(KnownColor.ControlDark);
        public Form1()
        {
            InitializeComponent();
            InitializeNavigationControll();
            InitializeNavigationButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeNavigationControll()
        {
            List<UserControl> userControls = new List<UserControl>()
            {
                new HomeControl(),
                new StaffControl(),
                new CashierControl(),
                new ManagerControl()
            };
            navigationControl = new NavigationControl(userControls, panel2);
            navigationControl.Display(0);
        }
        private void InitializeNavigationButton()
        {
            List<Button> buttons = new List<Button>()
            {
                 Homebtn,
                 Staffbtn,
                 Cashierbtn,
                 Managerbtn

            };

            navigationButtons = new NavigationButtons(buttons, buttonDefaultColor, buttonSelectedColor);
            navigationButtons.Highlight(Homebtn);

        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0);
            navigationButtons.Highlight(Homebtn);
        }

        private void Staffbtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(1);
            navigationButtons.Highlight(Staffbtn);
        }

        private void Cashierbtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(2);
            navigationButtons.Highlight(Cashierbtn);
        }

        private void Managerbtn_Click(object sender, EventArgs e)
        {
            navigationControl.Display(3);
            navigationButtons.Highlight(Managerbtn);
        }
    }
}