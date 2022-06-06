using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GordoExpress.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Cervejas Normais', 'Cervejas ambev e baixo custo')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Cervejas Premium', 'Cervejas importadas ou artesanais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Vinhos', 'Vinhos de todos os tipos')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Destilados', 'Destilados de diversos tipos')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Refrigerantes', 'Refrigerantes de todos os sabores')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Sucos', 'Sucos de diversos tipos')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Energéticos', 'Energéticos de diversas os marcas')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao)" +
                "VALUES('Água', 'Garrafa 500ml, Garrafa 1,5l e Galão 20l')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");

        }
    }
}
