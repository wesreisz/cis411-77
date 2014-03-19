namespace PetStore_web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pushing_model : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        personId = c.Int(nullable: false, identity: true),
                        displayName = c.String(),
                        lastUpdateDate = c.DateTime(nullable: false),
                        uid = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.personId);
            
            CreateTable(
                "dbo.Pet",
                c => new
                    {
                        petId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        description = c.String(),
                        quanity = c.Int(nullable: false),
                        price = c.Double(nullable: false),
                        lastUpdateDate = c.DateTime(nullable: false),
                        smlPicture = c.String(),
                        lrgPicture = c.String(),
                        personId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.petId)
                .ForeignKey("dbo.Person", t => t.personId, cascadeDelete: true)
                .Index(t => t.personId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pet", "personId", "dbo.Person");
            DropIndex("dbo.Pet", new[] { "personId" });
            DropTable("dbo.Pet");
            DropTable("dbo.Person");
        }
    }
}
