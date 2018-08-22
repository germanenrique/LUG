﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;


namespace DATOS
{
    public class Datos
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-Q67CN4Q\SQLEXPRESS;Initial Catalog=FINAL_LUG;Integrated Security=True");

        public void AbrirConexion()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-Q67CN4Q\SQLEXPRESS;Initial Catalog=FINAL_LUG;Integrated Security=True";
            conn.Open();
        }

        public DataSet LeerDS(string store)
        {
            AbrirConexion();

            DataSet ds = new DataSet();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(store, conn);
                da.Fill(ds);
            }
            catch (Exception)
            {
                ds = null;
            }

            CerrarConexion();

            return ds;
        }

        public DataSet LeerDesconectado(string consulta)
        {
            DataSet Ds = new DataSet();
            try
            {
                
                SqlDataAdapter Da = new SqlDataAdapter(consulta, conn);
                Da.Fill(Ds);
            }
            catch (SqlException ex)
            {
                throw (ex);
            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return Ds;
        }

        public void CerrarConexion()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
            GC.Collect();
        }
        public void Escribir(string store, Hashtable table)
        {
            AbrirConexion();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = store;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            SqlTransaction tx = default(SqlTransaction);
            tx = conn.BeginTransaction(IsolationLevel.Serializable);

            if (table.Count > 0)
            {
                foreach (string key in table.Keys)
                {
                    cmd.Parameters.AddWithValue(key, table[key]);
                }
            }

            try
            {
                cmd.Transaction = tx;
                cmd.ExecuteNonQuery();
                tx.Commit();
            }
            catch (SqlException ex)
            {
                tx.Rollback();
            }
            catch (Exception ex)
            {
                tx.Rollback();
            }

            CerrarConexion();
        }

        public DataTable Leer(string store)
        {
            AbrirConexion();

            DataTable dt = new DataTable();

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(store, conn);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }

            CerrarConexion();

            return dt;
        }
    }
}
