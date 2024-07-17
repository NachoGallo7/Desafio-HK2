using AseguradoraHK.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AseguradoraHK.Presentation
{
	public partial class ConsultarPolizas : Form
	{
		private DaoPoliza daoPoliza = new DaoPoliza();
		public ConsultarPolizas()
		{
			InitializeComponent();
		}

		private void ConsultarPolizas_Load(object sender, EventArgs e)
		{
			//Dao dao = new Dao();
			//if (dao.conectar())
			//{
			//	MessageBox.Show("ok");
			//}
			//else
			//{
			//	MessageBox.Show("nok");
			//}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			dgvDatos.DataSource = daoPoliza.BuscarAseguradosEnPoliza((int)nudNumeroPoliza.Value);
		}
	}
}
