﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using My_Everything_List.Data;

#nullable disable

namespace MyEverythingList.Migrations
{
    [DbContext(typeof(MyEverythingListContext))]
    partial class MyEverythingListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("GoogleBooksId")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("google_books_id");

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

                    b.Property<int>("TmdbId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("tmdb_id");

                    b.HasKey("Id");

                    b.ToTable("film");
                });

            modelBuilder.Entity("My_Everything_List.Models.MusicItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT")
                        .HasColumnName("image");

                    b.Property<int>("ItemType")
                        .HasColumnType("INTEGER")
                        .HasColumnName("item_type");

                    b.Property<Guid>("Mbid")
                        .HasColumnType("TEXT")
                        .HasColumnName("mbid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("music_items");

                    b.HasDiscriminator<int>("ItemType");

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
                        .HasMaxLength(5)
                        .HasColumnType("TEXT")
                        .HasColumnName("role");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("My_Everything_List.Models.UsersBooks", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("book_id");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER")
                        .HasColumnName("rating");

                    b.HasKey("BookId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("users_books");
                });

            modelBuilder.Entity("My_Everything_List.Models.UsersFilms", b =>
                {
                    b.Property<int>("FilmId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("film_id");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER")
                        .HasColumnName("rating");

                    b.HasKey("FilmId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("users_films");
                });

            modelBuilder.Entity("My_Everything_List.Models.UsersMusic", b =>
                {
                    b.Property<int>("MusicItemId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("music_id");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("user_id");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER")
                        .HasColumnName("rating");

                    b.HasKey("MusicItemId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("users_music");
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

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("My_Everything_List.Models.Artist", b =>
                {
                    b.HasBaseType("My_Everything_List.Models.MusicItem");

                    b.ToTable("music_items");

                    b.HasDiscriminator().HasValue(0);
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

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("My_Everything_List.Models.UsersBooks", b =>
                {
                    b.HasOne("My_Everything_List.Models.Book", "Book")
                        .WithMany("UsersBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("My_Everything_List.Models.User", "User")
                        .WithMany("UsersBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("My_Everything_List.Models.UsersFilms", b =>
                {
                    b.HasOne("My_Everything_List.Models.Film", "Film")
                        .WithMany("UsersFilms")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("My_Everything_List.Models.User", "User")
                        .WithMany("UsersFilms")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");

                    b.Navigation("User");
                });

            modelBuilder.Entity("My_Everything_List.Models.UsersMusic", b =>
                {
                    b.HasOne("My_Everything_List.Models.MusicItem", "MusicItem")
                        .WithMany("UsersMusic")
                        .HasForeignKey("MusicItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("My_Everything_List.Models.User", "User")
                        .WithMany("UsersMusic")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MusicItem");

                    b.Navigation("User");
                });

            modelBuilder.Entity("My_Everything_List.Models.Book", b =>
                {
                    b.Navigation("UsersBooks");
                });

            modelBuilder.Entity("My_Everything_List.Models.Film", b =>
                {
                    b.Navigation("UsersFilms");
                });

            modelBuilder.Entity("My_Everything_List.Models.MusicItem", b =>
                {
                    b.Navigation("UsersMusic");
                });

            modelBuilder.Entity("My_Everything_List.Models.User", b =>
                {
                    b.Navigation("UsersBooks");

                    b.Navigation("UsersFilms");

                    b.Navigation("UsersMusic");
                });
#pragma warning restore 612, 618
        }
    }
}
