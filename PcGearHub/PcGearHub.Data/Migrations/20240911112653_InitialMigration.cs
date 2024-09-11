using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PcGearHub.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "UpdateDB");

            migrationBuilder.CreateSequence(
                name: "AddressesAddressIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "CategoriesCategoryIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "OrderItemsOrderItemIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "OrdersOrderIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "PaymentMethodsPaymentMethodIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "PaymentsPaymentIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "PermissionsPermissionIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "ProductReviewsReviewIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "ProductsProductIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "RolePermissionsRolePermissionIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "UserRolesUserRoleIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateSequence(
                name: "UsersUserIdSeq",
                schema: "UpdateDB",
                maxValue: 2147483647L);

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "UpdateDB",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CategoriesPkey", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                schema: "UpdateDB",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MethodName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PaymentMethodsPkey", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                schema: "UpdateDB",
                columns: table => new
                {
                    PermissionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PermissionName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PermissionsPkey", x => x.PermissionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "UpdateDB",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    RoleName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RolesPkey", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "UpdateDB",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    FirstName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedBy = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    RoleId = table.Column<int>(type: "integer", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UsersPkey", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "UpdateDB",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    StockQuantity = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ProductsPkey", x => x.ProductId);
                    table.ForeignKey(
                        name: "ProductsCategoryIdFkey",
                        column: x => x.CategoryId,
                        principalSchema: "UpdateDB",
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "RolePermissions",
                schema: "UpdateDB",
                columns: table => new
                {
                    RolePermissionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    PermissionId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("RolePermissionsPkey", x => x.RolePermissionId);
                    table.ForeignKey(
                        name: "RolePermissionsPermissionIdFkey",
                        column: x => x.PermissionId,
                        principalSchema: "UpdateDB",
                        principalTable: "Permissions",
                        principalColumn: "PermissionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "RolePermissionsRoleIdFkey",
                        column: x => x.RoleId,
                        principalSchema: "UpdateDB",
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "UpdateDB",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    Street = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    City = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    State = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    PostalCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Country = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    AdressType = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("AddressesPkey", x => x.AddressId);
                    table.ForeignKey(
                        name: "AddressesUserIdFkey",
                        column: x => x.UserId,
                        principalSchema: "UpdateDB",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LogHistory",
                schema: "UpdateDB",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LastLoggedTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("LogHistoryPkey", x => x.LogId);
                    table.ForeignKey(
                        name: "LogHistoryUserIdFkey",
                        column: x => x.UserId,
                        principalSchema: "UpdateDB",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "UpdateDB",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("UserRolesPkey", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "UserRolesRoleIdFkey",
                        column: x => x.RoleId,
                        principalSchema: "UpdateDB",
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "UserRolesUserIdFkey",
                        column: x => x.UserId,
                        principalSchema: "UpdateDB",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductReviews",
                schema: "UpdateDB",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    ReviewText = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("ProductReviewsPkey", x => x.ReviewId);
                    table.ForeignKey(
                        name: "ProductReviewsProductIdFkey",
                        column: x => x.ProductId,
                        principalSchema: "UpdateDB",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "ProductReviewsUserIdFkey",
                        column: x => x.UserId,
                        principalSchema: "UpdateDB",
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                schema: "UpdateDB",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Status = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true, defaultValueSql: "'pending'::character varying"),
                    TotalAmount = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    OrderAddress = table.Column<int>(type: "integer", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OrdersPkey", x => x.OrderId);
                    table.ForeignKey(
                        name: "OrdersOrderAddressFkey",
                        column: x => x.OrderAddress,
                        principalSchema: "UpdateDB",
                        principalTable: "Addresses",
                        principalColumn: "AddressId");
                    table.ForeignKey(
                        name: "OrdersUserIdFkey",
                        column: x => x.UserId,
                        principalSchema: "UpdateDB",
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                schema: "UpdateDB",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    ProductId = table.Column<int>(type: "integer", nullable: true),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("OrderItemsPkey", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "OrderItemsOrderIdFkey",
                        column: x => x.OrderId,
                        principalSchema: "UpdateDB",
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "OrderItemsProductIdFkey",
                        column: x => x.ProductId,
                        principalSchema: "UpdateDB",
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                schema: "UpdateDB",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<int>(type: "integer", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true, defaultValueSql: "CURRENT_TIMESTAMP"),
                    Amount = table.Column<decimal>(type: "numeric(10,2)", precision: 10, scale: 2, nullable: false),
                    PaymentStatus = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    PaymentMethodId = table.Column<int>(type: "integer", nullable: true),
                    CreatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedUser = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PaymentsPkey", x => x.PaymentId);
                    table.ForeignKey(
                        name: "PaymentMethod",
                        column: x => x.PaymentMethodId,
                        principalSchema: "UpdateDB",
                        principalTable: "PaymentMethods",
                        principalColumn: "PaymentMethodId");
                    table.ForeignKey(
                        name: "PaymentsOrderIdFkey",
                        column: x => x.OrderId,
                        principalSchema: "UpdateDB",
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                schema: "UpdateDB",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "CategoriesNameKey",
                schema: "UpdateDB",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LogHistory_UserId",
                schema: "UpdateDB",
                table: "LogHistory",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                schema: "UpdateDB",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                schema: "UpdateDB",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderAddress",
                schema: "UpdateDB",
                table: "Orders",
                column: "OrderAddress");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                schema: "UpdateDB",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "PaymentMethodsMethodNameKey",
                schema: "UpdateDB",
                table: "PaymentMethods",
                column: "MethodName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                schema: "UpdateDB",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                schema: "UpdateDB",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "PermissionsPermissionNameKey",
                schema: "UpdateDB",
                table: "Permissions",
                column: "PermissionName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_ProductId",
                schema: "UpdateDB",
                table: "ProductReviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductReviews_UserId",
                schema: "UpdateDB",
                table: "ProductReviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "UpdateDB",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermissions_PermissionId",
                schema: "UpdateDB",
                table: "RolePermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "RolePermissionsRoleIdPermissionIdKey",
                schema: "UpdateDB",
                table: "RolePermissions",
                columns: new[] { "RoleId", "PermissionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "RolesRoleNameKey",
                schema: "UpdateDB",
                table: "Roles",
                column: "RoleName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "UpdateDB",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "UserRolesUserIdRoleIdKey",
                schema: "UpdateDB",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UsersEmailKey",
                schema: "UpdateDB",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UsersUsernameKey",
                schema: "UpdateDB",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogHistory",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "OrderItems",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Payments",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "ProductReviews",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "RolePermissions",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "PaymentMethods",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Orders",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Permissions",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "UpdateDB");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "AddressesAddressIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "CategoriesCategoryIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "OrderItemsOrderItemIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "OrdersOrderIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "PaymentMethodsPaymentMethodIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "PaymentsPaymentIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "PermissionsPermissionIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "ProductReviewsReviewIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "ProductsProductIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "RolePermissionsRolePermissionIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "UserRolesUserRoleIdSeq",
                schema: "UpdateDB");

            migrationBuilder.DropSequence(
                name: "UsersUserIdSeq",
                schema: "UpdateDB");
        }
    }
}
