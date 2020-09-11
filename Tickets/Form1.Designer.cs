namespace Tickets
{
    partial class Form1
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
            this.btnRodar = new System.Windows.Forms.Button();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVItems = new System.Windows.Forms.DataGridView();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniqueValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGVResultado = new System.Windows.Forms.DataGridView();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorTicket = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalGanhoItens = new System.Windows.Forms.TextBox();
            this.txtTotalGasto = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.btnZerar = new System.Windows.Forms.Button();
            this.cbListaTicketsPromo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRodar
            // 
            this.btnRodar.Location = new System.Drawing.Point(978, 119);
            this.btnRodar.Name = "btnRodar";
            this.btnRodar.Size = new System.Drawing.Size(103, 23);
            this.btnRodar.TabIndex = 3;
            this.btnRodar.Text = "Inserir ticket(s)";
            this.btnRodar.UseVisualStyleBackColor = true;
            this.btnRodar.Click += new System.EventHandler(this.btnRodar_Click);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(978, 84);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(134, 20);
            this.txtQtd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(862, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dGVItems
            // 
            this.dGVItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quantidade,
            this.Item,
            this.Porcentagem,
            this.uniqueValue});
            this.dGVItems.Location = new System.Drawing.Point(12, 40);
            this.dGVItems.Name = "dGVItems";
            this.dGVItems.Size = new System.Drawing.Size(441, 446);
            this.dGVItems.TabIndex = 10;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Porcentagem
            // 
            this.Porcentagem.HeaderText = "Porcentagem";
            this.Porcentagem.Name = "Porcentagem";
            // 
            // uniqueValue
            // 
            this.uniqueValue.HeaderText = "Valor(1=1kk)";
            this.uniqueValue.Name = "uniqueValue";
            // 
            // dGVResultado
            // 
            this.dGVResultado.AllowUserToAddRows = false;
            this.dGVResultado.AllowUserToDeleteRows = false;
            this.dGVResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qtd,
            this.Items,
            this.Valor});
            this.dGVResultado.Location = new System.Drawing.Point(477, 37);
            this.dGVResultado.Name = "dGVResultado";
            this.dGVResultado.Size = new System.Drawing.Size(336, 449);
            this.dGVResultado.TabIndex = 11;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Quantidade";
            this.Qtd.Name = "Qtd";
            // 
            // Items
            // 
            this.Items.HeaderText = "Item";
            this.Items.Name = "Items";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor(1=1kk)";
            this.Valor.Name = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de Itens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(472, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Drops";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(840, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Valor do Ticket:";
            // 
            // txtValorTicket
            // 
            this.txtValorTicket.Location = new System.Drawing.Point(978, 55);
            this.txtValorTicket.Name = "txtValorTicket";
            this.txtValorTicket.Size = new System.Drawing.Size(134, 20);
            this.txtValorTicket.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(840, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total ganho itens:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(922, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lucro:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(883, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total gasto:";
            // 
            // txtTotalGanhoItens
            // 
            this.txtTotalGanhoItens.Enabled = false;
            this.txtTotalGanhoItens.Location = new System.Drawing.Point(981, 186);
            this.txtTotalGanhoItens.Name = "txtTotalGanhoItens";
            this.txtTotalGanhoItens.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGanhoItens.TabIndex = 19;
            // 
            // txtTotalGasto
            // 
            this.txtTotalGasto.Enabled = false;
            this.txtTotalGasto.Location = new System.Drawing.Point(981, 226);
            this.txtTotalGasto.Name = "txtTotalGasto";
            this.txtTotalGasto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalGasto.TabIndex = 20;
            // 
            // txtLucro
            // 
            this.txtLucro.Enabled = false;
            this.txtLucro.Location = new System.Drawing.Point(981, 269);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Size = new System.Drawing.Size(100, 20);
            this.txtLucro.TabIndex = 21;
            // 
            // btnZerar
            // 
            this.btnZerar.Location = new System.Drawing.Point(366, 11);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(87, 23);
            this.btnZerar.TabIndex = 23;
            this.btnZerar.Text = "Zerar Lista";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // cbListaTicketsPromo
            // 
            this.cbListaTicketsPromo.FormattingEnabled = true;
            this.cbListaTicketsPromo.Items.AddRange(new object[] {
            "Ticket Promoção 09/20"});
            this.cbListaTicketsPromo.Location = new System.Drawing.Point(140, 13);
            this.cbListaTicketsPromo.Name = "cbListaTicketsPromo";
            this.cbListaTicketsPromo.Size = new System.Drawing.Size(220, 21);
            this.cbListaTicketsPromo.TabIndex = 24;
            this.cbListaTicketsPromo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(976, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "(1=1kk)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(858, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(266, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Desenvolvido por: Igor Souza Pontes (TaiLung Store\'s)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 498);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbListaTicketsPromo);
            this.Controls.Add(this.btnZerar);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txtTotalGasto);
            this.Controls.Add(this.txtTotalGanhoItens);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGVResultado);
            this.Controls.Add(this.dGVItems);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.btnRodar);
            this.Name = "Form1";
            this.Text = "Máquina de Tickets ";
            ((System.ComponentModel.ISupportInitialize)(this.dGVItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRodar;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVItems;
        private System.Windows.Forms.DataGridView dGVResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorTicket;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalGanhoItens;
        private System.Windows.Forms.TextBox txtTotalGasto;
        private System.Windows.Forms.TextBox txtLucro;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.ComboBox cbListaTicketsPromo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniqueValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

