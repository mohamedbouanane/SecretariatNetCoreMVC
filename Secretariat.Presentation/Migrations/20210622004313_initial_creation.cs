using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Secretariat.Presentation.Migrations
{
    public partial class initial_creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "agenda",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    login = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    mot_de_pass = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_agenda", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "evenement",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    evenement_titre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    evenement_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    evenement_time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    evenement_agenda_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evenement", x => x.id);
                    table.ForeignKey(
                        name: "evenement_agenda_fk",
                        column: x => x.evenement_agenda_id,
                        principalTable: "agenda",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "entreprise",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactIdContact = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entreprise", x => x.id);
                    table.ForeignKey(
                        name: "FK_entreprise_contact_ContactIdContact",
                        column: x => x.ContactIdContact,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "personne",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prénom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactIdContact = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personne", x => x.id);
                    table.ForeignKey(
                        name: "FK_personne_contact_ContactIdContact",
                        column: x => x.ContactIdContact,
                        principalTable: "contact",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "réunion",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_réunion", x => x.id);
                    table.ForeignKey(
                        name: "FK_réunion_evenement_id",
                        column: x => x.id,
                        principalTable: "evenement",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "visite",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    rapport_visite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrepriseIdEntreprise = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_visite", x => x.id);
                    table.ForeignKey(
                        name: "FK_visite_entreprise_EntrepriseIdEntreprise",
                        column: x => x.EntrepriseIdEntreprise,
                        principalTable: "entreprise",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_visite_evenement_id",
                        column: x => x.id,
                        principalTable: "evenement",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "client",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_client", x => x.id);
                    table.ForeignKey(
                        name: "FK_client_personne_id",
                        column: x => x.id,
                        principalTable: "personne",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employé",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    salaire = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employé", x => x.id);
                    table.ForeignKey(
                        name: "FK_employé_personne_id",
                        column: x => x.id,
                        principalTable: "personne",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rendezvous",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false),
                    client_rendezvous_id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rendezvous", x => x.id);
                    table.ForeignKey(
                        name: "client_rendezvous_fk",
                        column: x => x.client_rendezvous_id,
                        principalTable: "client",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rendezvous_evenement_id",
                        column: x => x.id,
                        principalTable: "evenement",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmployéEntityRéunionEntity",
                columns: table => new
                {
                    EmployésIdPersonne = table.Column<long>(type: "bigint", nullable: false),
                    RéunionsIdEvenement = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployéEntityRéunionEntity", x => new { x.EmployésIdPersonne, x.RéunionsIdEvenement });
                    table.ForeignKey(
                        name: "FK_EmployéEntityRéunionEntity_employé_EmployésIdPersonne",
                        column: x => x.EmployésIdPersonne,
                        principalTable: "employé",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployéEntityRéunionEntity_réunion_RéunionsIdEvenement",
                        column: x => x.RéunionsIdEvenement,
                        principalTable: "réunion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployéEntityRéunionEntity_RéunionsIdEvenement",
                table: "EmployéEntityRéunionEntity",
                column: "RéunionsIdEvenement");

            migrationBuilder.CreateIndex(
                name: "IX_entreprise_ContactIdContact",
                table: "entreprise",
                column: "ContactIdContact");

            migrationBuilder.CreateIndex(
                name: "IX_evenement_evenement_agenda_id",
                table: "evenement",
                column: "evenement_agenda_id");

            migrationBuilder.CreateIndex(
                name: "IX_personne_ContactIdContact",
                table: "personne",
                column: "ContactIdContact");

            migrationBuilder.CreateIndex(
                name: "IX_rendezvous_client_rendezvous_id",
                table: "rendezvous",
                column: "client_rendezvous_id");

            migrationBuilder.CreateIndex(
                name: "IX_visite_EntrepriseIdEntreprise",
                table: "visite",
                column: "EntrepriseIdEntreprise");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployéEntityRéunionEntity");

            migrationBuilder.DropTable(
                name: "rendezvous");

            migrationBuilder.DropTable(
                name: "visite");

            migrationBuilder.DropTable(
                name: "employé");

            migrationBuilder.DropTable(
                name: "réunion");

            migrationBuilder.DropTable(
                name: "client");

            migrationBuilder.DropTable(
                name: "entreprise");

            migrationBuilder.DropTable(
                name: "evenement");

            migrationBuilder.DropTable(
                name: "personne");

            migrationBuilder.DropTable(
                name: "agenda");

            migrationBuilder.DropTable(
                name: "contact");
        }
    }
}
