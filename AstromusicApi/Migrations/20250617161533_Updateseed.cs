using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AstromusicApi.Migrations
{
    /// <inheritdoc />
    public partial class Updateseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SongLink" },
                values: new object[] { "Intensa e cheia de atitude, dona da própria verdade e energia incansável. Quem segura? Só Beyoncé mesmo!", "https://open.spotify.com/intl-pt/track/78eouBKVRyhbSzJwChr6QM?si=97f00cb9e32c4fd6" });

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "SongLink" },
                values: new object[] { "Apreciadora dos prazeres da vida, fiel e autêntica. Traz aquele glamour e a vibe luxuosa da Amy.", "https://open.spotify.com/intl-pt/track/6efhuc3AsgEKF0XZiEocQY?si=da0679073e524307" });

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/0eUzRaG60gimqQJ02oSUnH?si=19bd8d9747d643ac");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 4,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/5QTdOvIF2ehBMZpSIIGzIo?si=ef69bb0a7ec9438b");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 5,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/5v4GgrXPMghOnBBLmveLac?si=d1ebcb9c03e54f12");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 6,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/7vxLj7MREliG5i5vSnqSVr?si=bd7e8c7212a743f4");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 7,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/6t90Z9XkdsHD8xMxro6KRP?si=f0fdfda75b194acc");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 8,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/4uhSo9cVBVpdDCNxf4MBaP?si=434e22b75841497b");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 9,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/57OBlxZRcRyHFdlXlsHP7G?si=6b9b4a0844c44e33");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 10,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/0GLUBbX4daHJkT3RQHEOia?si=9af44149f39b4158");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 11,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/63wx9vdskaXbYxyDx4oJCZ?si=5e0b48f7a9ea4e81");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 12,
                column: "SongLink",
                value: "https://open.spotify.com/intl-pt/track/3KbOflJ5JqHWtmco4PiO3h?si=4616e258e00e46b5");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "SongLink" },
                values: new object[] { "Intensa e cheia de atitude, dona da própria verdade e energia incansável. Quem segura? Só Beyoncé mesmo, miga!", "https://open.spotify.com/track/0bZ8K5yx2SUQTE0n7bJoRi" });

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "SongLink" },
                values: new object[] { "Apreciadora dos prazeres da vida, fiel e autêntica. Traz aquele glamour safadérrimo e a vibe luxuosa da Amy.", "https://open.spotify.com/track/3CK2hZfPmW8A0nHqQxCajR" });

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 3,
                column: "SongLink",
                value: "https://open.spotify.com/track/4F7A0DXBrmUAkp32uenhQk");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 4,
                column: "SongLink",
                value: "https://open.spotify.com/track/5V5PTEzOeF8J4vH05m0Qel");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 5,
                column: "SongLink",
                value: "https://open.spotify.com/track/3Remixlink");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 6,
                column: "SongLink",
                value: "https://open.spotify.com/track/5hQSMw0tYhfbWf0WgZqkDQ");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 7,
                column: "SongLink",
                value: "https://open.spotify.com/track/0ikz6tENMONtK6qGkOrU3c");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 8,
                column: "SongLink",
                value: "https://open.spotify.com/track/6jG2YzhxptolDzLHTGLt7S");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 9,
                column: "SongLink",
                value: "https://open.spotify.com/track/1gVgkEC0AHTy9y5xrwtO3A");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 10,
                column: "SongLink",
                value: "https://open.spotify.com/track/6O8A4hZ9VgoWvNEmkbD9g0");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 11,
                column: "SongLink",
                value: "https://open.spotify.com/track/2Q4pFzK4qvU3hZLhM4nY5z");

            migrationBuilder.UpdateData(
                table: "ZodiacSigns",
                keyColumn: "Id",
                keyValue: 12,
                column: "SongLink",
                value: "https://open.spotify.com/track/1vZCtb8pAz9VLtMoA5pBWi");
        }
    }
}
