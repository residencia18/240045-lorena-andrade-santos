using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escambo.Infra.Migrations
{
    /// <inheritdoc />
    public partial class initialMigrationss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Conversas",
                columns: table => new
                {
                    ConversaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataHoraInicio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataHoraFim = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conversas", x => x.ConversaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CPF = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RG = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Nascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Endereço = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Credito = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    LinkLinkedln = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Sobre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Anuncios",
                columns: table => new
                {
                    AnuncioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeServico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Creditos = table.Column<decimal>(type: "decimal(65,30)", nullable: true),
                    Categoria = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anuncios", x => x.AnuncioId);
                    table.ForeignKey(
                        name: "FK_Anuncios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConversasHasUsuarios",
                columns: table => new
                {
                    ConversasIdMensagem = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConversasHasUsuarios", x => new { x.ConversasIdMensagem, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_ConversasHasUsuarios_Conversas_ConversasIdMensagem",
                        column: x => x.ConversasIdMensagem,
                        principalTable: "Conversas",
                        principalColumn: "ConversaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConversasHasUsuarios_Usuarios_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mensagens",
                columns: table => new
                {
                    MensagemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Texto = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataEnvio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    HoraEnvio = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ConversaId = table.Column<int>(type: "int", nullable: false),
                    ConversasIdMensagem = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensagens", x => x.MensagemId);
                    table.ForeignKey(
                        name: "FK_Mensagens_Conversas_ConversasIdMensagem",
                        column: x => x.ConversasIdMensagem,
                        principalTable: "Conversas",
                        principalColumn: "ConversaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Mensagens_Usuarios_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PrestacaoServicos",
                columns: table => new
                {
                    PrestacaoServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ServiçoId = table.Column<int>(type: "int", nullable: false),
                    Descrição = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Categoria = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Duração = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Credito = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ContratanteId = table.Column<int>(type: "int", nullable: false),
                    PrestadorId = table.Column<int>(type: "int", nullable: false),
                    AnuncioIdAnuncio = table.Column<int>(type: "int", nullable: false),
                    AnuncioId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestacaoServicos", x => x.PrestacaoServicoId);
                    table.ForeignKey(
                        name: "FK_PrestacaoServicos_Anuncios_AnuncioId",
                        column: x => x.AnuncioId,
                        principalTable: "Anuncios",
                        principalColumn: "AnuncioId");
                    table.ForeignKey(
                        name: "FK_PrestacaoServicos_Usuarios_ContratanteId",
                        column: x => x.ContratanteId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrestacaoServicos_Usuarios_PrestadorId",
                        column: x => x.PrestadorId,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    AvaliacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mensagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estelas = table.Column<int>(type: "int", nullable: true),
                    PrestacaoServicoId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.AvaliacaoId);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_PrestacaoServicos_PrestacaoServicoId",
                        column: x => x.PrestacaoServicoId,
                        principalTable: "PrestacaoServicos",
                        principalColumn: "PrestacaoServicoId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PrestacaoServicoHasUsuarios",
                columns: table => new
                {
                    PrestacaoServicoIdPrestacaoServico = table.Column<int>(type: "int", nullable: false),
                    UsuariosIdUsuario = table.Column<int>(type: "int", nullable: false),
                    IsPrestador = table.Column<bool>(type: "tinyint(1)", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestacaoServicoHasUsuarios", x => new { x.PrestacaoServicoIdPrestacaoServico, x.UsuariosIdUsuario });
                    table.ForeignKey(
                        name: "FK_PrestacaoServicoHasUsuarios_PrestacaoServicos_PrestacaoServi~",
                        column: x => x.PrestacaoServicoIdPrestacaoServico,
                        principalTable: "PrestacaoServicos",
                        principalColumn: "PrestacaoServicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrestacaoServicoHasUsuarios_Usuarios_UsuariosIdUsuario",
                        column: x => x.UsuariosIdUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PrestacaoServicoHasAvaliacoes",
                columns: table => new
                {
                    PrestacaoServicoIdPrestacaoServico = table.Column<int>(type: "int", nullable: false),
                    AvaliacoesIdAvaliacoes = table.Column<int>(type: "int", nullable: false),
                    AvaliacoesAvaliacaoId = table.Column<int>(type: "int", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Updated = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false),
                    Deleted = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrestacaoServicoHasAvaliacoes", x => new { x.PrestacaoServicoIdPrestacaoServico, x.AvaliacoesIdAvaliacoes });
                    table.ForeignKey(
                        name: "FK_PrestacaoServicoHasAvaliacoes_Avaliacoes_AvaliacoesAvaliacao~",
                        column: x => x.AvaliacoesAvaliacaoId,
                        principalTable: "Avaliacoes",
                        principalColumn: "AvaliacaoId");
                    table.ForeignKey(
                        name: "FK_PrestacaoServicoHasAvaliacoes_PrestacaoServicos_PrestacaoSer~",
                        column: x => x.PrestacaoServicoIdPrestacaoServico,
                        principalTable: "PrestacaoServicos",
                        principalColumn: "PrestacaoServicoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Anuncios_UsuarioId",
                table: "Anuncios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_PrestacaoServicoId",
                table: "Avaliacoes",
                column: "PrestacaoServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ConversasHasUsuarios_UsuariosIdUsuario",
                table: "ConversasHasUsuarios",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_ConversasIdMensagem",
                table: "Mensagens",
                column: "ConversasIdMensagem");

            migrationBuilder.CreateIndex(
                name: "IX_Mensagens_UsuariosIdUsuario",
                table: "Mensagens",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PrestacaoServicoHasAvaliacoes_AvaliacoesAvaliacaoId",
                table: "PrestacaoServicoHasAvaliacoes",
                column: "AvaliacoesAvaliacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestacaoServicoHasUsuarios_UsuariosIdUsuario",
                table: "PrestacaoServicoHasUsuarios",
                column: "UsuariosIdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_PrestacaoServicos_AnuncioId",
                table: "PrestacaoServicos",
                column: "AnuncioId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestacaoServicos_ContratanteId",
                table: "PrestacaoServicos",
                column: "ContratanteId");

            migrationBuilder.CreateIndex(
                name: "IX_PrestacaoServicos_PrestadorId",
                table: "PrestacaoServicos",
                column: "PrestadorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConversasHasUsuarios");

            migrationBuilder.DropTable(
                name: "Mensagens");

            migrationBuilder.DropTable(
                name: "PrestacaoServicoHasAvaliacoes");

            migrationBuilder.DropTable(
                name: "PrestacaoServicoHasUsuarios");

            migrationBuilder.DropTable(
                name: "Conversas");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "PrestacaoServicos");

            migrationBuilder.DropTable(
                name: "Anuncios");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
