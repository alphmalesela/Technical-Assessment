using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace back_end.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Text = table.Column<string>(type: "TEXT", nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => new { x.UserId, x.BookId });
                    table.ForeignKey(
                        name: "FK_Subscriptions_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Name", "PurchasePrice", "Text" },
                values: new object[,]
                {
                    { -30, "E-Commerce 101: Learn How to Start a Profitable Online Business Selling Products Online", 16.99m, "Chloe Thomas provides a beginner-friendly guide to launching and running a profitable eCommerce business." },
                    { -29, "The Ultimate Guide to Google AdWords", 21.99m, "Perry Marshall and Mike Rhodes offer a detailed guide on leveraging Google AdWords for effective digital marketing and eCommerce growth." },
                    { -28, "Invisible Selling Machine", 9.99m, "Ryan Deiss introduces automated sales strategies to enhance engagement and increase conversions in online businesses." },
                    { -27, "Click Millionaires: Work Less, Live More with an Internet Business You Love", 12.99m, "Scott Fox provides strategies for starting a profitable online business with minimal time investment." },
                    { -26, "Contagious: How to Build Word of Mouth in the Digital Age", 10.99m, "Jonah Berger explains how to create content that people want to share, an essential aspect for viral marketing in eCommerce." },
                    { -25, "DotCom Secrets: The Underground Playbook for Growing Your Company Online", 17.99m, "Russell Brunson shares secrets to successful online sales funnels and increasing conversions in eCommerce." },
                    { -24, "Building a StoryBrand: Clarify Your Message So Customers Will Listen", 13.99m, "Donald Miller offers insights on crafting compelling brand stories that connect with customers and drive engagement." },
                    { -23, "One Click: Jeff Bezos and the Rise of Amazon.com", 11.99m, "Richard L. Brandt details the meteoric rise of Amazon and the innovative strategies employed by Jeff Bezos." },
                    { -22, "The Everything Store: Jeff Bezos and the Age of Amazon", 14.99m, "Brad Stone explores the story behind Amazon and how Jeff Bezos built it into one of the largest eCommerce platforms in the world." },
                    { -21, "Ecommerce Evolved: The Essential Playbook To Build, Grow & Scale A Successful Ecommerce Business", 19.99m, "Tanner Larsson provides a comprehensive guide on strategies to build and scale a successful eCommerce business." },
                    { -20, "The Lord of the Rings", 15.99m, "J.R.R. Tolkien's fantasy epic about a group of heroes on a quest to destroy a powerful ring that could bring destruction to Middle-earth." },
                    { -19, "Jane Eyre", 7.99m, "Charlotte Brontë’s gothic romance following the life of a resilient orphan girl as she grows up and finds love and self-respect." },
                    { -18, "The Odyssey", 8.49m, "Homer's ancient epic that follows the hero Odysseus as he faces trials and adventures on his journey home from the Trojan War." },
                    { -17, "War and Peace", 12.99m, "Leo Tolstoy's historical masterpiece set during the Napoleonic Wars, examining the interconnected lives of several aristocratic families." },
                    { -16, "Moby Dick", 11.99m, "Herman Melville's epic tale of obsession and revenge, centered on Captain Ahab's relentless pursuit of the white whale." },
                    { -15, "The Catcher in the Rye", 9.49m, "J.D. Salinger's iconic novel following Holden Caulfield, a teenager navigating complex emotions and identity in post-war America." },
                    { -14, "The Great Gatsby", 10.99m, "F. Scott Fitzgerald's novel of the Jazz Age, a critique of the American Dream through the life of Jay Gatsby." },
                    { -13, "Pride and Prejudice", 7.99m, "Jane Austen's beloved novel of manners that examines the themes of love, class, and reputation in early 19th-century England." },
                    { -12, "1984", 8.99m, "George Orwell's dystopian novel that delves into the dangers of totalitarianism and extreme political ideology." },
                    { -11, "To Kill a Mockingbird", 9.99m, "Harper Lee's classic novel that explores racial injustice and moral growth in the American South." },
                    { -10, "Drive: The Surprising Truth About What Motivates Us", 11.99m, "Daniel H. Pink examines the science behind motivation, revealing surprising insights on what drives us." },
                    { -9, "The Innovator's Dilemma: When New Technologies Cause Great Firms to Fail", 18.99m, "Clayton Christensen’s groundbreaking book on how disruptive innovation affects industries and businesses." },
                    { -8, "Start with Why: How Great Leaders Inspire Everyone to Take Action", 13.99m, "Simon Sinek’s guide to inspiring others by focusing on purpose, rooted in his concept of the Golden Circle." },
                    { -7, "Principles: Life and Work", 19.99m, "Ray Dalio, one of the world's most successful investors, shares the principles he has developed over his career to achieve success." },
                    { -6, "The 7 Habits of Highly Effective People: Powerful Lessons in Personal Change", 12.99m, "Stephen Covey presents timeless principles that have helped millions find personal and professional effectiveness." },
                    { -5, "Zero to One: Notes on Startups, or How to Build the Future", 17.99m, "Peter Thiel explores how to create new, innovative businesses that go beyond mere competition to carve out unique niches." },
                    { -4, "How to Win Friends and Influence People", 10.99m, "Dale Carnegie’s timeless principles on building relationships and enhancing influence, first published in 1936 and still relevant today." },
                    { -3, "The Lean Startup: How Today's Entrepreneurs Use Continuous Innovation to Create Radically Successful Businesses", 16.99m, "Eric Ries shares a scientific approach to creating and managing successful startups in an age when companies need to innovate more than ever." },
                    { -2, "Good to Great: Why Some Companies Make the Leap... and Others Don't", 15.99m, "Jim Collins investigates why some companies succeed and others fail, providing insights into building long-lasting greatness." },
                    { -1, "Thinking, Fast and Slow", 14.99m, "An exploration of the two modes of thought: fast, intuitive thinking, and slower, logical reasoning by Nobel laureate Daniel Kahneman." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_BookId",
                table: "Subscriptions",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
