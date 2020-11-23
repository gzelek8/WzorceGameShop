﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WzorceGameShop.Data;

namespace WzorceGameShop.Migrations
{
    [DbContext(typeof(GameShopContext))]
    [Migration("20201123113554_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WzorceGameShop.Models.Basket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Baskets");
                });

            modelBuilder.Entity("WzorceGameShop.Models.BasketGame", b =>
                {
                    b.Property<int>("BasketId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.HasKey("BasketId", "GameId");

                    b.HasIndex("GameId");

                    b.ToTable("BasketsGames");
                });

            modelBuilder.Entity("WzorceGameShop.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<decimal>("SummaryPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("WzorceGameShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WzorceGameShop.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WzorceGameShop.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BasketId")
                        .HasColumnType("int");

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PG")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Promotion")
                        .HasColumnType("bit");

                    b.Property<int?>("StudioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BasketId");

                    b.HasIndex("BillId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ClientId");

                    b.HasIndex("StudioId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("WzorceGameShop.Models.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("WzorceGameShop.Models.BasketGame", b =>
                {
                    b.HasOne("WzorceGameShop.Models.Basket", "Basket")
                        .WithMany("BasketGames")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WzorceGameShop.Models.Game", "Game")
                        .WithMany("BasketGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WzorceGameShop.Models.Bill", b =>
                {
                    b.HasOne("WzorceGameShop.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("WzorceGameShop.Models.Game", b =>
                {
                    b.HasOne("WzorceGameShop.Models.Basket", null)
                        .WithMany("SelectedGames")
                        .HasForeignKey("BasketId");

                    b.HasOne("WzorceGameShop.Models.Bill", null)
                        .WithMany("Games")
                        .HasForeignKey("BillId");

                    b.HasOne("WzorceGameShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("WzorceGameShop.Models.Client", null)
                        .WithMany("Games")
                        .HasForeignKey("ClientId");

                    b.HasOne("WzorceGameShop.Models.Studio", "Studio")
                        .WithMany()
                        .HasForeignKey("StudioId");
                });
#pragma warning restore 612, 618
        }
    }
}
