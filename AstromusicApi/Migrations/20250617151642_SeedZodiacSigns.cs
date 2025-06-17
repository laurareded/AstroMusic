using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AstromusicApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedZodiacSigns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ZodiacSigns",
                columns: new[] { "Id", "Description", "EndDay", "EndMonth", "ImageUrl", "Name", "SongArtist", "SongLink", "StartDay", "StartMonth", "ThemeSong" },
                values: new object[,]
                {
                    { 1, "Intensa e cheia de atitude, dona da própria verdade e energia incansável. Quem segura? Só Beyoncé mesmo, miga!", 20, 4, "", "Áries", "Beyoncé", "https://open.spotify.com/track/0bZ8K5yx2SUQTE0n7bJoRi", 21, 3, "Don't Hurt Yourself" },
                    { 2, "Apreciadora dos prazeres da vida, fiel e autêntica. Traz aquele glamour safadérrimo e a vibe luxuosa da Amy.", 20, 5, "", "Touro", "Amy Winehouse", "https://open.spotify.com/track/3CK2hZfPmW8A0nHqQxCajR", 21, 4, "F*** Me Pumps" },
                    { 3, "Mil facetas, 1000 opiniões por segundo. Rápida no papo, adora um caos, rainha do reboliço igual Nicki.", 20, 6, "", "Gêmeos", "Nicki Minaj", "https://open.spotify.com/track/4F7A0DXBrmUAkp32uenhQk", 21, 5, "Roman's Revenge" },
                    { 4, "Emo delicinha, sentimental, entrega o coração de bandeja. Uma música doce e sincera da Kehlani é o mood.", 21, 7, "", "Câncer", "Kehlani", "https://open.spotify.com/track/5V5PTEzOeF8J4vH05m0Qel", 21, 6, "Honey" },
                    { 5, "Rainha do palco, centro das atenções. Entrega o *twerk*, entrega o poder, igual Megan feat. Queen B!", 22, 8, "", "Leão", "Megan Thee Stallion feat. Beyoncé", "https://open.spotify.com/track/3Remixlink", 22, 7, "Savage Remix" },
                    { 6, "Perfeccionista, discreta, organizada, mas super envolvente, com um R&B viciante tipo Summer Walker.", 22, 9, "", "Virgem", "Summer Walker", "https://open.spotify.com/track/5hQSMw0tYhfbWf0WgZqkDQ", 23, 8, "Body" },
                    { 7, "Estilosa, charmosa, busca equilíbrio até no batom. Música deep da Rihanna, pra dar close certo.", 22, 10, "", "Libra", "Rihanna feat. SZA", "https://open.spotify.com/track/0ikz6tENMONtK6qGkOrU3c", 23, 9, "Consideration" },
                    { 8, "Intensa, misteriosa, provocante. O dark da Lana é seu habitat natural.", 21, 11, "", "Escorpião", "Lana Del Rey", "https://open.spotify.com/track/6jG2YzhxptolDzLHTGLt7S", 23, 10, "Gods & Monsters" },
                    { 9, "Livre, criativa, irreverente. Melanie entrega a vibe lúdica, diferente e nada óbvia.", 21, 12, "", "Sagitário", "Melanie Martinez", "https://open.spotify.com/track/1gVgkEC0AHTy9y5xrwtO3A", 22, 11, "Strawberry Shortcake" },
                    { 10, "Ambiciosa, poderosa, não dá ponto sem nó. A Beyoncé de “Upgrade U” é sua mentora.", 20, 1, "", "Capricórnio", "Beyoncé feat. Jay-Z", "https://open.spotify.com/track/6O8A4hZ9VgoWvNEmkbD9g0", 22, 12, "Upgrade U" },
                    { 11, "Visionária, única, sempre com um papo profundo. Jhené Aiko com B.S., pra quem pensa fora da caixa.", 19, 2, "", "Aquário", "Jhené Aiko feat. H.E.R.", "https://open.spotify.com/track/2Q4pFzK4qvU3hZLhM4nY5z", 21, 1, "B.S." },
                    { 12, "Sensível, artista, vive no mundo dos sonhos. Lana entrega a atmosfera onírica perfeita.", 20, 3, "", "Peixes", "Lana Del Rey", "https://open.spotify.com/track/1vZCtb8pAz9VLtMoA5pBWi", 20, 2, "The Grants" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
