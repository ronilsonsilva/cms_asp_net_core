using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CMS.Infra.Migrations
{
    public partial class Migration_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardParceiros",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NomeParceiro = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    LogoParceiro = table.Column<byte[]>(nullable: true),
                    LogoParceiroType = table.Column<string>(nullable: true),
                    HabilitarWhatsApp = table.Column<bool>(nullable: false),
                    HabilitarFacebook = table.Column<bool>(nullable: false),
                    HabilitarInstagram = table.Column<bool>(nullable: false),
                    HabilitarGoogleMais = table.Column<bool>(nullable: false),
                    HabilitarPinterest = table.Column<bool>(nullable: false),
                    WhatsAppNumero = table.Column<string>(nullable: true),
                    FacebookURL = table.Column<string>(nullable: true),
                    InstagramURL = table.Column<string>(nullable: true),
                    GoogleMaisURL = table.Column<string>(nullable: true),
                    PinterestURL = table.Column<string>(nullable: true),
                    TwitterURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardParceiros", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSFaleConosco",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    HabilitarWhatsApp = table.Column<bool>(nullable: false),
                    HabilitarEmail = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HabilitarLocalizacao = table.Column<bool>(nullable: false),
                    Localizacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSFaleConosco", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSHome",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    SubTitulo = table.Column<string>(nullable: true),
                    HabilitarWhatsApp = table.Column<bool>(nullable: false),
                    HabilitarFacebook = table.Column<bool>(nullable: false),
                    HabilitarInstagram = table.Column<bool>(nullable: false),
                    HabilitarGoogleMais = table.Column<bool>(nullable: false),
                    HabilitarPinterest = table.Column<bool>(nullable: false),
                    HabilitarTwitter = table.Column<bool>(nullable: false),
                    SlideImagem = table.Column<byte[]>(nullable: true),
                    SlideImagemType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSHome", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSParceiros",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSParceiros", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSPlanos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    SubTitulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSPlanos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSServicos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    HabilitarTitulo = table.Column<bool>(nullable: false),
                    SubtTitulo = table.Column<string>(nullable: true),
                    SubTitulo = table.Column<bool>(nullable: false),
                    Conteudo = table.Column<string>(nullable: true),
                    Imagem = table.Column<byte[]>(nullable: true),
                    ImagemType = table.Column<string>(nullable: true),
                    HabilitarImagem = table.Column<bool>(nullable: false),
                    ImagemCitacao = table.Column<byte[]>(nullable: true),
                    ImagemCitacaoType = table.Column<string>(nullable: true),
                    TextoCitacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSServicos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSSobre",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    HabilitarTitulo = table.Column<bool>(nullable: false),
                    SubtTitulo = table.Column<string>(nullable: true),
                    SubTitulo = table.Column<bool>(nullable: false),
                    Conteudo = table.Column<string>(nullable: true),
                    HabilitarImagem = table.Column<bool>(nullable: false),
                    Imagem = table.Column<byte[]>(nullable: true),
                    ImagemType = table.Column<string>(nullable: true),
                    HabilitarWhatsApp = table.Column<bool>(nullable: false),
                    HabilitarFacebook = table.Column<bool>(nullable: false),
                    HabilitarInstagram = table.Column<bool>(nullable: false),
                    HabilitarGoogleMais = table.Column<bool>(nullable: false),
                    HabilitarPinterest = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSSobre", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ImagemGaleria",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Imagem = table.Column<byte[]>(nullable: true),
                    ImagemType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagemGaleria", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CMSTabelaDePlanos",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    TextoHeader = table.Column<string>(nullable: true),
                    TextoFooter = table.Column<string>(nullable: true),
                    Descircao = table.Column<string>(nullable: true),
                    ValorPlano = table.Column<decimal>(nullable: false),
                    IdCMSPlanos = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMSTabelaDePlanos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CMSTabelaDePlanos_CMSPlanos_IdCMSPlanos",
                        column: x => x.IdCMSPlanos,
                        principalTable: "CMSPlanos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Website",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    NomeWebsite = table.Column<string>(nullable: true),
                    TituloHeader = table.Column<string>(nullable: true),
                    Icone = table.Column<byte[]>(nullable: true),
                    IconeType = table.Column<string>(nullable: true),
                    LogoTopo = table.Column<byte[]>(nullable: true),
                    LogoTopoType = table.Column<string>(nullable: true),
                    WhatsAppNumero = table.Column<string>(nullable: true),
                    FacebookURL = table.Column<string>(nullable: true),
                    InstagramURL = table.Column<string>(nullable: true),
                    GoogleMaisURL = table.Column<string>(nullable: true),
                    PinterestURL = table.Column<string>(nullable: true),
                    TwitterURL = table.Column<string>(nullable: true),
                    IdCMSFaleConosco = table.Column<Guid>(nullable: false),
                    CMSFaleConoscoID = table.Column<Guid>(nullable: true),
                    IdCMSGaleriaFotos = table.Column<Guid>(nullable: false),
                    IdCMSHome = table.Column<Guid>(nullable: false),
                    CMShomeID = table.Column<Guid>(nullable: true),
                    IdCMSParceiros = table.Column<Guid>(nullable: false),
                    CMSParceirosID = table.Column<Guid>(nullable: true),
                    IdCMSPlanos = table.Column<Guid>(nullable: false),
                    CMSPlanosID = table.Column<Guid>(nullable: true),
                    IdCMSServiso = table.Column<Guid>(nullable: false),
                    CMSServicosID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Website", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Website_CMSFaleConosco_CMSFaleConoscoID",
                        column: x => x.CMSFaleConoscoID,
                        principalTable: "CMSFaleConosco",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Website_CMSParceiros_CMSParceirosID",
                        column: x => x.CMSParceirosID,
                        principalTable: "CMSParceiros",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Website_CMSPlanos_CMSPlanosID",
                        column: x => x.CMSPlanosID,
                        principalTable: "CMSPlanos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Website_CMSServicos_CMSServicosID",
                        column: x => x.CMSServicosID,
                        principalTable: "CMSServicos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Website_CMSHome_CMShomeID",
                        column: x => x.CMShomeID,
                        principalTable: "CMSHome",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaWebsite",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    IdHtml = table.Column<string>(nullable: true),
                    IdWebsite = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaWebsite", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AreaWebsite_Website_IdWebsite",
                        column: x => x.IdWebsite,
                        principalTable: "Website",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaWebsite_IdWebsite",
                table: "AreaWebsite",
                column: "IdWebsite");

            migrationBuilder.CreateIndex(
                name: "IX_CMSTabelaDePlanos_IdCMSPlanos",
                table: "CMSTabelaDePlanos",
                column: "IdCMSPlanos");

            migrationBuilder.CreateIndex(
                name: "IX_Website_CMSFaleConoscoID",
                table: "Website",
                column: "CMSFaleConoscoID");

            migrationBuilder.CreateIndex(
                name: "IX_Website_CMSParceirosID",
                table: "Website",
                column: "CMSParceirosID");

            migrationBuilder.CreateIndex(
                name: "IX_Website_CMSPlanosID",
                table: "Website",
                column: "CMSPlanosID");

            migrationBuilder.CreateIndex(
                name: "IX_Website_CMSServicosID",
                table: "Website",
                column: "CMSServicosID");

            migrationBuilder.CreateIndex(
                name: "IX_Website_CMShomeID",
                table: "Website",
                column: "CMShomeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaWebsite");

            migrationBuilder.DropTable(
                name: "CardParceiros");

            migrationBuilder.DropTable(
                name: "CMSSobre");

            migrationBuilder.DropTable(
                name: "CMSTabelaDePlanos");

            migrationBuilder.DropTable(
                name: "ImagemGaleria");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Website");

            migrationBuilder.DropTable(
                name: "CMSFaleConosco");

            migrationBuilder.DropTable(
                name: "CMSParceiros");

            migrationBuilder.DropTable(
                name: "CMSPlanos");

            migrationBuilder.DropTable(
                name: "CMSServicos");

            migrationBuilder.DropTable(
                name: "CMSHome");
        }
    }
}
