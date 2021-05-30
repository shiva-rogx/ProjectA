namespace ClinicManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDb : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Attendances", "PatientId", "dbo.Patients");
            DropIndex("dbo.Attendances", new[] { "PatientId" });
            DropTable("dbo.Attendances");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClinicRemarks = c.String(nullable: false),
                        Diagnosis = c.String(nullable: false, maxLength: 255),
                        SecondDiagnosis = c.String(),
                        ThirdDiagnosis = c.String(),
                        Therapy = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        PatientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Attendances", "PatientId");
            AddForeignKey("dbo.Attendances", "PatientId", "dbo.Patients", "Id", cascadeDelete: true);
        }
    }
}
