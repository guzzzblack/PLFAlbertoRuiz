using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    idcategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrecategoria = table.Column<string>(type: "varchar(45)", nullable: false),
                    descripcioncategoria = table.Column<string>(type: "varchar(250)", nullable: false),
                    activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.idcategoria);
                });

            migrationBuilder.CreateTable(
                name: "PermisoCat",
                columns: table => new
                {
                    idpermiso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idcategoria = table.Column<int>(type: "int", nullable: false),
                    idusuariopermitido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermisoCat", x => x.idpermiso);
                });

            migrationBuilder.CreateTable(
                name: "Tareas",
                columns: table => new
                {
                    idtarea = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estadotarea = table.Column<int>(type: "int", nullable: false),
                    fechainicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    fechafin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    prioridad = table.Column<int>(type: "int", nullable: false),
                    descripcion = table.Column<string>(type: "varchar(250)", nullable: true),
                    archivado = table.Column<bool>(type: "bit", nullable: false),
                    idusuariocreador = table.Column<int>(type: "int", nullable: false),
                    idusuarioasignado = table.Column<int>(type: "int", nullable: false),
                    idusuariotermino = table.Column<int>(type: "int", nullable: false),
                    idcategoriatarea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tareas", x => x.idtarea);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    idusuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correo = table.Column<string>(type: "varchar(80)", nullable: false),
                    password = table.Column<string>(type: "varchar(80)", nullable: false),
                    tipousuario = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "varchar(80)", nullable: false),
                    apellido = table.Column<string>(type: "varchar(80)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.idusuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "PermisoCat");

            migrationBuilder.DropTable(
                name: "Tareas");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
