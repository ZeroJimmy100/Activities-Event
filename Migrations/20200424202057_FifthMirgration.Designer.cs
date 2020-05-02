﻿// <auto-generated />
using System;
using ActivitiesEvent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ActivitiesEvent.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200424202057_FifthMirgration")]
    partial class FifthMirgration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ActivitiesEvent.Models.Associates", b =>
                {
                    b.Property<int>("AssociatesId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EventFormId");

                    b.Property<int>("UserId");

                    b.HasKey("AssociatesId");

                    b.HasIndex("EventFormId");

                    b.HasIndex("UserId");

                    b.ToTable("AssociatesGuest");
                });

            modelBuilder.Entity("ActivitiesEvent.Models.FormEvent", b =>
                {
                    b.Property<int>("EventFormId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Duration")
                        .IsRequired();

                    b.Property<int>("EventDuration");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("EventFormId");

                    b.HasIndex("UserId");

                    b.ToTable("EventForms");
                });

            modelBuilder.Entity("ActivitiesEvent.Models.Users", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConfirmPW");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("PassWord")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("UserId");

                    b.ToTable("TheUsers");
                });

            modelBuilder.Entity("ActivitiesEvent.Models.Associates", b =>
                {
                    b.HasOne("ActivitiesEvent.Models.FormEvent", "EventForms")
                        .WithMany("Attending")
                        .HasForeignKey("EventFormId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ActivitiesEvent.Models.Users", "User")
                        .WithMany("Attending")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ActivitiesEvent.Models.FormEvent", b =>
                {
                    b.HasOne("ActivitiesEvent.Models.Users", "ThePlanner")
                        .WithMany("MyEvent")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
