using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
   public class Metodos
    {
        DataSet Ds = new DataSet();
        SqlDataAdapter Da;
        public void GrabarCambios(string NombreTabla, DataSet Dset)
        {
            string Str = @"Data Source=DESKTOP-Q67CN4Q\SQLEXPRESS;Initial Catalog=FINAL_LUG;Integrated Security=True";
            Da = new SqlDataAdapter(("SELECT * FROM " + NombreTabla), Str);
            // SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder Cb = new SqlCommandBuilder(Da);
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();

            Da.ContinueUpdateOnError = true;
            Da.Fill(Dset);
            // SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            Da.Update(Dset.Tables[0]);
        }
    }
}
