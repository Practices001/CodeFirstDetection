namespace facesesame.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPuestosTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Puestos",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Puesto = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Puestos");
        }
    }
}
