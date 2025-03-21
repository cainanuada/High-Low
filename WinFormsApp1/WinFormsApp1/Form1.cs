using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int contador = 24; 

        public Form1()
        {
            InitializeComponent();
            label2.Text = contador.ToString(); 
        }

        private void AtualizarContador(int valor)
        {
            contador += valor;
            label2.Text = contador.ToString();

            if (contador > 24 && contador < 32)
            {
                label2.ForeColor = Color.Yellow; 
            }
            else if (contador > 24 && contador >= 32)
            {
                label2.ForeColor = Color.Green;
            }
            else if (contador < 24)
            {
                label2.ForeColor = Color.Red; 
            }
            else
            {
                label2.ForeColor = Color.White; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AtualizarContador(1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AtualizarContador(1);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AtualizarContador(1);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AtualizarContador(1);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AtualizarContador(1);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AtualizarContador(0);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AtualizarContador(0);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AtualizarContador(0);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            AtualizarContador(-1);
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            AtualizarContador(-1);
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            AtualizarContador(-1);
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            AtualizarContador(-1);
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            AtualizarContador(-1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bitmap imagem = new Bitmap(Properties.Resources.green);
            imagem.MakeTransparent(Color.White); 
            pictureBox1.Image = imagem;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            contador = 24;
            AtualizarContador(0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
