﻿// <auto-generated />
using System;
using Fakebook.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fakebook.Server.Migrations
{
    [DbContext(typeof(FakebookContext))]
    partial class FakebookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Fakebook.Server.Data.Account", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("profileid")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("profileid");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Fakebook.Server.Data.Profile", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("college")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("from")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("high_school")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lives")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("pronouns")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Fakebook.Server.Data.Account", b =>
                {
                    b.HasOne("Fakebook.Server.Data.Profile", "profile")
                        .WithMany()
                        .HasForeignKey("profileid");

                    b.Navigation("profile");
                });
#pragma warning restore 612, 618
        }
    }
}
