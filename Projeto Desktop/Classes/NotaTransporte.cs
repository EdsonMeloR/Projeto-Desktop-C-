﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop.Classes
{
    public class NotaTransporte
    {
        //Atributos
        private int id;
        private Veiculo idVeiculo;
        private Motorista idMotorista;
        private TipoFrete idTipoFrete;
        private double valorFrete;
        private double distancia;
        private DateTime dataEmissao;
        Banco db;
        //Propiedades
        public int Id { get => id; set => id = value; }
        public Veiculo IdVeiculo { get => idVeiculo; set => idVeiculo = value; }
        public Motorista IdMotorista { get => idMotorista; set => idMotorista = value; }
        public TipoFrete IdTipoFrete { get => idTipoFrete; set => idTipoFrete = value; }
        public double ValorFrete { get => valorFrete; set => valorFrete = value; }
        public double Distancia { get => distancia; set => distancia = value; }
        public DateTime DataEmissao { get => dataEmissao; set => dataEmissao = value; }

        //Métodos construtores
        public NotaTransporte(int id, Veiculo idVeiculo, Motorista idMotorista, TipoFrete idTipoFrete, double valorFrete, double distancia, DateTime dataEmissao)
        {
            this.id = id;
            this.idVeiculo = idVeiculo;
            this.idMotorista = idMotorista;
            this.idTipoFrete = idTipoFrete;
            this.valorFrete = valorFrete;
            this.distancia = distancia;
            this.dataEmissao = dataEmissao;
        }
        public NotaTransporte()
        {
            IdVeiculo = new Veiculo();
            IdMotorista = new Motorista();
            IdTipoFrete = new TipoFrete();
        }
        //Métodos
        /// <summary>
        /// Inserindo nota de transporte
        /// </summary>        
        public void InserirNotaTransporte(int idVeiculo, int idMotorista, int idTipoFrete, double valorFrete, double distancia)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_notatransporte";
                comm.Parameters.Add("_idmotorista", MySqlDbType.Int32).Value = idMotorista;
                comm.Parameters.Add("_idveiculo", MySqlDbType.Int32).Value = idVeiculo;
                comm.Parameters.Add("_idtiposfretes", MySqlDbType.Int32).Value = idTipoFrete;
                comm.Parameters.Add("_valor", MySqlDbType.Decimal).Value = valorFrete;
                comm.Parameters.Add("_distancia", MySqlDbType.Decimal).Value = distancia;
                var dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.IdVeiculo.Id = dr.GetInt32(1);
                    this.IdMotorista.IdMotorista = dr.GetInt32(2);
                    this.IdTipoFrete.Id = dr.GetInt32(3);
                    this.Distancia = dr.GetDouble(4);
                    this.ValorFrete = dr.GetDouble(5);                    
                    this.DataEmissao = dr.GetDateTime(6);
                }
            }
            catch(Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Alterando nota de transporte
        /// </summary>       
        public bool AlterarNotaTransporte(int _id,int idVeiculo, int idMotorista, int idTipoFrete, double valorFrete, double distancia)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_notatransporte";
                comm.Parameters.Add("_idmotorista", MySqlDbType.Int32).Value = idMotorista;
                comm.Parameters.Add("_idveiculo", MySqlDbType.Int32).Value = idVeiculo;
                comm.Parameters.Add("_idtipo", MySqlDbType.Int32).Value = idTipoFrete;
                comm.Parameters.Add("_valorfrete", MySqlDbType.Decimal).Value = valorFrete;
                comm.Parameters.Add("_distancia", MySqlDbType.Decimal).Value = distancia;
                comm.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
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
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Consultar nota de transporte pelo id
        /// </summary>
        public void ConsultarNotaTransporteId(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();

            try
            {
                comm.CommandText = "select * from notatransporte where idNotaTransporte = " + _id;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.IdVeiculo.Id = dr.GetInt32(1);
                    this.IdMotorista.IdMotorista = dr.GetInt32(2);
                    this.IdTipoFrete.Id = dr.GetInt32(3);
                    this.Distancia = dr.GetDouble(4);
                    this.ValorFrete = dr.GetDouble(5);
                    this.DataEmissao = dr.GetDateTime(6);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();                
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Consultar nota de transporte pelo motorista
        /// </summary>        
        public void ConsultarNotaTransporteMotorista(int _idMotorista)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandText = "select * from notatransporte where idMotorista = " + _idMotorista;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.IdVeiculo.Id = dr.GetInt32(1);
                    this.IdMotorista.IdMotorista = dr.GetInt32(2);
                    this.IdTipoFrete.Id = dr.GetInt32(3);
                    this.Distancia = dr.GetDouble(4);
                    this.ValorFrete = dr.GetDouble(5);
                    this.DataEmissao = dr.GetDateTime(6);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Consultar nota de transporte pelo veiculo
        /// </summary>        
        public void ConsultarNotaTransporteVeiculo(int _veiculo)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandText = "select * from notatransporte where idVeiculo = " + _veiculo;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.IdVeiculo.Id = dr.GetInt32(1);
                    this.IdMotorista.IdMotorista = dr.GetInt32(2);
                    this.IdTipoFrete.Id = dr.GetInt32(3);
                    this.Distancia = dr.GetDouble(4);
                    this.ValorFrete = dr.GetDouble(5);
                    this.DataEmissao = dr.GetDateTime(6);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
            }
            finally
            {
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }
        /// <summary>
        /// Listando nota de transporte
        /// </summary>
        /// <returns>Retorna um list<> do objeto NotaTransporte</returns>
        public List<NotaTransporte> ListarNotaTransporte()
        {
            db = new Banco();
            List<NotaTransporte> lista = new List<NotaTransporte>();
            NotaTransporte n;
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandText = "select * from notatransporte";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    n = new NotaTransporte
                    {
                        Id = dr.GetInt32(0),
                        Distancia = dr.GetDouble(4),
                        ValorFrete = dr.GetDouble(5),
                        DataEmissao = dr.GetDateTime(6)
                    };
                    n.IdVeiculo.Id = dr.GetInt32(1);
                    n.IdMotorista.IdMotorista = dr.GetInt32(2);
                    n.IdTipoFrete.Id = dr.GetInt32(3);                   
                    lista.Add(n);
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
                if (comm != null)
                    comm.Connection.Close();
                else
                    throw new Exception("Falha ao conectar-se com o banco de dados");
            }
        }

        public void GerarPdfNotaTransporte()
        {

        }
    }
}
