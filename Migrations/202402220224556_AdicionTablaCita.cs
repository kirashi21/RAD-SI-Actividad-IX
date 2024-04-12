namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AdicionTablaCita : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cita",
                c => new
                {
                    MedicoId = c.Int(nullable: false, identity: true),
                    Nombres = c.String(nullable: false, maxLength: 120),
                    Apellidos = c.String(nullable: false, maxLength: 120),
                    Estado = c.Boolean(nullable: false),
                    FechaCita = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.PacienteId);
                .ForeignKey("dbo.Medico", t => t.MedicoId)
                .ForeignKey("dbo.Paciente", t => t.PacienteId)
                .Index(t => t.MedicoId)
                .Index(t => t.PacienteId);

                 public override void Down()
                 {
                        DropForeignKey("dbo.Cita", "MedicoId", "dbo.Medico");
                        DropForeignKey("dbo.Cita", "PacienteId", "dbo.Paciente");
                        DropIndex("dbo.Cita", new[] { "MedicoId" });
                        DropIndex("dbo.Cita", new[] { "" });
                        DropTable("dbo.Cita");
                 }
    }

}