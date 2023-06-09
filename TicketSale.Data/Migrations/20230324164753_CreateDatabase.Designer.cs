﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketSale.Data.Context;

#nullable disable

namespace TicketSale.Data.Migrations
{
    [DbContext(typeof(TicketContext))]
    [Migration("20230324164753_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TicketSale.Domain.Entities.ArtistEntity.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ArtistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Artirts");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ArtistHasEventEntity.ArtistHasEvent", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.HasKey("EventId", "ArtistId");

                    b.HasIndex("ArtistId");

                    b.ToTable("ArtistHasEvent");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ArtistHasGenreEntity.ArtistHasGenre", b =>
                {
                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.HasKey("GenreId", "ArtistId");

                    b.HasIndex("ArtistId");

                    b.ToTable("ArtistHasGenre");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.CategoryEntity.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("TypeGenre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.CityEntity.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ClientEntity.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdressInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.EventEntity.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AgeRestriction")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FinalDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InitialDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.GenreHasEventEntity.GenreHasEvent", b =>
                {
                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("GenreId")
                        .HasColumnType("int");

                    b.HasKey("EventId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("GenreHasEvent");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.PaymentStatusEntity.PaymentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentStatuses");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.StateEntity.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AcronymState")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("States");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.TicketEntity.Ticket", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("TicketRegistrationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatusId")
                        .HasColumnType("int");

                    b.HasKey("ClientId", "TicketRegistrationId");

                    b.HasIndex("PaymentStatusId");

                    b.HasIndex("TicketRegistrationId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.TicketRegistrationEntity.TicketRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<int>("TicketQuantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("TicketRegistrations");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.UserEntity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ArtistHasEventEntity.ArtistHasEvent", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.ArtistEntity.Artist", "Artist")
                        .WithMany("Events")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSale.Domain.Entities.EventEntity.Event", "Event")
                        .WithMany("Artirts")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ArtistHasGenreEntity.ArtistHasGenre", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.ArtistEntity.Artist", "Artist")
                        .WithMany("Genres")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSale.Domain.Entities.CategoryEntity.Genre", "Genre")
                        .WithMany("Artirts")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.CityEntity.City", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.StateEntity.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ClientEntity.Client", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.CityEntity.City", "City")
                        .WithMany("Clients")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSale.Domain.Entities.UserEntity.User", "User")
                        .WithOne("Client")
                        .HasForeignKey("TicketSale.Domain.Entities.ClientEntity.Client", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("TicketSale.Domain.VO.PersonInfo", "PersonInfo", b1 =>
                        {
                            b1.Property<int>("ClientId")
                                .HasColumnType("int");

                            b1.Property<DateTime>("Birthday")
                                .HasColumnType("datetime2");

                            b1.Property<string>("CPF")
                                .IsRequired()
                                .HasMaxLength(14)
                                .HasColumnType("nvarchar(14)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<string>("Surname")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("ClientId");

                            b1.ToTable("Clients");

                            b1.WithOwner()
                                .HasForeignKey("ClientId");
                        });

                    b.Navigation("City");

                    b.Navigation("PersonInfo")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.EventEntity.Event", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.CityEntity.City", "City")
                        .WithMany("Events")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.GenreHasEventEntity.GenreHasEvent", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.EventEntity.Event", "Event")
                        .WithMany("Genres")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSale.Domain.Entities.CategoryEntity.Genre", "Genre")
                        .WithMany("Events")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.TicketEntity.Ticket", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.ClientEntity.Client", "Client")
                        .WithMany("Tickets")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketSale.Domain.Entities.PaymentStatusEntity.PaymentStatus", "PaymentStatus")
                        .WithMany("Tickets")
                        .HasForeignKey("PaymentStatusId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TicketSale.Domain.Entities.TicketRegistrationEntity.TicketRegistration", "TicketRegistration")
                        .WithMany("Tickets")
                        .HasForeignKey("TicketRegistrationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("PaymentStatus");

                    b.Navigation("TicketRegistration");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.TicketRegistrationEntity.TicketRegistration", b =>
                {
                    b.HasOne("TicketSale.Domain.Entities.EventEntity.Event", "Event")
                        .WithMany("TicketsRegistrations")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ArtistEntity.Artist", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Genres");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.CategoryEntity.Genre", b =>
                {
                    b.Navigation("Artirts");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.CityEntity.City", b =>
                {
                    b.Navigation("Clients");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.ClientEntity.Client", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.EventEntity.Event", b =>
                {
                    b.Navigation("Artirts");

                    b.Navigation("Genres");

                    b.Navigation("TicketsRegistrations");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.PaymentStatusEntity.PaymentStatus", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.StateEntity.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.TicketRegistrationEntity.TicketRegistration", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("TicketSale.Domain.Entities.UserEntity.User", b =>
                {
                    b.Navigation("Client")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
