﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ModuleHW.DataAccess;

namespace ModuleHW.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ArtistId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("DateOfBirth");

                    b.Property<DateTime?>("DateOfDeath")
                        .HasColumnType("date")
                        .HasColumnName("DateOfDeath");

                    b.Property<string>("Email")
                        .HasMaxLength(320)
                        .HasColumnType("nvarchar(320)")
                        .HasColumnName("Email");

                    b.Property<string>("InstagramUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("InstagramUrl");

                    b.Property<bool?>("IsAlived")
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("bit")
                        .HasColumnName("IsAlived")
                        .HasComputedColumnSql("cast (case when DateOfDeath is null then (1) else (0) end as bit)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("Phone");

                    b.HasKey("Id");

                    b.ToTable("Artist");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfDeath = new DateTime(1983, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artist1@ma.il",
                            InstagramUrl = "https://www.instagram.com/artist1",
                            Name = "Artist 1",
                            Phone = "380601234567"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1981, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artist2@ma.il",
                            InstagramUrl = "https://www.instagram.com/artist2",
                            Name = "Artist 2",
                            Phone = "380607654321"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1982, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artist3@ma.il",
                            InstagramUrl = "https://www.instagram.com/artist3",
                            Name = "Artist 3",
                            Phone = "380601726345"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1983, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artist4@ma.il",
                            InstagramUrl = "https://www.instagram.com/artist4",
                            Name = "Artist 4",
                            Phone = "380601122334"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(1984, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artist5@ma.il",
                            InstagramUrl = "https://www.instagram.com/artist5",
                            Name = "Artist 5",
                            Phone = "380604556677"
                        },
                        new
                        {
                            Id = 6,
                            DateOfBirth = new DateTime(1985, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artist6@ma.il",
                            InstagramUrl = "https://www.instagram.com/artist6",
                            Name = "Artist 6",
                            Phone = "380609876543"
                        },
                        new
                        {
                            Id = 7,
                            DateOfBirth = new DateTime(1986, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artist7@ma.il",
                            InstagramUrl = "https://www.instagram.com/artist7",
                            Name = "Artist 7",
                            Phone = "380603456789"
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.ArtistSong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ArtistSongId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 1,
                            SongId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 2,
                            SongId = 2
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            SongId = 3
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 4,
                            SongId = 4
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 5,
                            SongId = 5
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 6,
                            SongId = 6
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 7,
                            SongId = 7
                        },
                        new
                        {
                            Id = 8,
                            ArtistId = 2,
                            SongId = 1
                        },
                        new
                        {
                            Id = 9,
                            ArtistId = 3,
                            SongId = 1
                        },
                        new
                        {
                            Id = 10,
                            ArtistId = 3,
                            SongId = 2
                        },
                        new
                        {
                            Id = 11,
                            ArtistId = 4,
                            SongId = 1
                        },
                        new
                        {
                            Id = 12,
                            ArtistId = 4,
                            SongId = 2
                        },
                        new
                        {
                            Id = 13,
                            ArtistId = 4,
                            SongId = 3
                        },
                        new
                        {
                            Id = 14,
                            ArtistId = 4,
                            SongId = 5
                        },
                        new
                        {
                            Id = 15,
                            ArtistId = 5,
                            SongId = 8
                        },
                        new
                        {
                            Id = 16,
                            ArtistId = 2,
                            SongId = 9
                        },
                        new
                        {
                            Id = 17,
                            ArtistId = 3,
                            SongId = 10
                        },
                        new
                        {
                            Id = 18,
                            ArtistId = 4,
                            SongId = 11
                        },
                        new
                        {
                            Id = 19,
                            ArtistId = 5,
                            SongId = 12
                        },
                        new
                        {
                            Id = 20,
                            ArtistId = 6,
                            SongId = 13
                        },
                        new
                        {
                            Id = 21,
                            ArtistId = 7,
                            SongId = 14
                        },
                        new
                        {
                            Id = 22,
                            ArtistId = 1,
                            SongId = 15
                        },
                        new
                        {
                            Id = 23,
                            ArtistId = 2,
                            SongId = 10
                        },
                        new
                        {
                            Id = 24,
                            ArtistId = 3,
                            SongId = 11
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GenreId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Genre");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Genre 1"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Genre 2"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Genre 3"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Genre 4"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Genre 5"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Genre 6"
                        },
                        new
                        {
                            Id = 7,
                            Title = "Genre 7"
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SongId")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int")
                        .HasColumnName("Duration");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("date")
                        .HasColumnName("ReleasedDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Song");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 100,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 1"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 200,
                            GenreId = 2,
                            ReleasedDate = new DateTime(1991, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 2"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 300,
                            ReleasedDate = new DateTime(1992, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 3"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 400,
                            GenreId = 4,
                            ReleasedDate = new DateTime(1993, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 4"
                        },
                        new
                        {
                            Id = 5,
                            Duration = 500,
                            GenreId = 5,
                            ReleasedDate = new DateTime(1994, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 5"
                        },
                        new
                        {
                            Id = 6,
                            Duration = 600,
                            GenreId = 6,
                            ReleasedDate = new DateTime(1995, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 6"
                        },
                        new
                        {
                            Id = 7,
                            Duration = 700,
                            ReleasedDate = new DateTime(1996, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 7"
                        },
                        new
                        {
                            Id = 8,
                            Duration = 800,
                            GenreId = 6,
                            ReleasedDate = new DateTime(1976, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 8"
                        },
                        new
                        {
                            Id = 9,
                            Duration = 900,
                            GenreId = 5,
                            ReleasedDate = new DateTime(1977, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 9"
                        },
                        new
                        {
                            Id = 10,
                            Duration = 1000,
                            GenreId = 4,
                            ReleasedDate = new DateTime(1978, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 10"
                        },
                        new
                        {
                            Id = 11,
                            Duration = 1100,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 11"
                        },
                        new
                        {
                            Id = 12,
                            Duration = 1200,
                            GenreId = 2,
                            ReleasedDate = new DateTime(1980, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 12"
                        },
                        new
                        {
                            Id = 13,
                            Duration = 1300,
                            GenreId = 1,
                            ReleasedDate = new DateTime(1981, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 13"
                        },
                        new
                        {
                            Id = 14,
                            Duration = 1400,
                            ReleasedDate = new DateTime(1982, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 14"
                        },
                        new
                        {
                            Id = 15,
                            Duration = 1500,
                            GenreId = 3,
                            ReleasedDate = new DateTime(1983, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Song 15"
                        });
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.ArtistSong", b =>
                {
                    b.HasOne("ModuleHW.DataAccess.Models.Artist", "Artist")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ModuleHW.DataAccess.Models.Song", "Song")
                        .WithMany("ArtistSongs")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Song", b =>
                {
                    b.HasOne("ModuleHW.DataAccess.Models.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Artist", b =>
                {
                    b.Navigation("ArtistSongs");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("ModuleHW.DataAccess.Models.Song", b =>
                {
                    b.Navigation("ArtistSongs");
                });
#pragma warning restore 612, 618
        }
    }
}