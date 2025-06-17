using Microsoft.EntityFrameworkCore;
using AstromusicApi.models; 

namespace AstromusicApi.Data 
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ZodiacSign> ZodiacSigns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<ZodiacSign>().HasData(
        new ZodiacSign
        {
            Id = 1,
            Name = "Áries",
            StartMonth = 3,
            StartDay = 21,
            EndMonth = 4,
            EndDay = 20,
            Description = "Intensa e cheia de atitude, dona da própria verdade e energia incansável. Quem segura? Só Beyoncé mesmo!",
            ThemeSong = "Don't Hurt Yourself",
            SongArtist = "Beyoncé",
            SongLink = "https://open.spotify.com/intl-pt/track/78eouBKVRyhbSzJwChr6QM?si=97f00cb9e32c4fd6",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 2,
            Name = "Touro",
            StartMonth = 4,
            StartDay = 21,
            EndMonth = 5,
            EndDay = 20,
            Description = "Apreciadora dos prazeres da vida, fiel e autêntica. Traz aquele glamour e a vibe luxuosa da Amy.",
            ThemeSong = "F*** Me Pumps",
            SongArtist = "Amy Winehouse",
            SongLink = "https://open.spotify.com/intl-pt/track/6efhuc3AsgEKF0XZiEocQY?si=da0679073e524307",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 3,
            Name = "Gêmeos",
            StartMonth = 5,
            StartDay = 21,
            EndMonth = 6,
            EndDay = 20,
            Description = "Mil facetas, 1000 opiniões por segundo. Rápida no papo, adora um caos, rainha do reboliço igual Nicki.",
            ThemeSong = "Roman's Revenge",
            SongArtist = "Nicki Minaj",
            SongLink = "https://open.spotify.com/intl-pt/track/0eUzRaG60gimqQJ02oSUnH?si=19bd8d9747d643ac",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 4,
            Name = "Câncer",
            StartMonth = 6,
            StartDay = 21,
            EndMonth = 7,
            EndDay = 21,
            Description = "Emo delicinha, sentimental, entrega o coração de bandeja. Uma música doce e sincera da Kehlani é o mood.",
            ThemeSong = "Honey",
            SongArtist = "Kehlani",
            SongLink = "https://open.spotify.com/intl-pt/track/5QTdOvIF2ehBMZpSIIGzIo?si=ef69bb0a7ec9438b",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 5,
            Name = "Leão",
            StartMonth = 7,
            StartDay = 22,
            EndMonth = 8,
            EndDay = 22,
            Description = "Rainha do palco, centro das atenções. Entrega o *twerk*, entrega o poder, igual Megan feat. Queen B!",
            ThemeSong = "Savage Remix",
            SongArtist = "Megan Thee Stallion feat. Beyoncé",
            SongLink = "https://open.spotify.com/intl-pt/track/5v4GgrXPMghOnBBLmveLac?si=d1ebcb9c03e54f12",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 6,
            Name = "Virgem",
            StartMonth = 8,
            StartDay = 23,
            EndMonth = 9,
            EndDay = 22,
            Description = "Perfeccionista, discreta, organizada, mas super envolvente, com um R&B viciante tipo Summer Walker.",
            ThemeSong = "Body",
            SongArtist = "Summer Walker",
            SongLink = "https://open.spotify.com/intl-pt/track/7vxLj7MREliG5i5vSnqSVr?si=bd7e8c7212a743f4",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 7,
            Name = "Libra",
            StartMonth = 9,
            StartDay = 23,
            EndMonth = 10,
            EndDay = 22,
            Description = "Estilosa, charmosa, busca equilíbrio até no batom. Música deep da Rihanna, pra dar close certo.",
            ThemeSong = "Consideration",
            SongArtist = "Rihanna feat. SZA",
            SongLink = "https://open.spotify.com/intl-pt/track/6t90Z9XkdsHD8xMxro6KRP?si=f0fdfda75b194acc",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 8,
            Name = "Escorpião",
            StartMonth = 10,
            StartDay = 23,
            EndMonth = 11,
            EndDay = 21,
            Description = "Intensa, misteriosa, provocante. O dark da Lana é seu habitat natural.",
            ThemeSong = "Gods & Monsters",
            SongArtist = "Lana Del Rey",
            SongLink = "https://open.spotify.com/intl-pt/track/4uhSo9cVBVpdDCNxf4MBaP?si=434e22b75841497b",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 9,
            Name = "Sagitário",
            StartMonth = 11,
            StartDay = 22,
            EndMonth = 12,
            EndDay = 21,
            Description = "Livre, criativa, irreverente. Melanie entrega a vibe lúdica, diferente e nada óbvia.",
            ThemeSong = "Strawberry Shortcake",
            SongArtist = "Melanie Martinez",
            SongLink = "https://open.spotify.com/intl-pt/track/57OBlxZRcRyHFdlXlsHP7G?si=6b9b4a0844c44e33",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 10,
            Name = "Capricórnio",
            StartMonth = 12,
            StartDay = 22,
            EndMonth = 1,
            EndDay = 20,
            Description = "Ambiciosa, poderosa, não dá ponto sem nó. A Beyoncé de “Upgrade U” é sua mentora.",
            ThemeSong = "Upgrade U",
            SongArtist = "Beyoncé feat. Jay-Z",
            SongLink = "https://open.spotify.com/intl-pt/track/0GLUBbX4daHJkT3RQHEOia?si=9af44149f39b4158",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 11,
            Name = "Aquário",
            StartMonth = 1,
            StartDay = 21,
            EndMonth = 2,
            EndDay = 19,
            Description = "Visionária, única, sempre com um papo profundo. Jhené Aiko com B.S., pra quem pensa fora da caixa.",
            ThemeSong = "B.S.",
            SongArtist = "Jhené Aiko feat. H.E.R.",
            SongLink = "https://open.spotify.com/intl-pt/track/63wx9vdskaXbYxyDx4oJCZ?si=5e0b48f7a9ea4e81",
            ImageUrl = ""
        },
        new ZodiacSign
        {
            Id = 12,
            Name = "Peixes",
            StartMonth = 2,
            StartDay = 20,
            EndMonth = 3,
            EndDay = 20,
            Description = "Sensível, artista, vive no mundo dos sonhos. Lana entrega a atmosfera onírica perfeita.",
            ThemeSong = "The Grants",
            SongArtist = "Lana Del Rey",
            SongLink = "https://open.spotify.com/intl-pt/track/3KbOflJ5JqHWtmco4PiO3h?si=4616e258e00e46b5",
            ImageUrl = ""
        }
    );
}

    }
}
