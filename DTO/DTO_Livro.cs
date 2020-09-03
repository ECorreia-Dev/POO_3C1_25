﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO_3C1_25.DTO
{
    class DTO_Livro
    {
        // Atributos
        private int idLivro, idAutor, idEditora, numPaginas;
        private string titulo;
        private double valor;
        private DateTime dataCadastro;

        // Métodos
        public int IdLivro { get => idLivro; set => idLivro = value; }
        public int IdAutor { get => idAutor; set => idAutor = value; }
        public int IdEditora { get => idEditora; set => idEditora = value; }
        public int NumPaginas
        {
            set
            {
                if (value != 0)
                {
                    this.numPaginas = value;
                }
                else
                {
                    throw new Exception("Preencha o número de páginas.");
                }
            }
            get { return this.numPaginas; }

        }
        public string Titulo
        {
            set
            {
                if (value != string.Empty)
                {
                    this.titulo = value;
                }
                else
                {
                    throw new Exception("Preencha o título.");
                }
            }
            get { return this.titulo; }

        }
        public double Valor
        {
            set
            {
                if (value != 0)
                {
                    this.valor = value;
                }
                else
                {
                    throw new Exception("Preencha o valor.");
                }
            }
            get { return this.valor; }

        } 
        public DateTime DataCadastro
        {
            set
            {
                if (value != null)
                {
                    this.dataCadastro = value;
                }
                else
                {
                    throw new Exception("Preencha a Data.");
                }
            }
            get { return this.dataCadastro; }
        }
    }
}
