﻿// <auto-generated />
using FAQapp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FAQapp.Migrations
{
    [DbContext(typeof(FAQContext))]
    [Migration("20211006193704_ContentUpdate")]
    partial class ContentUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FAQapp.Models.Category", b =>
                {
                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = "hist",
                            Name = "History"
                        },
                        new
                        {
                            CategoryId = "gen",
                            Name = "General"
                        },
                        new
                        {
                            CategoryId = "link",
                            Name = "Websites"
                        });
                });

            modelBuilder.Entity("FAQapp.Models.FAQ", b =>
                {
                    b.Property<int>("FAQId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BandWebsite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearFormed")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FAQId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("GenreId");

                    b.ToTable("FAQs");

                    b.HasData(
                        new
                        {
                            FAQId = 1,
                            CategoryId = "hist",
                            GenreId = "sym-metal",
                            Name = "Nightwish",
                            YearFormed = "1996"
                        },
                        new
                        {
                            FAQId = 2,
                            CategoryId = "gen",
                            Description = "Finland's Nightwish are an award-winning, best-selling symphonic metal band fronted by Floor Jansen, their third female vocalist.",
                            GenreId = "sym-metal",
                            Name = "Nightwish"
                        },
                        new
                        {
                            FAQId = 3,
                            BandWebsite = "https://www.nightwish.com/",
                            CategoryId = "link",
                            GenreId = "sym-metal",
                            Name = "Nightwish",
                            SecondLink = "https://open.spotify.com/artist/2NPduAUeLVsfIauhRwuft1"
                        },
                        new
                        {
                            FAQId = 4,
                            CategoryId = "hist",
                            GenreId = "spd-metal",
                            Name = "DragonForce",
                            YearFormed = "1999"
                        },
                        new
                        {
                            FAQId = 5,
                            CategoryId = "gen",
                            Description = "Known as the fastest band in the world, Grammy-nominated extreme power metal band DragonForce is based in London, England.",
                            GenreId = "spd-metal",
                            Name = "DragonForce"
                        },
                        new
                        {
                            FAQId = 6,
                            BandWebsite = "https://dragonforce.com/",
                            CategoryId = "link",
                            GenreId = "spd-metal",
                            Name = "DragonForce",
                            SecondLink = "https://open.spotify.com/artist/2pH3wEn4eYlMMIIQyKPbVR"
                        },
                        new
                        {
                            FAQId = 7,
                            CategoryId = "hist",
                            GenreId = "pow-metal",
                            Name = "Battle Beast",
                            YearFormed = "2005"
                        },
                        new
                        {
                            FAQId = 8,
                            CategoryId = "gen",
                            Description = "Famous for their energetic shows, incredibly catchy choruses and odd sense of humour, Finland’s Battle Beast are destined for glory.",
                            GenreId = "pow-metal",
                            Name = "Battle Beast"
                        },
                        new
                        {
                            FAQId = 9,
                            BandWebsite = "https://battlebeast.fi/",
                            CategoryId = "link",
                            GenreId = "pow-metal",
                            Name = "Battle Beast",
                            SecondLink = "https://open.spotify.com/artist/7k5jeohQCF20a8foBD9ize"
                        });
                });

            modelBuilder.Entity("FAQapp.Models.Genre", b =>
                {
                    b.Property<string>("GenreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = "sym-metal",
                            Name = "Symphonic Metal"
                        },
                        new
                        {
                            GenreId = "spd-metal",
                            Name = "Speed Metal"
                        },
                        new
                        {
                            GenreId = "pow-metal",
                            Name = "Power Metal"
                        });
                });

            modelBuilder.Entity("FAQapp.Models.FAQ", b =>
                {
                    b.HasOne("FAQapp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("FAQapp.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId");
                });
#pragma warning restore 612, 618
        }
    }
}
