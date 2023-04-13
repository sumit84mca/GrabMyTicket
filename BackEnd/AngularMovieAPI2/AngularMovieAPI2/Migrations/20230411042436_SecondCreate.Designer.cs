﻿// <auto-generated />
using System;
using AngularMovieAPI2.Environment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AngularMovieAPI2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230411042436_SecondCreate")]
    partial class SecondCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AngularMovieAPI2.Models.Bookings.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("ShowID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("ShowID");

                    b.HasIndex("UserID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Bookings.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentID"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal");

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("DiscountCuponID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime");

                    b.HasKey("PaymentID");

                    b.HasIndex("BookingID")
                        .IsUnique();

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.Cinema", b =>
                {
                    b.Property<int>("CinemaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaID"));

                    b.Property<int>("CinemaAddressID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("TotalCinemaHalls")
                        .HasColumnType("int");

                    b.HasKey("CinemaID");

                    b.HasIndex("CinemaAddressID")
                        .IsUnique();

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.CinemaAddress", b =>
                {
                    b.Property<int>("CinemaAdressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaAdressID"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("CinemaAdressID");

                    b.ToTable("CinemaAddresses");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.CinemaHall", b =>
                {
                    b.Property<int>("CinemaHallID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaHallID"));

                    b.Property<int>("CinemaID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("CinemaHallID");

                    b.HasIndex("CinemaID");

                    b.ToTable("CinemaHalls");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.CinemaSeat", b =>
                {
                    b.Property<int>("CinemaSeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaSeatID"));

                    b.Property<int>("CinemaHallID")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("CinemaSeatID");

                    b.HasIndex("CinemaHallID");

                    b.ToTable("CinemaSeats");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Movie.Genre", b =>
                {
                    b.Property<int>("GenreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GenreID"));

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.HasKey("GenreID");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Movie.GenreMovie", b =>
                {
                    b.Property<int>("GenresGenreID")
                        .HasColumnType("int");

                    b.Property<int>("MoviesMovieID")
                        .HasColumnType("int");

                    b.HasKey("GenresGenreID", "MoviesMovieID");

                    b.HasIndex("MoviesMovieID");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Movie.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"));

                    b.Property<string>("Censorship")
                        .IsRequired()
                        .HasColumnType("nvarchar(36)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("ImgLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TrailerLink")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Show.Show", b =>
                {
                    b.Property<int?>("ShowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ShowID"));

                    b.Property<int>("CinemaHallID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime");

                    b.HasKey("ShowID");

                    b.HasIndex("CinemaHallID")
                        .IsUnique();

                    b.HasIndex("MovieID");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Show.ShowSeat", b =>
                {
                    b.Property<int?>("ShowSeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("ShowSeatID"));

                    b.Property<int?>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("CinemaSeatID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.Property<int?>("ShowID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ShowSeatID");

                    b.HasIndex("BookingID");

                    b.HasIndex("CinemaSeatID");

                    b.HasIndex("ShowID");

                    b.ToTable("ShowSeats");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Snacks.OrderSnack", b =>
                {
                    b.Property<int>("SnackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SnackID"));

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("SnackID");

                    b.HasIndex("BookingID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderSnacks");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Snacks.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(512)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal");

                    b.HasKey("ProductID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.User.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(76)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Bookings.Booking", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Show.Show", "Show")
                        .WithMany("Booking")
                        .HasForeignKey("ShowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularMovieAPI2.Models.User.User", "user")
                        .WithMany("Bookings")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Show");

                    b.Navigation("user");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Bookings.Payment", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Bookings.Booking", "Booking")
                        .WithOne("Payment")
                        .HasForeignKey("AngularMovieAPI2.Models.Bookings.Payment", "BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.Cinema", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Cinema.CinemaAddress", "CinemaAddresses")
                        .WithOne("Cinema")
                        .HasForeignKey("AngularMovieAPI2.Models.Cinema.Cinema", "CinemaAddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaAddresses");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.CinemaHall", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Cinema.Cinema", "Cinema")
                        .WithMany("CinemaHalls")
                        .HasForeignKey("CinemaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.CinemaSeat", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Cinema.CinemaHall", "CinemaHall")
                        .WithMany("CinemaSeats")
                        .HasForeignKey("CinemaHallID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHall");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Movie.GenreMovie", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Movie.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenresGenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularMovieAPI2.Models.Movie.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MoviesMovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Show.Show", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Cinema.CinemaHall", "CinemaHall")
                        .WithOne("Show")
                        .HasForeignKey("AngularMovieAPI2.Models.Show.Show", "CinemaHallID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularMovieAPI2.Models.Movie.Movie", "Movie")
                        .WithMany("Shows")
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHall");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Show.ShowSeat", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Bookings.Booking", "Booking")
                        .WithMany("ShowSeats")
                        .HasForeignKey("BookingID");

                    b.HasOne("AngularMovieAPI2.Models.Cinema.CinemaSeat", "CinemaSeat")
                        .WithMany()
                        .HasForeignKey("CinemaSeatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularMovieAPI2.Models.Show.Show", "Show")
                        .WithMany("ShowSeats")
                        .HasForeignKey("ShowID");

                    b.Navigation("Booking");

                    b.Navigation("CinemaSeat");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Snacks.OrderSnack", b =>
                {
                    b.HasOne("AngularMovieAPI2.Models.Bookings.Booking", "Booking")
                        .WithMany("OrderSnacks")
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AngularMovieAPI2.Models.Snacks.Product", "Product")
                        .WithMany("OrderSnacks")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Bookings.Booking", b =>
                {
                    b.Navigation("OrderSnacks");

                    b.Navigation("Payment")
                        .IsRequired();

                    b.Navigation("ShowSeats");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.Cinema", b =>
                {
                    b.Navigation("CinemaHalls");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.CinemaAddress", b =>
                {
                    b.Navigation("Cinema")
                        .IsRequired();
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Cinema.CinemaHall", b =>
                {
                    b.Navigation("CinemaSeats");

                    b.Navigation("Show")
                        .IsRequired();
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Movie.Movie", b =>
                {
                    b.Navigation("Shows");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Show.Show", b =>
                {
                    b.Navigation("Booking");

                    b.Navigation("ShowSeats");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.Snacks.Product", b =>
                {
                    b.Navigation("OrderSnacks");
                });

            modelBuilder.Entity("AngularMovieAPI2.Models.User.User", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
