﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Projeto_Desktop.Classes
{
    public class Carga
    {
        //Atributos privados

        private int id;
        private TipoCarga idTipo;
        private Pedido idPedido;
        private double peso;
        private double largura;
        private double altura;
        private double comprimento;
        private string nomeProduto;
        private string detalhesProduto;
        private double valorProduto;
        private int quantidade;
        private Banco db;
        

        //Propiedades
        public int Id { get => id; set => id = value; }
        public Pedido IdPedido { get => idPedido; set => idPedido = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Largura { get => largura; set => largura = value; }
        public double Altura { get => altura; set => altura = value; }
        public double Comprimento { get => comprimento; set => comprimento = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string DetalhesProduto { get => detalhesProduto; set => detalhesProduto = value; }
        public TipoCarga IdTipo { get => idTipo; set => idTipo = value; }
        public double ValorProduto { get => valorProduto; set => valorProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }

        //Métodos construtores
        public Carga(int id, TipoCarga idTipo, Pedido idPedido, double peso, double largura, double altura, double comprimento, string nomeProduto, string detalhesProduto, double valorProduto,int quantidade)
        {
            this.id = id;
            this.idTipo = idTipo;
            this.idPedido = idPedido;
            this.peso = peso;
            this.largura = largura;
            this.altura = altura;
            this.comprimento = comprimento;
            this.nomeProduto = nomeProduto;
            this.detalhesProduto = detalhesProduto;
            this.valorProduto = valorProduto;
            this.quantidade = quantidade;
        }
        public Carga()
        {
            IdTipo = new TipoCarga();
            IdPedido = new Pedido();
        }


        //Métodos

        /// <summary>
        /// Método utilizando para inserir carga
        /// </summary>      
        public void InserirCarga(int _idPedido, double _peso, double _largura, double _altura, double _comprimento, string _nomeProduto, string _detalhesProduto, int idtipo, double valor,int quantidade)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "insert_carga";
                comm.Parameters.Add("_idpedido", MySqlDbType.Int32).Value = _idPedido;
                comm.Parameters.Add("_peso", MySqlDbType.Decimal).Value = _peso;
                comm.Parameters.Add("_largura", MySqlDbType.Decimal).Value = _largura;
                comm.Parameters.Add("_altura", MySqlDbType.Decimal).Value = _altura;
                comm.Parameters.Add("_comprimento", MySqlDbType.Decimal).Value = _comprimento;
                comm.Parameters.Add("_nomeproduto", MySqlDbType.VarChar).Value = _nomeProduto;
                comm.Parameters.Add("_detalhesproduto", MySqlDbType.VarChar).Value = _detalhesProduto;
                comm.Parameters.Add("_idtipo", MySqlDbType.Int32).Value = idtipo;
                comm.Parameters.Add("_valor", MySqlDbType.Int32).Value = valor;
                comm.Parameters.Add("_quantidade", MySqlDbType.Int32).Value = quantidade;
                this.Id = Convert.ToInt32(comm.ExecuteScalar());
            }
            catch(Exception ex)
            {
                ex.Message.ToString();
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
        public bool AtualizarCarga(int _id,double _peso, double _largura, double _altura, double _comprimento, string _nomeProduto, string _detalhesProduto,int _idtipo,double _valor)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try 
            {                 
                comm.CommandType = CommandType.StoredProcedure;
                comm.CommandText = "update_carga";            
                comm.Parameters.Add("_peso", MySqlDbType.Decimal).Value = _peso;
                comm.Parameters.Add("_largura", MySqlDbType.Decimal).Value = _largura;
                comm.Parameters.Add("_altura", MySqlDbType.Decimal).Value = _altura;
                comm.Parameters.Add("_comprimento", MySqlDbType.Decimal).Value = _comprimento;
                comm.Parameters.Add("_nomeproduto", MySqlDbType.VarChar).Value = _nomeProduto;
                comm.Parameters.Add("_detalhesproduto", MySqlDbType.VarChar).Value = _detalhesProduto;
                comm.Parameters.Add("_id", MySqlDbType.Int32).Value = _id;
                comm.Parameters.Add("_idtipo", MySqlDbType.Int32).Value = _idtipo;
                comm.Parameters.Add("_valor", MySqlDbType.Decimal).Value = _valor;
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
        /// Consultand carga
        /// </summary>
        /// <param name="_id"></param>
        public void ConsultarCarga(int _id)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from carga where idCarga = " + _id;
                var dr = comm.ExecuteReader();
                while(dr.Read())
                {
                    this.Id = dr.GetInt32(0);
                    this.idTipo.Id = dr.GetInt32(1);
                    this.idPedido.Id = dr.GetInt32(2);
                    this.Peso = dr.GetDouble(3);
                    this.Largura = dr.GetDouble(4);
                    this.Altura = dr.GetDouble(5);
                    this.Comprimento = dr.GetDouble(6);
                    this.NomeProduto = dr.GetString(7);
                    this.DetalhesProduto = dr.GetString(8);
                    this.ValorProduto = dr.GetDouble(9);
                    this.Quantidade = dr.GetInt32(10);
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
        public List<Carga> ListarCargas()
        {
            db = new Banco();
            List<Carga> listaCarga = new List<Carga>(); ;
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select * from carga";
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Carga C = new Carga
                    {
                        Id = dr.GetInt32(0),                        
                        Peso = dr.GetDouble(3),
                        Largura = dr.GetDouble(4),
                        Altura = dr.GetDouble(5),
                        Comprimento = dr.GetDouble(6),
                        NomeProduto = dr.GetString(7),
                        DetalhesProduto = dr.GetString(8),
                        ValorProduto = dr.GetDouble(9),
                        Quantidade = dr.GetInt32(10)
                    };
                    C.idTipo.Id = dr.GetInt32(1);
                    C.idPedido.Id = dr.GetInt32(2);
                    listaCarga.Add(C);
                }
                return listaCarga;
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
        public List<Carga> ListarCargasPedido(int _idPedido)
        {
            db = new Banco();
            List<Carga> listaCarga = new List<Carga>();
            var comm = db.AbrirConexao();
            try
            {               
                comm.CommandText = "select * from carga where idPedidos = "+ _idPedido;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    Carga C = new Carga
                    {
                        Id = dr.GetInt32(0),
                        Peso = dr.GetDouble(3),
                        Largura = dr.GetDouble(4),
                        Altura = dr.GetDouble(5),
                        Comprimento = dr.GetDouble(6),
                        NomeProduto = dr.GetString(7),
                        DetalhesProduto = dr.GetString(8),
                        ValorProduto = dr.GetDouble(9),
                        Quantidade = dr.GetInt32(10)
                    };
                    C.idTipo.Id = dr.GetInt32(1);
                    C.idPedido.Id = dr.GetInt32(2);
                    listaCarga.Add(C);
                }
                return listaCarga;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }            
        }
        public List<Carga> ListarCargasPedidoInner(int _idPedido)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            Carga c;
            List<Carga> listaCarga = new List<Carga>(); ;
            try
            {                
                comm.CommandText = "select c.idPedidos as idPedido, c.idCarga, c.NomeProduto,c.Peso,c.Largura, "+
                            "c.Altura,c.Comprimento, c.ValorProduto, c.Quantidade, tipo.Nome from carga as c "+
                             "inner join tiposcargas as tipo on c.idTipo = tipo.idTipo "+
                            "where idPedidos = " + _idPedido;
                var dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    c = new Carga
                    {
                        Id = dr.GetInt32(1),
                        NomeProduto = dr.GetString(2),
                        Peso = dr.GetDouble(3),
                        Largura = dr.GetDouble(4),
                        Altura = dr.GetDouble(5),
                        Comprimento = dr.GetDouble(6),
                        ValorProduto = dr.GetDouble(7),
                        Quantidade = dr.GetInt32(8)
                    };
                    c.IdPedido.Id = dr.GetInt32(0);
                    c.IdTipo.Nome = dr.GetString(9);
                    listaCarga.Add(c);
                }
                return listaCarga;
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
        public MySqlDataReader ListarCargasPedidoInnerDR(int _idPedido)
        {
            db = new Banco();
            var comm = db.AbrirConexao();
            try
            {                
                comm.CommandText = "select c.idPedidos as idPedido, c.idCarga, c.NomeProduto,c.Peso,c.Largura, " +
                            "c.Altura,c.Comprimento, c.ValorProduto, c.Quantidade, tipo.Nome from carga as c " +
                             "inner join tiposcargas as tipo on c.idTipo = tipo.idTipo " +
                            "where idPedidos = " + _idPedido;
                return comm.ExecuteReader();                
            }
            catch (Exception e)
            {
                e.Message.ToString();
                return null;
            }            
        }
    }
}
