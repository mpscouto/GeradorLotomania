using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_Lotomania
{
    public partial class frmGerador : Form
    {

        List<int> f_ltsNumeros = new List<int>();

        public frmGerador()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            f_ltsNumeros.Clear();
            f_ltsNumeros.AddRange(SorteiaNumerosSemRepetir(50, 0, 100));
            Carrega_Label();

        }

        private static int[] SorteiaNumerosSemRepetir(int quantidade, int minimo, int maximo)
        {
            // Validações dos argumentos.
            if (quantidade < 0)
                throw new ArgumentException("Quantidade deve ser maior que zero.");
            else if (quantidade > maximo + 1 - minimo)
                throw new ArgumentException("Quantidade deve ser menor do que a diferença entre máximo e mínimo.");
            else if (maximo <= minimo)
                throw new ArgumentException("Máximo deve ser maior do que mínimo.");

            List<int> numerosSorteados = new List<int>();

            while (numerosSorteados.Count < quantidade)
            {
                Random w_rnd1 = new Random();
                int numeroSorteado = w_rnd1.Next(minimo, maximo);

                // Número já foi sorteado? Então sorteamos novamente até o número não ter sido sorteado ainda.
                while (numerosSorteados.Contains(numeroSorteado))
                {
                    numeroSorteado = w_rnd1.Next(minimo, maximo);
                }
                    
                numerosSorteados.Add(numeroSorteado);
            }

            numerosSorteados.Sort(); // Ordena a lista
            return numerosSorteados.ToArray();
        }

        private void Carrega_Label()
        {
            try
            {
                int w_intCont = 1;
                List<Label> lbls = new List<Label>()
                {
                    lbl1,
                    lbl2,
                    lbl3,
                    lbl4,
                    lbl5,
                    lbl6,
                    lbl7,
                    lbl8,
                    lbl9,
                    lbl10,
                    lbl11,
                    lbl12,
                    lbl13,
                    lbl14,
                    lbl15,
                    lbl16,
                    lbl17,
                    lbl18,
                    lbl19,
                    lbl20,
                    lbl21,
                    lbl22,
                    lbl23,
                    lbl24,
                    lbl25,
                    lbl26,
                    lbl27,
                    lbl28,
                    lbl29,
                    lbl30,
                    lbl31,
                    lbl32,
                    lbl33,
                    lbl34,
                    lbl35,
                    lbl36,
                    lbl37,
                    lbl38,
                    lbl39,
                    lbl40,
                    lbl41,
                    lbl42,
                    lbl43,
                    lbl44,
                    lbl45,
                    lbl46,
                    lbl47,
                    lbl48,
                    lbl49,
                    lbl50
                };

                foreach (var lbl in lbls)
                {
                    lbl.Text = f_ltsNumeros[w_intCont -1].ToString();
                    w_intCont++;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmGerador_Load(object sender, EventArgs e)
        {

            try
            {

                List<Label> lbls = new List<Label>()
                {
                    lbl1,
                    lbl2,
                    lbl3,
                    lbl4,
                    lbl5,
                    lbl6,
                    lbl7,
                    lbl8,
                    lbl9,
                    lbl10,
                    lbl11,
                    lbl12,
                    lbl13,
                    lbl14,
                    lbl15,
                    lbl16,
                    lbl17,
                    lbl18,
                    lbl19,
                    lbl20,
                    lbl21,
                    lbl22,
                    lbl23,
                    lbl24,
                    lbl25,
                    lbl26,
                    lbl27,
                    lbl28,
                    lbl29,
                    lbl30,
                    lbl31,
                    lbl32,
                    lbl33,
                    lbl34,
                    lbl35,
                    lbl36,
                    lbl37,
                    lbl38,
                    lbl39,
                    lbl40,
                    lbl41,
                    lbl42,
                    lbl43,
                    lbl44,
                    lbl45,
                    lbl46,
                    lbl47,
                    lbl48,
                    lbl49,
                    lbl50
                };

                int w_intCont = 1;
                foreach (var lbl in lbls)
                {

                    lbl.Text = "";
                    w_intCont++;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
