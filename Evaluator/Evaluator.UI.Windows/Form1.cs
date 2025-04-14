using Evaluator.Logic;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "7";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "4";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "3";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "9";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "1";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "8";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "6";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += ".";
        }

        private void btnOpenparenthesis_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "(";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "+";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "/";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "*";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = txtdisplay.Text.Substring(0, txtdisplay.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = string.Empty;
        }

        private void btnCloseparenthesis_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += ")";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "^";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            txtdisplay.Text += "-";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtdisplay.Text;
                double result = FunctionEvaluator.Evalute(expression);
                txtdisplay.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la expresión: " + ex.Message);
            }
        }
    }

}






   