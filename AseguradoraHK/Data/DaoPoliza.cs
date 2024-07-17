using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AseguradoraHK.Data
{
	class DaoPoliza
	{
		public SqlDataReader Tabla { get; set; }
		public Dao Dao { get; set; } = new Dao();

		public SqlDataReader BuscarAseguradosEnPoliza(int idPoliza)
		{
			//String query = "USP_ASEGURADOS_EN_POLIZA";
			String query = "EXEC USP_ASEGURADOS_EN_POLIZA " + idPoliza;
			//List<SqlParameter> parametros = new List<SqlParameter>();
			//SqlParameter parametro = new SqlParameter("@poliza_id", idPoliza);
			//parametro.SqlDbType = System.Data.SqlDbType.Int;
			//parametros.Add(parametro);
			return Dao.reader(query);
		}
	}
}
