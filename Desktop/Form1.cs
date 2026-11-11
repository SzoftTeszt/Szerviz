using ClassLibrary.Data;
using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Seed();
            SzerelokBetoltese();
        }
        private void SzerelokBetoltese()
        {

            using SzervizContext db = new SzervizContext();

            lstSzerelok.Items.Clear();

            foreach (var item in db.Szerelok.OrderBy(x => x.Nev))
            {
                lstSzerelok.Items.Add(item);
            }
        }

        private void Seed()
        {
            using SzervizContext db = new SzervizContext();

            if (!db.Szerelok.Any())
            {
                foreach (var item in File.ReadAllLines("szerelok.csv"))
                {
                    db.Szerelok.Add(new Szerelo(item));
                }
                db.SaveChanges();
            }

            if (!db.Javitasok.Any())
            {
                foreach (var item in File.ReadAllLines("javitasok.csv"))
                {
                    db.Javitasok.Add(new Javitas(item));
                }
                db.SaveChanges();
            }


        }

        private void lstSzerelok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSzerelok.SelectedItem is not Szerelo kivalasztott) return;

            using SzervizContext db = new SzervizContext();

            var lista = db.Szerelok.Include(s => s.Javitasok).FirstOrDefault(s => s.Id == kivalasztott.Id).
                Javitasok.OrderByDescending(j => j.Datum).Select(
                    j => new
                    {
                        j.Rendszam,
                        j.Hiba,
                        j.Ar,
                        j.Datum
                    }).ToList();
            lblEredmeny.Text = $"{kivalasztott.Nev} javításai {lista.Count} db";
            dvgAdatok.DataSource = lista;
        }

        private void btnOsszesInclude_Click_1(object sender, EventArgs e)
        {
            using SzervizContext db = new SzervizContext();

            var lista = db.Javitasok
                .Include(j => j.Szerelo)
                .OrderByDescending(j => j.Datum)
                .Select(
                j => new
                {
                    j.Rendszam,
                    j.Hiba,
                    j.Ar,
                    j.Datum,
                    SzereloNev = j.Szerelo.Nev,
                    j.Szerelo.Szakterulet
                }).ToList();

            lblEredmeny.Text = $"Összes javítás - Include()";
            dvgAdatok.DataSource = lista;

        }

        private void btnOsszesJoin_Click_1(object sender, EventArgs e)
        {
            using SzervizContext db = new SzervizContext();

            var lista = db.Javitasok
               .Join(
                    db.Szerelok,
                    j => j.SzereloId,
                    s => s.Id,
                    (j, s) => new
                    {
                        j.Rendszam,
                        j.Hiba,
                        j.Ar,
                        j.Datum,
                        SzereloNev = s.Nev,
                        s.Szakterulet
                    }

                ).OrderByDescending(x => x.Datum).ToList();

            lblEredmeny.Text = $"Összes javítás - Join()";
            dvgAdatok.DataSource = lista;
        }

        private void btnDragabb_Click(object sender, EventArgs e)
        {
            using SzervizContext db = new SzervizContext();

            var lista = db.Javitasok
                .Include(j => j.Szerelo)
                .OrderByDescending(j => j.Datum)
                .Select(
                j => new
                {
                    j.Rendszam,
                    j.Hiba,
                    j.Ar,
                    j.Datum,
                    SzereloNev = j.Szerelo.Nev,
                    j.Szerelo.Szakterulet
                }).Where(x => x.Ar > 100000).ToList();

            lblEredmeny.Text = $"Összes javítás - Include()";
            dvgAdatok.DataSource = lista;
        }

        private void btnSzereléoOsszesites_Click(object sender, EventArgs e)
        {
            using SzervizContext db = new SzervizContext();

            var lista = db.Szerelok
                .Include(s => s.Javitasok)
                .OrderBy(s => s.Nev)
                .Select(s => new
                {
                    SzereloNev = s.Nev,
                    s.Szakterulet,
                    JavitasokSzama = s.Javitasok.Count,
                    OsszesBevetel = s.Javitasok.Sum(j => j.Ar)
                })
                .ToList();
            lblEredmeny.Text = $"Szerelõnkénti összesítés";
            dvgAdatok.DataSource = lista;
        }

        }
}