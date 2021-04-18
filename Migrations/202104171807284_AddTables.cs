namespace Razrab.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DirectionTrainings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Code = c.String(),
                        Orientation_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orientations", t => t.Orientation_Id)
                .Index(t => t.Orientation_Id);
            
            CreateTable(
                "dbo.Orientations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrientationTechnologies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Orientation_Id = c.Long(),
                        Technology_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orientations", t => t.Orientation_Id)
                .ForeignKey("dbo.Technologies", t => t.Technology_Id)
                .Index(t => t.Orientation_Id)
                .Index(t => t.Technology_Id);
            
            CreateTable(
                "dbo.Technologies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TechnologyVacancies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Technology_Id = c.Long(),
                        Vacancy_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Technologies", t => t.Technology_Id)
                .ForeignKey("dbo.Vacancies", t => t.Vacancy_Id)
                .Index(t => t.Technology_Id)
                .Index(t => t.Vacancy_Id);
            
            CreateTable(
                "dbo.Vacancies",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        OrganizationName = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        ContactName = c.String(),
                        FillDate = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Sallary = c.Int(nullable: false),
                        Region_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .Index(t => t.Region_Id);
            
            CreateTable(
                "dbo.Univercities",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Title = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        ContactName = c.String(),
                        DirectionTraining_Id = c.Long(),
                        Region_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DirectionTrainings", t => t.DirectionTraining_Id)
                .ForeignKey("dbo.Regions", t => t.Region_Id)
                .Index(t => t.DirectionTraining_Id)
                .Index(t => t.Region_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Univercities", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.Univercities", "DirectionTraining_Id", "dbo.DirectionTrainings");
            DropForeignKey("dbo.TechnologyVacancies", "Vacancy_Id", "dbo.Vacancies");
            DropForeignKey("dbo.Vacancies", "Region_Id", "dbo.Regions");
            DropForeignKey("dbo.TechnologyVacancies", "Technology_Id", "dbo.Technologies");
            DropForeignKey("dbo.OrientationTechnologies", "Technology_Id", "dbo.Technologies");
            DropForeignKey("dbo.OrientationTechnologies", "Orientation_Id", "dbo.Orientations");
            DropForeignKey("dbo.DirectionTrainings", "Orientation_Id", "dbo.Orientations");
            DropIndex("dbo.Univercities", new[] { "Region_Id" });
            DropIndex("dbo.Univercities", new[] { "DirectionTraining_Id" });
            DropIndex("dbo.Vacancies", new[] { "Region_Id" });
            DropIndex("dbo.TechnologyVacancies", new[] { "Vacancy_Id" });
            DropIndex("dbo.TechnologyVacancies", new[] { "Technology_Id" });
            DropIndex("dbo.OrientationTechnologies", new[] { "Technology_Id" });
            DropIndex("dbo.OrientationTechnologies", new[] { "Orientation_Id" });
            DropIndex("dbo.DirectionTrainings", new[] { "Orientation_Id" });
            DropTable("dbo.Univercities");
            DropTable("dbo.Vacancies");
            DropTable("dbo.TechnologyVacancies");
            DropTable("dbo.Regions");
            DropTable("dbo.Technologies");
            DropTable("dbo.OrientationTechnologies");
            DropTable("dbo.Orientations");
            DropTable("dbo.DirectionTrainings");
        }
    }
}
