namespace EntityFrameworkFolha.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadeAtualizada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Salario", "PisoSalarial", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Salario", "PisoSalarial");
        }
    }
}
