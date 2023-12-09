namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
        /*(1)*/
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int resultado = Soma(n1, n2);
            // chamando a variável (resultado) $ Sinal de interpolação
            MessageBox.Show($"O resultado da soma foi: {resultado}");
            Soma(n1, n2);
        }
        /*(2)*/
        public static int Soma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
