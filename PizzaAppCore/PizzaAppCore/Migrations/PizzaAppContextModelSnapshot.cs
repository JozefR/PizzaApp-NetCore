﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PizzaAppCore.Models;
using PizzaAppCore.Models.Enums;
using System;

namespace PizzaAppCore.Migrations
{
    [DbContext(typeof(PizzaAppContext))]
    partial class PizzaAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PizzaAppCore.Models.CustomerModel", b =>
                {
                    b.Property<int>("ID");

                    b.Property<string>("Address");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("PizzaAppCore.Models.ExtraIngredientsModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Bacon");

                    b.Property<bool>("Chcees");

                    b.Property<bool>("Onions");

                    b.Property<bool>("Pepperoni");

                    b.Property<bool>("Sausage");

                    b.HasKey("ID");

                    b.ToTable("ExtraIngredients");
                });

            modelBuilder.Entity("PizzaAppCore.Models.OrderModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerModelID");

                    b.Property<string>("Note");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("OrderStatusEnum");

                    b.Property<int>("PaymentEnum");

                    b.Property<byte>("TotalCost");

                    b.HasKey("ID");

                    b.HasIndex("CustomerModelID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PizzaAppCore.Models.PizzaModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CrustEnum");

                    b.Property<int>("ExtraIngredientsModelID");

                    b.Property<int>("OrderModelID");

                    b.Property<int>("PizaNameEnum");

                    b.Property<int>("SizeEnum");

                    b.HasKey("ID");

                    b.HasIndex("ExtraIngredientsModelID");

                    b.HasIndex("OrderModelID");

                    b.ToTable("Pizza");
                });

            modelBuilder.Entity("PizzaAppCore.Models.OrderModel", b =>
                {
                    b.HasOne("PizzaAppCore.Models.CustomerModel", "CustomerModel")
                        .WithMany("OrdersModel")
                        .HasForeignKey("CustomerModelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PizzaAppCore.Models.PizzaModel", b =>
                {
                    b.HasOne("PizzaAppCore.Models.ExtraIngredientsModel", "ExtraIngredientsModel")
                        .WithMany()
                        .HasForeignKey("ExtraIngredientsModelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PizzaAppCore.Models.OrderModel", "OrderModel")
                        .WithMany("PizzasModel")
                        .HasForeignKey("OrderModelID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
