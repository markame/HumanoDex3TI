using System;
using System.Collections.Generic;
using System.Text;

namespace HumanoDex3TI.Model
{
    public class Humano
    {
        private int id;
        private string nome;
        private decimal peso;
        private decimal altura;
        private string genero;
        private string foto;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Peso { get => peso; set => peso = value; }
        public decimal Altura { get => altura; set => altura = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Foto { get => foto; set => foto = value; }

        public string salvaHumano(Humano humano)
        {
            return "Salvo com sucesso!";
        }

        public string deletaHumano(Humano humano)
        {
            return "deletado com sucesso!";
        }
        public string alteraHumano(Humano humano)
        {
            return "alterado com sucesso!";
        }
        public string buscaHumano(Humano humano)
        {
            return "encontrado com sucesso!";
        }
        public string buscaHumanoporId(Humano humano)
        {
            return "encontrado com sucesso!";
        }
    }

   
}
