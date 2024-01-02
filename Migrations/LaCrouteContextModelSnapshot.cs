﻿// <auto-generated />
using System;
using LaCroute.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LaCroute.Migrations
{
    [DbContext(typeof(LaCrouteContext))]
    partial class LaCrouteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("LaCroute.Models.EventModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("thumbnail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Event");
                });

            modelBuilder.Entity("LaCroute.Models.LabelModel", b =>
            modelBuilder.Entity("LaCroute.Models.ReviewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

<<<<<<< HEAD
                    b.Property<DateTime>("Created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("Svg")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Label");
                });

            modelBuilder.Entity("LaCroute.Models.ProductLabelModel", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LabelId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductId", "LabelId");

                    b.HasIndex("LabelId");

                    b.ToTable("ProductLabel");
                });

            modelBuilder.Entity("LaCroute.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Thumbnail")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TypeId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Updated_at")
=======
                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("updated_at")
>>>>>>> 576991603de965e97043dc67d6e6839e902563fe
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

<<<<<<< HEAD
                    b.HasIndex("TypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("LaCroute.Models.TypeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Updated_at")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("LaCroute.Models.ProductLabelModel", b =>
                {
                    b.HasOne("LaCroute.Models.LabelModel", "Label")
                        .WithMany("ProductLabel")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LaCroute.Models.ProductModel", "Product")
                        .WithMany("ProductLabel")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Label");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LaCroute.Models.ProductModel", b =>
                {
                    b.HasOne("LaCroute.Models.TypeModel", "Type")
                        .WithMany("Products")
                        .HasForeignKey("TypeId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("LaCroute.Models.LabelModel", b =>
                {
                    b.Navigation("ProductLabel");
                });

            modelBuilder.Entity("LaCroute.Models.ProductModel", b =>
                {
                    b.Navigation("ProductLabel");
                });

            modelBuilder.Entity("LaCroute.Models.TypeModel", b =>
                {
                    b.Navigation("Products");
=======
                    b.ToTable("Review");
>>>>>>> 576991603de965e97043dc67d6e6839e902563fe
                });
#pragma warning restore 612, 618
        }
    }
}
