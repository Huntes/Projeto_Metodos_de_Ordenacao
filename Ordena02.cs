using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Grupo_D
{
    public partial class Ordena02 : Form
    {
        public Ordena02()
        {
            InitializeComponent();
        }

        Sort S = new Sort();
        Random P = new Random();
        int TAM = 10000;
        int[] vetorDezmil;

        private void cmdGerar10_Click(object sender, EventArgs e)
        {
            vetorDezmil = new int[TAM];

            for (int i = 0; i < TAM; i++)
            {
                vetorDezmil[i] = P.Next(1, 100000);
            }
            MessageBox.Show("Vetor Gerado com sucesso !");
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            S.Insert_Sort(vetorDezmil);
            tempo.Stop();
            label2.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label3.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            S.Select_Sort(vetorDezmil);
            tempo.Stop();
            label4.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label5.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdBubble_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            S.BubbleSort(vetorDezmil);
            tempo.Stop();
            label6.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label7.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdShell_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            S.ShellSort(vetorDezmil);
            tempo.Stop();
            label8.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label9.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdMerge_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            S.Merge_Sort(vetorDezmil);
            tempo.Stop();
            label10.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label11.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdQuick_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            S.Quick_Sort(vetorDezmil);
            tempo.Stop();
            label12.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label13.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }
    }
}
