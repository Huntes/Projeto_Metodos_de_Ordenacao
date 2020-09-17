using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Grupo_D
{
    public partial class Ordena01 : Form
    {
        public Ordena01()
        {
            InitializeComponent();
        }

        Sort O = new Sort();
        Random N = new Random();
        int guarda = 0;
        int[] T;
        int[] R;
        int[] V = { 5,4,3,2,1 };

        private void cmdGerar_Click(object sender, EventArgs e)
        {
            guarda = (int)numElementos.Value;
            T = new int[guarda];
            dgArray.RowCount = 1;
            dgArray.ColumnCount = guarda;

            T = new int[dgArray.ColumnCount];

            for (int i = 0; i < dgArray.ColumnCount; i++)
            {
                dgArray.Rows[0].Cells[i].Value = V[i];
                T[i] = (int)dgArray.Rows[0].Cells[i].Value;
            }
        }

        private void cmdOrdena_Click(object sender, EventArgs e)
        {
            var inicio = DateTime.Now;

            R = new int[guarda];
            var GB = gbMetodos.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked == true);
            if (GB.Text == "Insert Sort")
            {
                R = O.Insert_Sort(T);
            }
            else if (GB.Text == "Select Sort")
            {
                R = O.Select_Sort(T);
            }
            else if (GB.Text == "Bubble Sort")
            {
                R = O.BubbleSort(T);
            }
            else if (GB.Text == "Shell Sort")
            {
                R = O.Shell_Sort(T);
            }
            else if (GB.Text == "Merge Sort")
            {
                R = O.Merge_Sort(T);
            }
            else
                R = O.Quick_Sort(T);           
            
            int G = dgArray.Columns.Count;
            for (int i = 0; i < G; i++)
            {
                dgArray.Rows[0].Cells[i].Value = R[i];
            }
            lblTrocas.Text = O.troca.ToString();
            var fim = DateTime.Now;
            var Diferença = (fim - inicio).Milliseconds;
            lblTempo.Text = Diferença.ToString() + "  Milisegundos";
            
        }

    }
}
