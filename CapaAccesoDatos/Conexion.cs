using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Conexion
    {
        //patron de Diseño Singleton
        private static readonly Conexion _instancia = new Conexion();
        public static Conexion Instancia
        {
            get { return Conexion._instancia; }
        }


        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection();
<<<<<<< HEAD
            cn.ConnectionString = "Data Source = localhost\\SQLEXPRESS; database = Inmobiliaria; Integrated security = true";
=======
            cn.ConnectionString = "Data Source = DESKTOP-TGSO18C\\SQLEXPRESS; database = Inmobiliaria; Integrated security = true";
>>>>>>> 31ea0177889338dec159d5e1338be83c95ed393b

            return cn;
        }
    }
}
