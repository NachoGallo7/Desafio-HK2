using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AseguradoraHK.Data
{
	class Dao
	{

		private SqlConnection conexion;

		public Boolean conectar()
		{
			Boolean salida = false;
			conexion = new SqlConnection();
			conexion.ConnectionString = "Data Source=Nacho-Haier\\SQLDEV2022;Initial Catalog=ASEGURADORA_HK;Integrated Security=True;Encrypt=False";
			try
			{
				conexion.Open();
				salida = true;
			}
			catch
			{
				MessageBox.Show("Error: No se pudo hacer conexión con la base de datos.");
			}
			return salida;
		}

		public void desconectar()
		{
			if(conexion.State == System.Data.ConnectionState.Open)
			{
				conexion.Close();
			}
		}

		public SqlDataReader reader (String query)
		{
			conectar();

			SqlDataReader tabla;
			SqlCommand comando = new SqlCommand
			{
				CommandText = query,
				//CommandText = "EXEC " + query,
				Connection = conexion
			};
			//foreach (SqlParameter parameter in parameters)
			//{
			//	comando.Parameters.Add(parameter.ParameterName, parameter.SqlDbType).Value = parameter.Value;
			//	//comando.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
			//}
			tabla = comando.ExecuteReader();
			desconectar();
			return tabla;
		}

		public void ejecutarNoQuery(String query)
		{
			conectar();
			SqlCommand comando = new SqlCommand
			{
				CommandText = "Exec " + query,
				Connection = conexion
			};

			comando.ExecuteNonQuery();
			desconectar();
		}
	}
}
