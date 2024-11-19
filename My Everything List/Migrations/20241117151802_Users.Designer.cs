﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using My_Everything_List.Data;

#nullable disable

namespace MyEverythingList.Migrations
{
    [DbContext(typeof(MyEverythingListContext))]
    [Migration("20241117151802_Users")]
    partial class Users
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("My_Everything_List.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT")
                        .HasColumnName("genre");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)")
                        .HasColumnName("price");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("release_date");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("film");
                });

            modelBuilder.Entity("My_Everything_List.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT")
                        .HasColumnName("email");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT")
                        .HasColumnName("password");

                    b.Property<string>("Role")
                        .HasColumnType("TEXT")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}