using System.Windows.Forms;

namespace RomanCalculator
{
    public partial class wndException : Form
    {
        public wndException()
        {
            InitializeComponent();
        }

        public string GoodText { get; set; }
        public string BadText { get; set; }

        private void wndException_Shown(object sender, System.EventArgs e)
        {
            lblException.Text = "Je probeerde " + BadText + ", maar je bedoelde " + GoodText;
        }
    }
}
