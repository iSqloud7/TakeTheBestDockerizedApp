namespace TakeTheBest_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerID = c.Int(nullable: false, identity: true),
                        customerName = c.String(nullable: false),
                        customerSurname = c.String(nullable: false),
                        customerAge = c.Int(nullable: false),
                        customerImage = c.String(),
                        restaurantID = c.Int(nullable: false),
                        SelectedItemID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.customerID)
                .ForeignKey("dbo.Restaurants", t => t.restaurantID, cascadeDelete: true)
                .Index(t => t.restaurantID);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        menuID = c.Int(nullable: false, identity: true),
                        menuName = c.String(nullable: false),
                        menuIngredients = c.String(nullable: false),
                        menuImage = c.String(nullable: false),
                        menuPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        menuRecommendation = c.String(),
                        Customer_customerID = c.Int(),
                    })
                .PrimaryKey(t => t.menuID)
                .ForeignKey("dbo.Customers", t => t.Customer_customerID)
                .Index(t => t.Customer_customerID);
            
            CreateTable(
                "dbo.Restaurants",
                c => new
                    {
                        restaurantID = c.Int(nullable: false, identity: true),
                        restaurantName = c.String(nullable: false),
                        restaurantAddress = c.String(nullable: false),
                        restaurantRating = c.Decimal(nullable: false, precision: 18, scale: 2),
                        restaurantImage = c.String(),
                        restaurantDescription = c.String(),
                    })
                .PrimaryKey(t => t.restaurantID);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        categoryID = c.Int(nullable: false, identity: true),
                        categoryName = c.String(nullable: false, maxLength: 100),
                        categoryDescription = c.String(nullable: false),
                        categoryIngredients = c.String(),
                        categoryOrigin = c.String(),
                        categoryRating = c.Double(nullable: false),
                        categoryPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        categoryImage = c.String(),
                    })
                .PrimaryKey(t => t.categoryID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Customers", "restaurantID", "dbo.Restaurants");
            DropForeignKey("dbo.Menus", "Customer_customerID", "dbo.Customers");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Menus", new[] { "Customer_customerID" });
            DropIndex("dbo.Customers", new[] { "restaurantID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.FoodCategories");
            DropTable("dbo.Restaurants");
            DropTable("dbo.Menus");
            DropTable("dbo.Customers");
        }
    }
}
