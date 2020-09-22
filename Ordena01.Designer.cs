namespace Projeto_Grupo_D
{
    partial class Ordena01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgArray = new System.Windows.Forms.DataGridView();
            this.gbMetodos = new System.Windows.Forms.GroupBox();
            this.rbQuick = new System.Windows.Forms.RadioButton();
            this.rbMerge = new System.Windows.Forms.RadioButton();
            this.rbShell = new System.Windows.Forms.RadioButton();
            this.rbBubble = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbInsert = new System.Windows.Forms.RadioButton();
            this.numElementos = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdOrdena = new System.Windows.Forms.Button();
            this.cmdRetorna = new System.Windows.Forms.Button();
            this.lblTempo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTrocas = new System.Windows.Forms.Label();
            this.cmdGerar = new System.Windows.Forms.Button();
            this.cmdProximo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArray)).BeginInit();
            this.gbMetodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(246, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VETOR DE NÚMEROS ALEATÓRIOS";
            // 
            // dgArray
            // 
            this.dgArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArray.Location = new System.Drawing.Point(250, 134);
            this.dgArray.Name = "dgArray";
            this.dgArray.Size = new System.Drawing.Size(468, 219);
            this.dgArray.TabIndex = 1;
            // 
            // gbMetodos
            // 
            this.gbMetodos.Controls.Add(this.rbQuick);
            this.gbMetodos.Controls.Add(this.rbMerge);
            this.gbMetodos.Controls.Add(this.rbShell);
            this.gbMetodos.Controls.Add(this.rbBubble);
            this.gbMetodos.Controls.Add(this.rbSelect);
            this.gbMetodos.Controls.Add(this.rbInsert);
            this.gbMetodos.Location = new System.Drawing.Point(35, 134);
            this.gbMetodos.Name = "gbMetodos";
            this.gbMetodos.Size = new System.Drawing.Size(171, 256);
            this.gbMetodos.TabIndex = 2;
            this.gbMetodos.TabStop = false;
            this.gbMetodos.Text = "Métodos de Ordenação";
            // 
            // rbQuick
            // 
            this.rbQuick.AutoSize = true;
            this.rbQuick.Location = new System.Drawing.Point(21, 217);
            this.rbQuick.Name = "rbQuick";
            this.rbQuick.Size = new System.Drawing.Size(75, 17);
            this.rbQuick.TabIndex = 5;
            this.rbQuick.TabStop = true;
            this.rbQuick.Text = "Quick Sort";
            this.rbQuick.UseVisualStyleBackColor = true;
            // 
            // rbMerge
            // 
            this.rbMerge.AutoSize = true;
            this.rbMerge.Location = new System.Drawing.Point(21, 179);
            this.rbMerge.Name = "rbMerge";
            this.rbMerge.Size = new System.Drawing.Size(77, 17);
            this.rbMerge.TabIndex = 4;
            this.rbMerge.TabStop = true;
            this.rbMerge.Text = "Merge Sort";
            this.rbMerge.UseVisualStyleBackColor = true;
            // 
            // rbShell
            // 
            this.rbShell.AutoSize = true;
            this.rbShell.Location = new System.Drawing.Point(21, 144);
            this.rbShell.Name = "rbShell";
            this.rbShell.Size = new System.Drawing.Size(70, 17);
            this.rbShell.TabIndex = 3;
            this.rbShell.TabStop = true;
            this.rbShell.Text = "Shell Sort";
            this.rbShell.UseVisualStyleBackColor = true;
            // 
            // rbBubble
            // 
            this.rbBubble.AutoSize = true;
            this.rbBubble.Location = new System.Drawing.Point(21, 106);
            this.rbBubble.Name = "rbBubble";
            this.rbBubble.Size = new System.Drawing.Size(80, 17);
            this.rbBubble.TabIndex = 2;
            this.rbBubble.TabStop = true;
            this.rbBubble.Text = "Bubble Sort";
            this.rbBubble.UseVisualStyleBackColor = true;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(21, 69);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(77, 17);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select Sort";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbInsert
            // 
            this.rbInsert.AutoSize = true;
            this.rbInsert.Location = new System.Drawing.Point(21, 31);
            this.rbInsert.Name = "rbInsert";
            this.rbInsert.Size = new System.Drawing.Size(73, 17);
            this.rbInsert.TabIndex = 0;
            this.rbInsert.TabStop = true;
            this.rbInsert.Text = "Insert Sort";
            this.rbInsert.UseVisualStyleBackColor = true;
            // 
            // numElementos
            // 
            this.numElementos.Location = new System.Drawing.Point(205, 85);
            this.numElementos.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numElementos.Name = "numElementos";
            this.numElementos.Size = new System.Drawing.Size(120, 20);
            this.numElementos.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecione o número de elementos";
            // 
            // cmdOrdena
            // 
            this.cmdOrdena.Location = new System.Drawing.Point(131, 415);
            this.cmdOrdena.Name = "cmdOrdena";
            this.cmdOrdena.Size = new System.Drawing.Size(75, 23);
            this.cmdOrdena.TabIndex = 5;
            this.cmdOrdena.Text = "Ordenar";
            this.cmdOrdena.UseVisualStyleBackColor = true;
            this.cmdOrdena.Click += new System.EventHandler(this.cmdOrdena_Click);
            // 
            // cmdRetorna
            // 
            this.cmdRetorna.Location = new System.Drawing.Point(35, 415);
            this.cmdRetorna.Name = "cmdRetorna";
            this.cmdRetorna.Size = new System.Drawing.Size(75, 23);
            this.cmdRetorna.TabIndex = 6;
            this.cmdRetorna.Text = "Limpar";
            this.cmdRetorna.UseVisualStyleBackColor = true;
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(359, 377);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(0, 13);
            this.lblTempo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempo Gasto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(481, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trocas realizadas:";
            // 
            // lblTrocas
            // 
            this.lblTrocas.AutoSize = true;
            this.lblTrocas.Location = new System.Drawing.Point(625, 378);
            this.lblTrocas.Name = "lblTrocas";
            this.lblTrocas.Size = new System.Drawing.Size(0, 13);
            this.lblTrocas.TabIndex = 10;
            // 
            // cmdGerar
            // 
            this.cmdGerar.Location = new System.Drawing.Point(349, 85);
            this.cmdGerar.Name = "cmdGerar";
            this.cmdGerar.Size = new System.Drawing.Size(75, 23);
            this.cmdGerar.TabIndex = 11;
            this.cmdGerar.Text = "Gerar Vetor";
            this.cmdGerar.UseVisualStyleBackColor = true;
            this.cmdGerar.Click += new System.EventHandler(this.cmdGerar_Click);
            // 
            // cmdProximo
            // 
            this.cmdProximo.Location = new System.Drawing.Point(677, 415);
            this.cmdProximo.Name = "cmdProximo";
            this.cmdProximo.Size = new System.Drawing.Size(75, 23);
            this.cmdProximo.TabIndex = 12;
            this.cmdProximo.Text = "Próximo";
            this.cmdProximo.UseVisualStyleBackColor = true;
            this.cmdProximo.Click += new System.EventHandler(this.cmdProximo_Click);
            // 
            // Ordena01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdProximo);
            this.Controls.Add(this.cmdGerar);
            this.Controls.Add(this.lblTrocas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.cmdRetorna);
            this.Controls.Add(this.cmdOrdena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numElementos);
            this.Controls.Add(this.gbMetodos);
            this.Controls.Add(this.dgArray);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Ordena01";
            this.Text = "Ordenação de Vetores";
            ((System.ComponentModel.ISupportInitialize)(this.dgArray)).EndInit();
            this.gbMetodos.ResumeLayout(false);
            this.gbMetodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgArray;
        private System.Windows.Forms.GroupBox gbMetodos;
        private System.Windows.Forms.NumericUpDown numElementos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbQuick;
        private System.Windows.Forms.RadioButton rbMerge;
        private System.Windows.Forms.RadioButton rbShell;
        private System.Windows.Forms.RadioButton rbBubble;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbInsert;
        private System.Windows.Forms.Button cmdOrdena;
        private System.Windows.Forms.Button cmdRetorna;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTrocas;
        private System.Windows.Forms.Button cmdGerar;
        private System.Windows.Forms.Button cmdProximo;
    }
}

