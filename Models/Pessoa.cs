using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API_com_ASP.NETCore.Models
{
    public class Pessoas
    {
        [Key]
        public int Id { get; set;}
        public string Nome { get; set;} = string.Empty;
        public string Cidade { get; set;} = string.Empty;
        public int Idade { get; set;}

    }
}