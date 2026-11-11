namespace AdivinaElNumero.FE
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblTitulo = new Label();
            txtNumero = new TextBox();
            btnProbar = new Button();
            lblInstrucción = new Label();
            lblMensaje = new Label();
            lblIntentos = new Label();
            btnNuevoJuego = new Button();
            dgvHistorial = new DataGridView();
            colFecha = new DataGridViewTextBoxColumn();
            colInento = new DataGridViewTextBoxColumn();
            colNumero = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(22, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(130, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Adivina el numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(160, 58);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(75, 27);
            txtNumero.TabIndex = 2;
            // 
            // btnProbar
            // 
            btnProbar.Location = new Point(78, 97);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(94, 29);
            btnProbar.TabIndex = 3;
            btnProbar.Text = "Probar";
            btnProbar.UseVisualStyleBackColor = true;
            btnProbar.Click += btnProbar_Click;
            // 
            // lblInstrucción
            // 
            lblInstrucción.AutoSize = true;
            lblInstrucción.Location = new Point(22, 61);
            lblInstrucción.Name = "lblInstrucción";
            lblInstrucción.Size = new Size(132, 20);
            lblInstrucción.TabIndex = 4;
            lblInstrucción.Text = "ingresa tu número:";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(22, 139);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 20);
            lblMensaje.TabIndex = 5;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Location = new Point(22, 172);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(73, 20);
            lblIntentos.TabIndex = 6;
            lblIntentos.Text = "Intentos:0";
            // 
            // btnNuevoJuego
            // 
            btnNuevoJuego.Location = new Point(211, 97);
            btnNuevoJuego.Name = "btnNuevoJuego";
            btnNuevoJuego.Size = new Size(138, 29);
            btnNuevoJuego.TabIndex = 7;
            btnNuevoJuego.Text = "Nuevo Juego";
            btnNuevoJuego.UseVisualStyleBackColor = true;
            btnNuevoJuego.Click += btnNuevoJuego_Click;
            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistorial.Columns.AddRange(new DataGridViewColumn[] { colFecha, colInento, colNumero });
            dgvHistorial.Location = new Point(22, 195);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 51;
            dgvHistorial.Size = new Size(300, 188);
            dgvHistorial.TabIndex = 8;
            // 
            // colFecha
            // 
            colFecha.HeaderText = "Fecha";
            colFecha.MinimumWidth = 6;
            colFecha.Name = "colFecha";
            colFecha.ReadOnly = true;
            colFecha.Width = 125;
            // 
            // colInento
            // 
            colInento.HeaderText = "Intento";
            colInento.MinimumWidth = 6;
            colInento.Name = "colInento";
            colInento.ReadOnly = true;
            colInento.Width = 125;
            // 
            // colNumero
            // 
            colNumero.HeaderText = "Número";
            colNumero.MinimumWidth = 6;
            colNumero.Name = "colNumero";
            colNumero.ReadOnly = true;
            colNumero.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvHistorial);
            Controls.Add(btnNuevoJuego);
            Controls.Add(lblIntentos);
            Controls.Add(lblMensaje);
            Controls.Add(lblInstrucción);
            Controls.Add(btnProbar);
            Controls.Add(txtNumero);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label lblTitulo;
        private TextBox txtNumero;
        private Button btnProbar;
        private Label lblInstrucción;
        private Label lblMensaje;
        private Label lblIntentos;
        private Button btnNuevoJuego;
        private DataGridView dgvHistorial;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colInento;
        private DataGridViewTextBoxColumn colNumero;
    }
}
