﻿// <auto-generated />
using System;
using CallCenterAPI.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CallCenterAPI.Migrations
{
    [DbContext(typeof(CallDbContext))]
    [Migration("20230818075506_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CallCenterAPI.Model.CallRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CallAnswered")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallEnd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CallStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("DialNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("External")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalDn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinalNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromDn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FromNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Internal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonChanged")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReasonTerminated")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondInternal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeAnswered")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("ToDn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ToNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CallRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
