namespace learning_full_stack_developer_dotnet_framework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) Values ('Jazz')");
            Sql("INSERT INTO Genres (Name) Values ('Pop')");
            Sql("INSERT INTO Genres (Name) Values ('Hip Hop')");
            Sql("INSERT INTO Genres (Name) Values ('Indie')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
 