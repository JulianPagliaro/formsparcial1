namespace PRIMERPARCIAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnsuma = new Button();
            txtradio = new TextBox();
            txtaltura = new TextBox();
            dataGridView1 = new DataGridView();
            Area = new DataGridViewTextBoxColumn();
            Volumen = new DataGridViewTextBoxColumn();
            Contador = new DataGridViewTextBoxColumn();
            Radio = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnsuma
            // 
            btnsuma.Location = new Point(277, 36);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(75, 23);
            btnsuma.TabIndex = 0;
            btnsuma.Text = "Calcular";
            btnsuma.UseVisualStyleBackColor = true;
            btnsuma.Click += btnsuma_Click;
            // 
            // txtradio
            // 
            txtradio.Location = new Point(12, 36);
            txtradio.Name = "txtradio";
            txtradio.Size = new Size(100, 23);
            txtradio.TabIndex = 1;
            // 
            // txtaltura
            // 
            txtaltura.Location = new Point(142, 37);
            txtaltura.Name = "txtaltura";
            txtaltura.Size = new Size(100, 23);
            txtaltura.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Area, Volumen, Contador });
            dataGridView1.Location = new Point(12, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(340, 150);
            dataGridView1.TabIndex = 3;
            // 
            // Area
            // 
            Area.HeaderText = "Area";
            Area.Name = "Area";
            // 
            // Volumen
            // 
            Volumen.HeaderText = "Volumen";
            Volumen.Name = "Volumen";
            // 
            // Contador
            // 
            Contador.HeaderText = "Contador";
            Contador.Name = "Contador";
            // 
            // Radio
            // 
            Radio.AutoSize = true;
            Radio.Location = new Point(18, 11);
            Radio.Name = "Radio";
            Radio.Size = new Size(37, 15);
            Radio.TabIndex = 4;
            Radio.Text = "Radio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 10);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Altura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 302);
            Controls.Add(label1);
            Controls.Add(Radio);
            Controls.Add(dataGridView1);
            Controls.Add(txtaltura);
            Controls.Add(txtradio);
            Controls.Add(btnsuma);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsuma;
        private TextBox txtradio;
        private TextBox txtaltura;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Area;
        private DataGridViewTextBoxColumn Volumen;
        private DataGridViewTextBoxColumn Contador;
        private Label Radio;
        private Label label1;
    }
}