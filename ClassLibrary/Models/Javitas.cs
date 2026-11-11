using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Javitas
    {
        public Javitas()
        {
        }
        public Javitas(string sor)
        {
            var db = sor.Split(';');
            Rendszam = db[0];
            Hiba = db[1];
            Ar = int.Parse(db[2]);
            Datum = DateTime.Parse(db[3]);
            SzereloId = int.Parse(db[4]);
        }

        public int Id { get; set; }
        [StringLength(20)]
        public string Rendszam { get; set; } = string.Empty;
        [StringLength(100)]
        public string Hiba { get; set; } = string.Empty;

        public int Ar { get; set; }

        public DateTime Datum { get; set; }

        public int SzereloId { get; set; }

        public Szerelo Szerelo { get; set; } = null!;



    }
}
