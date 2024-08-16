using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
            txtBox.Enabled = false;
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            object o1 = Eval(txtBox.Text).ToString();
            txtBox.Text = o1 as string;
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            txtBox.AppendText(btn.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
        }
        static object Eval(string expression)
        {
            DataTable dt = new DataTable();
            return dt.Compute(expression, string.Empty);
        }

        private void btnOperators_click(object sender, EventArgs e)
        {
            var Operator = (sender as Button).Text;
            txtBox.AppendText(Operator);
        }
    }
}
