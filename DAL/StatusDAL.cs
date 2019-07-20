using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class StatusDAL
    {
        Conexao banco = new Conexao();
        MySqlCommand _cmd;

        public void SalvarStatus(Status status)
        {
            try
            {
                string insert = @"INSERT INTO STATUS_PEDIDO(NM_STATUS) VALUES
                                ('" + status.Nome + "')";

                _cmd = new MySqlCommand(insert, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();
            }
            catch(MySqlException)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public List<Status> ConsultarStatus(string nome)
        {
            string select = @"SELECT ID_STATUS, NM_STATUS FROM STATUS_PEDIDO
                                WHERE NM_STATUS LIKE '%" + nome + "%'";

            List<Status> liststatus = new List<Status>();

            try
            {

                _cmd = new MySqlCommand(select, banco.AbrirConexao());

                MySqlDataReader dr;
                dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    Status status = new Status
                    {
                        ID = Convert.ToInt32(dr["ID_STATUS"]),
                        Nome = dr["NM_STATUS"].ToString()
                    };
                    liststatus.Add(status);
                }
            }
            catch(MySqlException)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
            return liststatus;
        }
        public void AlterarStatus(Status status)
        {
            string alterar = @"UPDATE STATUS_PEDIDO SET NM_STATUS = '" + status.Nome + "' WHERE ID_STATUS = " + status.ID.ToString();

            try
            {
                _cmd = new MySqlCommand(alterar, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();
            }
            catch(MySqlException)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }

        public void ExcluirStatus(int idStatus)
        {
            string delete = @"DELETE FROM STATUS_PEDIDO WHERE = " + idStatus.ToString();

            try
            {
                _cmd = new MySqlCommand(delete, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
    }
}
