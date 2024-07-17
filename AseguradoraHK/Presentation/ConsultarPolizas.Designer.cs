namespace AseguradoraHK.Presentation
{
	partial class ConsultarPolizas
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
			lblTitulo = new Label();
			lblPolizaId = new Label();
			nudNumeroPoliza = new NumericUpDown();
			btnBuscar = new Button();
			lblProducto = new Label();
			lblTipoProducto = new Label();
			lblEstado = new Label();
			dgvDatos = new DataGridView();
			colAseguradoId = new DataGridViewTextBoxColumn();
			colAseguradoDni = new DataGridViewTextBoxColumn();
			colAseguradoNombre = new DataGridViewTextBoxColumn();
			colAseguradoEdad = new DataGridViewTextBoxColumn();
			colEliminar = new DataGridViewButtonColumn();
			lblTituloDgv = new Label();
			((System.ComponentModel.ISupportInitialize)nudNumeroPoliza).BeginInit();
			((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
			SuspendLayout();
			// 
			// lblTitulo
			// 
			lblTitulo.AutoSize = true;
			lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
			lblTitulo.Location = new Point(12, 9);
			lblTitulo.Name = "lblTitulo";
			lblTitulo.Size = new Size(64, 25);
			lblTitulo.TabIndex = 0;
			lblTitulo.Text = "Póliza";
			// 
			// lblPolizaId
			// 
			lblPolizaId.AutoSize = true;
			lblPolizaId.Location = new Point(27, 56);
			lblPolizaId.Name = "lblPolizaId";
			lblPolizaId.Size = new Size(21, 15);
			lblPolizaId.TabIndex = 1;
			lblPolizaId.Text = "ID:";
			// 
			// nudNumeroPoliza
			// 
			nudNumeroPoliza.Location = new Point(54, 54);
			nudNumeroPoliza.Name = "nudNumeroPoliza";
			nudNumeroPoliza.Size = new Size(120, 23);
			nudNumeroPoliza.TabIndex = 3;
			// 
			// btnBuscar
			// 
			btnBuscar.Location = new Point(197, 52);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(75, 23);
			btnBuscar.TabIndex = 4;
			btnBuscar.Text = "Buscar";
			btnBuscar.UseVisualStyleBackColor = true;
			btnBuscar.Click += btnBuscar_Click;
			// 
			// lblProducto
			// 
			lblProducto.AutoSize = true;
			lblProducto.Location = new Point(27, 94);
			lblProducto.Name = "lblProducto";
			lblProducto.Size = new Size(120, 15);
			lblProducto.TabIndex = 5;
			lblProducto.Text = "Producto: Producto 1";
			// 
			// lblTipoProducto
			// 
			lblTipoProducto.AutoSize = true;
			lblTipoProducto.Location = new Point(27, 125);
			lblTipoProducto.Name = "lblTipoProducto";
			lblTipoProducto.Size = new Size(120, 15);
			lblTipoProducto.TabIndex = 6;
			lblTipoProducto.Text = "Tipo Producto: Tipo 1";
			// 
			// lblEstado
			// 
			lblEstado.AutoSize = true;
			lblEstado.Location = new Point(27, 154);
			lblEstado.Name = "lblEstado";
			lblEstado.Size = new Size(82, 15);
			lblEstado.TabIndex = 7;
			lblEstado.Text = "Estado: Activo";
			// 
			// dgvDatos
			// 
			dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colAseguradoId, colAseguradoDni, colAseguradoNombre, colAseguradoEdad, colEliminar });
			dgvDatos.EditMode = DataGridViewEditMode.EditProgrammatically;
			dgvDatos.Location = new Point(27, 252);
			dgvDatos.Name = "dgvDatos";
			dgvDatos.Size = new Size(733, 165);
			dgvDatos.TabIndex = 8;
			// 
			// colAseguradoId
			// 
			colAseguradoId.HeaderText = "Id";
			colAseguradoId.Name = "colAseguradoId";
			colAseguradoId.ReadOnly = true;
			// 
			// colAseguradoDni
			// 
			colAseguradoDni.HeaderText = "Dni";
			colAseguradoDni.Name = "colAseguradoDni";
			colAseguradoDni.ReadOnly = true;
			// 
			// colAseguradoNombre
			// 
			colAseguradoNombre.HeaderText = "Nombre";
			colAseguradoNombre.Name = "colAseguradoNombre";
			colAseguradoNombre.ReadOnly = true;
			// 
			// colAseguradoEdad
			// 
			colAseguradoEdad.HeaderText = "Edad";
			colAseguradoEdad.Name = "colAseguradoEdad";
			colAseguradoEdad.ReadOnly = true;
			// 
			// colEliminar
			// 
			colEliminar.HeaderText = "Eliminar";
			colEliminar.Name = "colEliminar";
			// 
			// lblTituloDgv
			// 
			lblTituloDgv.AutoSize = true;
			lblTituloDgv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblTituloDgv.Location = new Point(27, 225);
			lblTituloDgv.Name = "lblTituloDgv";
			lblTituloDgv.Size = new Size(116, 15);
			lblTituloDgv.TabIndex = 9;
			lblTituloDgv.Text = "Lista de Asegurados";
			// 
			// ConsultarPolizas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lblTituloDgv);
			Controls.Add(dgvDatos);
			Controls.Add(lblEstado);
			Controls.Add(lblTipoProducto);
			Controls.Add(lblProducto);
			Controls.Add(btnBuscar);
			Controls.Add(nudNumeroPoliza);
			Controls.Add(lblPolizaId);
			Controls.Add(lblTitulo);
			Name = "ConsultarPolizas";
			Text = "ConsultarPolizas";
			Load += ConsultarPolizas_Load;
			((System.ComponentModel.ISupportInitialize)nudNumeroPoliza).EndInit();
			((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblTitulo;
		private Label lblPolizaId;
		private NumericUpDown nudNumeroPoliza;
		private Button btnBuscar;
		private Label lblProducto;
		private Label lblTipoProducto;
		private Label lblEstado;
		private DataGridView dgvDatos;
		private Label lblTituloDgv;
		private DataGridViewTextBoxColumn colAseguradoId;
		private DataGridViewTextBoxColumn colAseguradoDni;
		private DataGridViewTextBoxColumn colAseguradoNombre;
		private DataGridViewTextBoxColumn colAseguradoEdad;
		private DataGridViewButtonColumn colEliminar;
	}
}