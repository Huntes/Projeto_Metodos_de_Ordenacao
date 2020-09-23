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
        int[] insert = new int[10000];
        int[] select = new int[10000];
        int[] bubble = new int[10000];
        int[] shell  = new int[10000];
        int[] merge  = new int[10000];
        int[] quick  = new int[10000];

        private void cmdGerar10_Click(object sender, EventArgs e)
        {
            vetorDezmil = new int[TAM];
            for (int i = 0; i < TAM; i++)
            {
                vetorDezmil[i] = P.Next(1, 10000);
            }
            MessageBox.Show("Vetor Gerado com sucesso !");
        }

        private void cmdInsert_Click(object sender, EventArgs e)
        {           
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            for (int i = 0; i < vetorDezmil.Length; i++)
            {
                insert[i] = vetorDezmil[i];
            }
            S.Insert_Sort(insert);
            tempo.Stop();
            label2.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label3.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdSelect_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            for (int i = 0; i < vetorDezmil.Length; i++)
            {
                select[i] = vetorDezmil[i];
            }
            S.Select_Sort(select);
            tempo.Stop();
            label4.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label5.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdBubble_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            for (int i = 0; i < vetorDezmil.Length; i++)
            {
                bubble[i] = vetorDezmil[i];
            }
            S.BubbleSort(bubble);
            tempo.Stop();
            label6.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label7.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdShell_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            for (int i = 0; i < vetorDezmil.Length; i++)
            {
                shell[i] = vetorDezmil[i];
            }
            S.ShellSort(shell);
            tempo.Stop();
            label8.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label9.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdMerge_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            for (int i = 0; i < vetorDezmil.Length; i++)
            {
                merge[i] = vetorDezmil[i];
            }
            S.Merge_Sort(merge);
            tempo.Stop();
            label10.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label11.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }

        private void cmdQuick_Click(object sender, EventArgs e)
        {
            Stopwatch tempo = new Stopwatch();
            tempo.Start();
            for (int i = 0; i < vetorDezmil.Length; i++)
            {
                quick[i] = vetorDezmil[i];
            }
            S.Quick_Sort(quick);
            tempo.Stop();
            label12.Text = tempo.ElapsedMilliseconds.ToString() + " Ms";
            label13.Text = S.troca.ToString() + " Trocas";
            S.troca = 0;
        }
    }
}
