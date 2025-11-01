using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Furni.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Region = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
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
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Mail = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Body = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SliderImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alt = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RoleId = table.Column<Guid>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
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
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    AppUserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    AppUserId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Alt = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageType = table.Column<int>(type: "INTEGER", nullable: false),
                    RelatedEntityId = table.Column<Guid>(type: "TEXT", nullable: true),
                    RelatedEntityType = table.Column<string>(type: "TEXT", nullable: true),
                    FeatureId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Text = table.Column<string>(type: "TEXT", nullable: false),
                    FeatureId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Features_FeatureId",
                        column: x => x.FeatureId,
                        principalTable: "Features",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Tittle = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Page = table.Column<int>(type: "INTEGER", nullable: false),
                    SliderImageId = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sliders_SliderImage_SliderImageId",
                        column: x => x.SliderImageId,
                        principalTable: "SliderImage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Surname = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    CartId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    ItemPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { new Guid("7eaa7b8a-dea2-4081-91dd-83ff540e780e"), "Baku", 1052, "Yasamal", "Tbilisi Avenue 45" });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Mail", "Phone" },
                values: new object[] { new Guid("115378e2-fea3-4ed5-a02a-aa732514164a"), "info@furni.az", "+994 50 123 45 67" });

            migrationBuilder.InsertData(
                table: "Features",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "Donec facilisis quam ut purus rutrum lobortis. Donec vitae odio quis nisl dapibus malesuada. Nullam ac aliquet velit. Aliquam vulputate velit imperdiet dolor tempor tristique. Pellentesque habitant morbi tristique senectus et netus et malesuada", "We Help You Make Modern Interior Design" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Alt", "FeatureId", "ImageType", "RelatedEntityId", "RelatedEntityType", "Url" },
                values: new object[,]
                {
                    { new Guid("178145d8-237d-44c5-9ad1-a7ac37d0856a"), "nordic_chair", null, 1, new Guid("836abebe-b2f0-4a99-b035-c1ce0535d8d0"), "TeamMember", "/furni/images/team_member/person_1.jpg" },
                    { new Guid("2710058d-7aa2-42d5-9de3-54d4a197d679"), "nordic_chair", null, 3, new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "Feature", "/furni/images/features/img-grid-2.jpg" },
                    { new Guid("2eb129b8-2521-4b56-b734-888e31f5dbb8"), "nordic_chair", null, 0, new Guid("b88c6c96-2e03-4100-a364-983a5a08149b"), "Product", "/furni/images/product/product-2.png" },
                    { new Guid("4042b3be-3dad-4f49-9df8-f0ef3ea8c450"), "nordic_chair", null, 0, new Guid("20bb2db5-43f9-45ae-b74d-541df5d6e75a"), "Product", "/furni/images/product/product-3.png" },
                    { new Guid("5a9fe4d0-d610-4d10-ab0e-7963c160ff93"), "nordic_chair", null, 0, new Guid("e40f7ce6-ddfb-4484-8fd7-3a93c456d5be"), "Product", "/furni/images/product/product-4.png" },
                    { new Guid("609ca707-ce3c-468a-9a6e-41e343f694b7"), "nordic_chair", null, 1, new Guid("2a36057b-6060-4c4c-a7cf-bef3891da8f1"), "TeamMember", "/furni/images/team_member/person_1.jpg" },
                    { new Guid("7ca74e81-a0b7-40df-9773-d9eba4541244"), "nordic_chair", null, 3, new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "Feature", "/furni/images/features/img-grid-3.jpg" },
                    { new Guid("82e63a5e-7d60-460b-8298-a2867a24175b"), "nordic_chair", null, 0, new Guid("46fd8e61-7670-4037-9ec4-a772f602b27b"), "Product", "/furni/images/product/product-2.png" },
                    { new Guid("afcdf3e8-83d8-496a-946e-b62b60584748"), "nordic_chair", null, 0, new Guid("80086632-658a-40b0-b152-a471a7a64df0"), "Product", "/furni/images/product/product-1.png" },
                    { new Guid("be25a131-f8ab-4157-a243-ad12ebe9020e"), "nordic_chair", null, 0, new Guid("e40ee004-dccb-42bf-9af0-cf52ff265c9b"), "Product", "/furni/images/product/product-4.png" },
                    { new Guid("bea822cf-509c-4a64-9fa8-03b67161be56"), "nordic_chair", null, 1, new Guid("2d9ee73b-8e5e-4fdc-8b11-f8b2ac85d7b4"), "TeamMember", "/furni/images/team_member/person_1.jpg" },
                    { new Guid("d8c5b052-88b0-4369-9c47-2373ef7e4fbf"), "nordic_chair", null, 1, new Guid("ecf3ee48-c608-4c66-be4a-d6aa586f50e9"), "TeamMember", "/furni/images/team_member/person_1.jpg" },
                    { new Guid("e3cd5177-1b74-43d4-b911-14de2c740371"), "nordic_chair", null, 0, new Guid("dd2896cf-fcef-45ed-8ae9-93a5d02c662d"), "Product", "/furni/images/product/product-1.png" },
                    { new Guid("e8691e2f-3a21-4127-bbc7-fdc4beb70de4"), "nordic_chair", null, 0, new Guid("81cecee6-b6a8-4bba-a937-e88e40c228a6"), "Product", "/furni/images/product/product-3.png" },
                    { new Guid("efd2ce03-b209-4bbf-8751-7bac09c53ac4"), "nordic_chair", null, 3, new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "Feature", "/furni/images/features/img-grid-1.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageId", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("20bb2db5-43f9-45ae-b74d-541df5d6e75a"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("46fd8e61-7670-4037-9ec4-a772f602b27b"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("80086632-658a-40b0-b152-a471a7a64df0"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("81cecee6-b6a8-4bba-a937-e88e40c228a6"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("b88c6c96-2e03-4100-a364-983a5a08149b"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("dd2896cf-fcef-45ed-8ae9-93a5d02c662d"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("e40ee004-dccb-42bf-9af0-cf52ff265c9b"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("e40f7ce6-ddfb-4484-8fd7-3a93c456d5be"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m },
                    { new Guid("e60070aa-0b4a-42d0-8f8d-0c84806dc10b"), "The Nordic Chair blends minimalism with comfort, inspired by Scandinavian design principles. Crafted from durable oak wood and upholstered with soft linen fabric, it provides both elegance and support. Its clean lines, natural finish, and ergonomic shape make it perfect for modern homes, cafes, or offices seeking timeless, cozy sophistication.", null, "Nordic chair", 59m }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("6564eb6d-89ee-4ac5-9491-4a6e4d011ffe"), "Our design experts help you choose the perfect combination of colors and furniture.", "Interior Consultation" },
                    { new Guid("754ba866-d61a-4582-ab70-2ebb926f3ee1"), "We ensure safe delivery and professional assembly of all furniture pieces.", "Delivery & Assembly" },
                    { new Guid("9db157b1-2563-4d4f-a86e-f4b9f889ca92"), "Our support team assists with maintenance and warranty-related inquiries.", "After-Sales Support" },
                    { new Guid("c9de341c-a872-4736-832e-f7340883e762"), "We design personalized furniture based on your taste and space layout.", "Custom Furniture Design" }
                });

            migrationBuilder.InsertData(
                table: "SliderImage",
                columns: new[] { "Id", "Alt", "Url" },
                values: new object[] { new Guid("4de142fb-97f9-4a34-88a6-f3f6d32b17eb"), "Modern Nordic Chair in minimal room", "furni/images/sliders/images/couch.png" });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "Description", "ImageId", "Name", "Surname", "Title" },
                values: new object[,]
                {
                    { new Guid("2a36057b-6060-4c4c-a7cf-bef3891da8f1"), "Michael manages the marketing strategy and ensures that Furni’s vision reaches customers worldwide.", null, "Michael", "Brown", "Marketing Director" },
                    { new Guid("2d9ee73b-8e5e-4fdc-8b11-f8b2ac85d7b4"), "Sarah specializes in creating modern and minimalist interior solutions that combine beauty and functionality.", null, "Sarah", "Johnson", "Interior Designer" },
                    { new Guid("836abebe-b2f0-4a99-b035-c1ce0535d8d0"), "John leads the company with over 10 years of experience in furniture design and business strategy.", null, "John", "Smith", "Founder & CEO" },
                    { new Guid("ecf3ee48-c608-4c66-be4a-d6aa586f50e9"), "Emma ensures a smooth and satisfying experience for every customer, from first contact to after-sales support.", null, "Emma", "Davis", "Customer Relations Manager" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "FeatureId", "Text" },
                values: new object[,]
                {
                    { new Guid("2c9ee229-15ab-46bb-9084-1f0ef190765a"), new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "Free delivery on orders over 500 AZN." },
                    { new Guid("45407f1d-81bd-404d-b92f-b8775ee99b06"), new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "Exclusive discounts on all living room collections." },
                    { new Guid("7e352dfd-e936-43d2-96f6-d3c4d39e0c87"), new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "High-quality materials with long-lasting durability." },
                    { new Guid("e61ac57a-e1ad-4995-9166-d3a286d7ac73"), new Guid("4e75b8e2-b8b4-4956-985f-6c22f37610e4"), "Modern design furniture for stylish homes." }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Description", "Page", "SliderImageId", "Tittle" },
                values: new object[,]
                {
                    { new Guid("4c093d51-7e4b-4788-907d-39337c610a84"), "Donec vitae odio quis nisl dapibus malesuada. Nullam ac aliquet velit. Aliquam vulputate velit imperdiet dolor tempor tristique.", 3, new Guid("4de142fb-97f9-4a34-88a6-f3f6d32b17eb"), "Services" },
                    { new Guid("534105d0-908f-47fa-a2c6-248f6d49ff7d"), "Donec vitae odio quis nisl dapibus malesuada. Nullam ac aliquet velit. Aliquam vulputate velit imperdiet dolor tempor tristique.", 2, new Guid("4de142fb-97f9-4a34-88a6-f3f6d32b17eb"), "Contact" },
                    { new Guid("c4f9293b-9370-44ea-a561-54609aaca790"), "Donec vitae odio quis nisl dapibus malesuada. Nullam ac aliquet velit. Aliquam vulputate velit imperdiet dolor tempor tristique.", 1, new Guid("4de142fb-97f9-4a34-88a6-f3f6d32b17eb"), "About Us" },
                    { new Guid("c9b2e447-afb2-4609-a54f-2d8722557707"), "Donec vitae odio quis nisl dapibus malesuada. Nullam ac aliquet velit. Aliquam vulputate velit imperdiet dolor tempor tristique.", 0, new Guid("4de142fb-97f9-4a34-88a6-f3f6d32b17eb"), "Modern Interior Design Studio" }
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
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_FeatureId",
                table: "Images",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_FeatureId",
                table: "Offers",
                column: "FeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ImageId",
                table: "Products",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Sliders_SliderImageId",
                table: "Sliders",
                column: "SliderImageId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_ImageId",
                table: "TeamMembers",
                column: "ImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Address");

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
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SliderImage");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
