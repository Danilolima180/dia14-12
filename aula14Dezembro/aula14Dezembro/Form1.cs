using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula14Dezembro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class ChecaForcaSenha
        {

            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas +
                    pontosPorMaiusculas + pontosPorDigitos +
                    pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 7;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 6;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }

            public ForcaDaSenha GetForcaDaSenha(string senha) //classe 
            {
                int placar = geraPontosSenha(senha);//variavel inteiro com nome placar recebe valor de geraPontos(senha)

                if (placar < 50) //se placar for menor que "50"
                    return ForcaDaSenha.Inaceitavel;// imprima na tela o valor "aceitavel"
                else if (placar < 60) //senao se placar menor que "60" 
                    return ForcaDaSenha.Fraca;// imprima na tela o valor "Fraca" 
                else if (placar < 80)//senao se valor menor que "80"
                    return ForcaDaSenha.Aceitavel;//imprime valor "aceitavel"
                else if (placar < 100)//senao se valor de placar menor que "100"
                    return ForcaDaSenha.Forte;//imprime na tela o valor "Forte"
                else //senao 
                    return ForcaDaSenha.Segura; //imprime o valor Segura""
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            inputSenha.Text = "";// usado para apagar os textos digitados 
            labelMensagem.Text = "";//usado para apagar a mensagem 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void verificarCaracter(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new ChecaForcaSenha();//verifica o metodo "checaForcaSenha"
            ChecaForcaSenha.ForcaDaSenha forca;//checaForcaSenha acessa ForcaDaSenha e coloca o valor em forca
            forca = verifica.GetForcaDaSenha(inputSenha.Text);//forca recebe o valor verifica.getForcaDaSenha
            labelMensagem.Text = forca.ToString();//aparece na tela o valor da conta feita no forca
        }
    }
}
