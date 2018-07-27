namespace LibraryManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBorrowHistory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BorrowHistories",
                c => new
                    {
                        BorrowHistoryId = c.Int(nullable: false, identity: true),
                        BookId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        BorrowDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.BorrowHistoryId)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.BookId)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowHistories", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.BorrowHistories", "BookId", "dbo.Books");
            DropIndex("dbo.BorrowHistories", new[] { "CustomerId" });
            DropIndex("dbo.BorrowHistories", new[] { "BookId" });
            DropTable("dbo.BorrowHistories");
        }
    }
}
