using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Szerelo
    {
        public Szerelo()
        {
        }
        public Szerelo(string sor)
        {
            var db = sor.Split(';');           
            Nev = db[0];
            Szakterulet = db[1];    
        }

        public int Id { get; set; }

        [StringLength(80)]
        public string Nev { get; set; } = string.Empty;
        [StringLength(40)]
        public string Szakterulet { get; set; } = string.Empty;
        public List<Javitas> Javitasok { get; set; } = new();

        public override string? ToString()
        {
            return $"{Nev} - {Szakterulet}";
        }
    }
}
