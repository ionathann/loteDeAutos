namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Accesos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Registros",
                c => new
                    {
                        pkRegistro = c.Int(nullable: false, identity: true),
                        fecha = c.DateTime(nullable: false, precision: 0),
                        Descripcion = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        usuario_pkUsuario = c.Int(),
                    })
                .PrimaryKey(t => t.pkRegistro)
                .ForeignKey("dbo.Usuarios", t => t.usuario_pkUsuario)
                .Index(t => t.usuario_pkUsuario);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Registros", "usuario_pkUsuario", "dbo.Usuarios");
            DropIndex("dbo.Registros", new[] { "usuario_pkUsuario" });
            DropTable("dbo.Registros");
        }
    }
}
