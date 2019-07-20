using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class ClienteDAL
    {
        Conexao banco = new Conexao();

        MySqlCommand _cmd;

        public void SalvarCliente(Cliente cliente)
        {
            try
            {
                string insert = @"insert into Cliente(NM_CLIENTE, CD_TELEFONE, CD_CEP, NM_BAIRRO, NM_ENDERECO, CD_NUMERO, CD_COMPLEMENTO)";
                       insert += " values (UPPER('" + cliente.Nome + "'),'" + cliente.Telefone + "','" + cliente.CEP + "', UPPER('" + cliente.Bairro +
                                "'), UPPER('" + cliente.Endereco + "'), '" + cliente.Numero + "', UPPER('" + cliente.Complemento +"'))";

                _cmd = new MySqlCommand(insert, banco.AbrirConexao());

                _cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public void AlterarCliente(Cliente cliente, string antigotelefone)
        {
            try
            {
                string update = @"Update Cliente SET NM_CLIENTE = UPPER('" + cliente.Nome + "'), CD_TELEFONE = '" + cliente.Telefone + 
                    "', CD_CEP = '" + cliente.CEP + "', NM_BAIRRO = UPPER('" + cliente.Bairro + "'), NM_ENDERECO = UPPER('" + cliente.Endereco +
                    "'), CD_NUMERO = '" + cliente.Numero + "', CD_COMPLEMENTO = UPPER('" + cliente.Complemento + "') WHERE CD_TELEFONE = " + antigotelefone;

                _cmd = new MySqlCommand(update, banco.AbrirConexao());

                _cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                banco.FecharConexao();
            }
        }
        public List<Cliente> ConsultarClientes(string telefone)
        {
            string select = @"Select NM_PRODUTO, CD_TELEFONE, CD_CEP, NM_BAIRRO,
                            NM_ENDERECO, CD_NUMERO, CD_COMPLEMENTO 
                            FROM CLIENTE WHERE CD_TELEFONE like '%" + telefone + "%'";
            List<Cliente> clientes = new List<Cliente>();

            try
            {

                _cmd = new MySqlCommand(select, banco.AbrirConexao());

                MySqlDataReader dr;

                dr = _cmd.ExecuteReader();

                while (dr.Read())
                {
                    Cliente cliente = new Cliente
                    {
                        Nome = dr["NM_CLIENTE"].ToString(),
                        Telefone = dr["CD_TELEFONE"].ToString(),
                        CEP = dr["CD_CEP"].ToString(),
                        Bairro = dr["NM_BAIRRO"].ToString(),
                        Endereco = dr["NM_ENDERECO"].ToString(),
                        Numero = dr["CD_NUMERO"].ToString(),
                        Complemento = dr["CD_COMPLEMENTO"].ToString()
                    };

                    clientes.Add(cliente);
                }
            }
            finally
            {
                banco.FecharConexao();
            }
            return clientes;
        }
        public void ExcluirCliente(string telefone)
        {
            try
            {
                string delete = @"DELETE FROM Cliente WHERE CD_TELEFONE = " + telefone;

                _cmd = new MySqlCommand(delete, banco.AbrirConexao());
                _cmd.ExecuteNonQuery();

            }
            catch (Exception)
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
