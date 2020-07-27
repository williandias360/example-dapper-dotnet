using System;
using Dapper.Contrib.Extensions;

namespace ApiIndicadores
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public long CodigoCliente { get; set; }
        public string Nome { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}