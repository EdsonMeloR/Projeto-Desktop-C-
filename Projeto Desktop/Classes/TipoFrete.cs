﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Desktop.Classes
{
    public class TipoFrete
    {
        
        //Atributos
        private int id;
        private string nome;
        private string descricao;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        //Métodos construtores
        public TipoFrete(int id, string nome, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.descricao = descricao;
        }
        public TipoFrete()
        { }
        //Métodos
        /// <summary>
        /// Inserindo tipo de frete
        /// </summary>        
        public void InserirTipoFrete(string nome, string descricao)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "insert into tiposfretes (Nome,Descricao) values ('" + nome + "','" + descricao + "'); select * from tiposfretes where idTiposFretes = last_insert_id();";
                this.Id = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                try
                {
                    if (comm != null)
                        comm.Connection.Close();
                    else
                        throw new Exception("Falha ao conectar-se com o banco de dados");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
        /// <summary>
        /// Alterando tipo frete
        /// </summary>        
        public bool AlterarTipoFrete(string _nome, string _descricao, int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "update tiposfretes set Nome = '" + _nome + ", Descricao = '" + _descricao + "'";
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
            finally
            {
                try
                {
                    if (comm != null)
                        comm.Connection.Close();
                    else
                        throw new Exception("Falha ao conectar-se com o banco de dados");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
        /// <summary>
        /// Excluindo Tipo Fretes
        /// </summary>        
        public bool DeleteTipoFrete(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "delete from tiposfretes where idTiposFretes = " + _id;
                comm.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return false;
            }
            finally
            {
                try
                {
                    if (comm != null)
                        comm.Connection.Close();
                    else
                        throw new Exception("Falha ao conectar-se com o banco de dados");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
        /// <summary>
        /// Consultando tipo de Frete
        /// </summary>

        public void ConsultarTipoFrete(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from tiposenderecos where idTiposFretes = " + _id;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.Nome = dr.GetString(1);
                    this.Descricao = dr.GetString(2);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                try
                {
                    if (comm != null)
                        comm.Connection.Close();
                    else
                        throw new Exception("Falha ao conectar-se com o banco de dados");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
        /// <summary>
        /// Listando tipos de Fretes
        /// </summary>        
        public List<TipoFrete> ListarTiposFretes()
        {
            db = new Banco();
            TipoFrete tf;
            List<TipoFrete> lista = new List<TipoFrete>();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from tiposfretes";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    tf = new TipoFrete();
                    tf.Id = dr.GetInt32(0);
                    tf.Nome = dr.GetString(1);
                    tf.Descricao = dr.GetString(2);
                    lista.Add(tf);
                }
                return lista;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            } 
            finally
            {
                try
                {
                    if (comm != null)
                        comm.Connection.Close();
                    else
                        throw new Exception("Falha ao conectar-se com o banco de dados");
                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
            }
        }
    }
}
