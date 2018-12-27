namespace GighubV2.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Jazz')");
            Sql("INSERT INTO Genres (Name) VALUES ('Rock')");
            Sql("INSERT INTO Genres (Name) VALUES ('Blues')");
            Sql("INSERT INTO Genres (Name) VALUES ('Hip Hop')");
            Sql("INSERT INTO Genres (Name) VALUES ('Country')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4, 5)");
        }
    }
}
