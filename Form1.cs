using System.Windows.Forms;
using System.Runtime.InteropServices;
using CuteKeypadUI.resources.forms;

namespace CuteKeypadUI
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Form currentChildForm;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 24, 24));

        }

        private void ActivateButton(object button, Color color)
        {
            if (button != null)
            {
                currentButton = (Button)button;
                currentButton.BackColor = Color.FromArgb(32, 32, 32);
                currentButton.ForeColor = Color.White;

                PanelNav.BackColor = color;
                PanelNav.Height = currentButton.Height;
                PanelNav.Top = currentButton.Top;
            }
        }

        private void ReleaseButton(object button, Color color)
        {
            if (button != null)
            {
                currentButton = (Button)button;
                currentButton.BackColor = Color.FromArgb(24, 24, 24);
                currentButton.ForeColor = color;

                PanelNav.BackColor = Color.Transparent;
                PanelNav.Height = currentButton.Height;
                PanelNav.Top = currentButton.Top;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PanelNav.Height = ButtonBindings.Height;
            PanelNav.Top = ButtonBindings.Top;
            PanelNav.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBindings_Click(object sender, EventArgs e)
        {
            ActivateButton(ButtonBindings, Color.DarkOrange);
            OpenChildForm(new FormBindings());
        }

        private void ButtonLights_Click(object sender, EventArgs e)
        {
            ActivateButton(ButtonLights, Color.Orange);
            OpenChildForm(new FormLights());
        }

        private void ButtonDistance_Click(object sender, EventArgs e)
        {
            ActivateButton(ButtonDistance, Color.Gold);
        }

        private void ButtonActivation_Click(object sender, EventArgs e)
        {
            ActivateButton(ButtonActivation, Color.Yellow);
        }

        private void PanelNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ButtonBindings_Leave(object sender, EventArgs e)
        {
            ReleaseButton(ButtonBindings, Color.DarkOrange);
        }

        private void ButtonLights_Leave(object sender, EventArgs e)
        {
            ReleaseButton(ButtonLights, Color.Orange);
        }

        private void ButtonDistance_Leave(object sender, EventArgs e)
        {
            ReleaseButton(ButtonDistance, Color.Gold);
        }

        private void ButtonActivation_Leave(object sender, EventArgs e)
        {
            ReleaseButton(ButtonActivation, Color.Yellow);
        }

        private void ButtonQuit_Click(object sender, EventArgs e)
        {
            ActivateButton(ButtonQuit, Color.OrangeRed);
            Close();
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            ReleaseButton(ButtonBindings, Color.DarkOrange);
            ReleaseButton(ButtonLights, Color.Orange);
            ReleaseButton(ButtonDistance, Color.Gold);
            ReleaseButton(ButtonActivation, Color.Yellow);
        }

        private void Quit_MouseHover(object sender, EventArgs e)
        {

        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        private void PanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}