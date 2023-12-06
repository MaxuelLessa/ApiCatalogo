using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiCatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulajCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("insert into apicatalogodb.Categoria(Nome, ImagemUrl) values('Bebidas', 'Bebidas.jpg')");
            mb.Sql("insert into apicatalogodb.Categoria(Nome, ImagemUrl) values('Lanches', 'Lanches.jpg')");
            mb.Sql("insert into apicatalogodb.Categoria(Nome, ImagemUrl) values('Sobremesas', 'Sobremesas.jpg')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categoria");
        }
    }
}
