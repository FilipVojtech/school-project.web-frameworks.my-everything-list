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
    [Migration("20241127153754_AllModels")]
    partial class AllModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.11");

            modelBuilder.Entity("My_Everything_List.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Authors")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("authors");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT")
                        .HasColumnName("image");

                    b.Property<string>("Isbn")
                        .HasColumnType("TEXT")
                        .HasColumnName("isbn");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("books");
                });

            modelBuilder.Entity("My_Everything_List.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("TEXT")
                        .HasColumnName("description");

                    b.Property<string>("Genres")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("genres");

                    b.Property<string>("Image")
                        .HasMaxLength(32)
                        .HasColumnType("TEXT")
                        .HasColumnName("image");

                    b.Property<DateOnly>("ReleaseDate")
                        .HasColumnType("TEXT")
                        .HasColumnName("release_date");

                    b.Property<string>("Title")
                        .HasMaxLength(64)
                        .HasColumnType("TEXT")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.ToTable("film");
                });

            modelBuilder.Entity("My_Everything_List.Models.MusicItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT")
                        .HasColumnName("image");

                    b.Property<int>("ItemType")
                        .HasColumnType("INTEGER")
                        .HasColumnName("item_type");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("music_items");

                    b.HasDiscriminator().HasValue("MusicItem");

                    b.UseTphMappingStrategy();
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

            modelBuilder.Entity("My_Everything_List.Models.Album", b =>
                {
                    b.HasBaseType("My_Everything_List.Models.MusicItem");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT")
                        .HasColumnName("artist");

                    b.ToTable("music_items");

                    b.HasDiscriminator().HasValue("Album");
                });

            modelBuilder.Entity("My_Everything_List.Models.Artist", b =>
                {
                    b.HasBaseType("My_Everything_List.Models.MusicItem");

                    b.ToTable("music_items");

                    b.HasDiscriminator().HasValue("Artist");
                });

            modelBuilder.Entity("My_Everything_List.Models.Song", b =>
                {
                    b.HasBaseType("My_Everything_List.Models.MusicItem");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("TEXT")
                        .HasColumnName("artist");

                    b.ToTable("music_items");

                    b.HasDiscriminator().HasValue("Song");
                });
#pragma warning restore 612, 618
        }
    }
}
