using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginAndAdminPanel.Migrations
{
    public partial class initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kurucus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kurucus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Okuls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KurucuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Okuls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Okuls_Kurucus_KurucuId",
                        column: x => x.KurucuId,
                        principalTable: "Kurucus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mudurs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KurucuId = table.Column<int>(type: "int", nullable: true),
                    OkulId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mudurs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mudurs_Kurucus_KurucuId",
                        column: x => x.KurucuId,
                        principalTable: "Kurucus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mudurs_Okuls_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okuls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ogretmens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KurucuId = table.Column<int>(type: "int", nullable: true),
                    OkulId = table.Column<int>(type: "int", nullable: true),
                    MudurId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogretmens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogretmens_Kurucus_KurucuId",
                        column: x => x.KurucuId,
                        principalTable: "Kurucus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogretmens_Mudurs_MudurId",
                        column: x => x.MudurId,
                        principalTable: "Mudurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogretmens_Okuls_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okuls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ogrencis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KurucuId = table.Column<int>(type: "int", nullable: true),
                    OgretmenId = table.Column<int>(type: "int", nullable: true),
                    MudurId = table.Column<int>(type: "int", nullable: true),
                    OkulId = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogrencis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Kurucus_KurucuId",
                        column: x => x.KurucuId,
                        principalTable: "Kurucus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Mudurs_MudurId",
                        column: x => x.MudurId,
                        principalTable: "Mudurs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Ogretmens_OgretmenId",
                        column: x => x.OgretmenId,
                        principalTable: "Ogretmens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ogrencis_Okuls_OkulId",
                        column: x => x.OkulId,
                        principalTable: "Okuls",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mudurs_KurucuId",
                table: "Mudurs",
                column: "KurucuId");

            migrationBuilder.CreateIndex(
                name: "IX_Mudurs_OkulId",
                table: "Mudurs",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_KurucuId",
                table: "Ogrencis",
                column: "KurucuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_MudurId",
                table: "Ogrencis",
                column: "MudurId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_OgretmenId",
                table: "Ogrencis",
                column: "OgretmenId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogrencis_OkulId",
                table: "Ogrencis",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmens_KurucuId",
                table: "Ogretmens",
                column: "KurucuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmens_MudurId",
                table: "Ogretmens",
                column: "MudurId");

            migrationBuilder.CreateIndex(
                name: "IX_Ogretmens_OkulId",
                table: "Ogretmens",
                column: "OkulId");

            migrationBuilder.CreateIndex(
                name: "IX_Okuls_KurucuId",
                table: "Okuls",
                column: "KurucuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ogrencis");

            migrationBuilder.DropTable(
                name: "Ogretmens");

            migrationBuilder.DropTable(
                name: "Mudurs");

            migrationBuilder.DropTable(
                name: "Okuls");

            migrationBuilder.DropTable(
                name: "Kurucus");
        }
    }
}
