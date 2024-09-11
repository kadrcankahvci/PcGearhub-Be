﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PcGearHub.Data.DBModels;

#nullable disable

namespace PcGearHub.Data.Migrations
{
    [DbContext(typeof(DemodbContext))]
    [Migration("20240911113141_Added_Image_Column_to_Product")]
    partial class Added_Image_Column_to_Product
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.HasSequence("AddressesAddressIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("CategoriesCategoryIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("OrderItemsOrderItemIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("OrdersOrderIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("PaymentMethodsPaymentMethodIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("PaymentsPaymentIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("PermissionsPermissionIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("ProductReviewsReviewIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("ProductsProductIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("RolePermissionsRolePermissionIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("UserRolesUserRoleIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.HasSequence("UsersUserIdSeq", "UpdateDB")
                .HasMax(2147483647L);

            modelBuilder.Entity("PcGearHub.Data.DBModels.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AddressId"));

                    b.Property<string>("AdressType")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("PostalCode")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("State")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("AddressId")
                        .HasName("AddressesPkey");

                    b.HasIndex("UserId");

                    b.ToTable("Addresses", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("CategoryId")
                        .HasName("CategoriesPkey");

                    b.HasIndex(new[] { "Name" }, "CategoriesNameKey")
                        .IsUnique();

                    b.ToTable("Categories", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.LogHistory", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LogId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime>("LastLoggedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LogId")
                        .HasName("LogHistoryPkey");

                    b.HasIndex("UserId");

                    b.ToTable("LogHistory", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("OrderAddress")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasDefaultValueSql("'pending'::character varying");

                    b.Property<decimal>("TotalAmount")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("OrderId")
                        .HasName("OrdersPkey");

                    b.HasIndex("OrderAddress");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderItemId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("OrderItemId")
                        .HasName("OrderItemsPkey");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("PaymentDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<int?>("PaymentMethodId")
                        .HasColumnType("integer");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("PaymentId")
                        .HasName("PaymentsPkey");

                    b.HasIndex("OrderId");

                    b.HasIndex("PaymentMethodId");

                    b.ToTable("Payments", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PaymentMethodId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("MethodName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("PaymentMethodId")
                        .HasName("PaymentMethodsPkey");

                    b.HasIndex(new[] { "MethodName" }, "PaymentMethodsMethodNameKey")
                        .IsUnique();

                    b.ToTable("PaymentMethods", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PermissionId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("PermissionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("PermissionId")
                        .HasName("PermissionsPkey");

                    b.HasIndex(new[] { "PermissionName" }, "PermissionsPermissionNameKey")
                        .IsUnique();

                    b.ToTable("Permissions", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("ProductId")
                        .HasName("ProductsPkey");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.ProductReview", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ReviewId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ReviewId")
                        .HasName("ProductReviewsPkey");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductReviews", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("RoleId")
                        .HasName("RolesPkey");

                    b.HasIndex(new[] { "RoleName" }, "RolesRoleNameKey")
                        .IsUnique();

                    b.ToTable("Roles", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.RolePermission", b =>
                {
                    b.Property<int>("RolePermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RolePermissionId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("PermissionId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("RolePermissionId")
                        .HasName("RolePermissionsPkey");

                    b.HasIndex("PermissionId");

                    b.HasIndex(new[] { "RoleId", "PermissionId" }, "RolePermissionsRoleIdPermissionIdKey")
                        .IsUnique();

                    b.ToTable("RolePermissions", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("UserId")
                        .HasName("UsersPkey");

                    b.HasIndex(new[] { "Email" }, "UsersEmailKey")
                        .IsUnique();

                    b.HasIndex(new[] { "Username" }, "UsersUsernameKey")
                        .IsUnique();

                    b.ToTable("Users", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserRoleId"));

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<string>("CreatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UpdatedUser")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("UserRoleId")
                        .HasName("UserRolesPkey");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "UserId", "RoleId" }, "UserRolesUserIdRoleIdKey")
                        .IsUnique();

                    b.ToTable("UserRoles", "UpdateDB");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Address", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("AddressesUserIdFkey");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.LogHistory", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.User", "User")
                        .WithMany("LogHistories")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("LogHistoryUserIdFkey");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Order", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.Address", "OrderAddressNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("OrderAddress")
                        .HasConstraintName("OrdersOrderAddressFkey");

                    b.HasOne("PcGearHub.Data.DBModels.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("OrdersUserIdFkey");

                    b.Navigation("OrderAddressNavigation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.OrderItem", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("OrderItemsOrderIdFkey");

                    b.HasOne("PcGearHub.Data.DBModels.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("OrderItemsProductIdFkey");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Payment", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.Order", "Order")
                        .WithMany("Payments")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("PaymentsOrderIdFkey");

                    b.HasOne("PcGearHub.Data.DBModels.PaymentMethod", "PaymentMethod")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentMethodId")
                        .HasConstraintName("PaymentMethod");

                    b.Navigation("Order");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Product", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("ProductsCategoryIdFkey");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.ProductReview", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.Product", "Product")
                        .WithMany("ProductReviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("ProductReviewsProductIdFkey");

                    b.HasOne("PcGearHub.Data.DBModels.User", "User")
                        .WithMany("ProductReviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("ProductReviewsUserIdFkey");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.RolePermission", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.Permission", "Permission")
                        .WithMany("RolePermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("RolePermissionsPermissionIdFkey");

                    b.HasOne("PcGearHub.Data.DBModels.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("RolePermissionsRoleIdFkey");

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.UserRole", b =>
                {
                    b.HasOne("PcGearHub.Data.DBModels.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("UserRolesRoleIdFkey");

                    b.HasOne("PcGearHub.Data.DBModels.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("UserRolesUserIdFkey");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Order", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("Payments");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.PaymentMethod", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Permission", b =>
                {
                    b.Navigation("RolePermissions");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Product", b =>
                {
                    b.Navigation("OrderItems");

                    b.Navigation("ProductReviews");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("PcGearHub.Data.DBModels.User", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("LogHistories");

                    b.Navigation("Orders");

                    b.Navigation("ProductReviews");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
