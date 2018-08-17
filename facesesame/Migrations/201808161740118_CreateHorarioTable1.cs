namespace facesesame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateHorarioTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        HEntrada = c.DateTime(nullable: false),
                        HSalida = c.DateTime(nullable: false),
                        IDU = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Horarios");
        }
    }
}
