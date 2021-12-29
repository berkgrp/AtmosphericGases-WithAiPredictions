﻿// <auto-generated />
using System;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityLayer.Migrations
{
    [DbContext(typeof(AtmosphericGasesDBContext))]
    [Migration("20211214104528_ResultUpdate")]
    partial class ResultUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("EntityLayer.Model.MDataPublish", b =>
                {
                    b.Property<int>("DataPublishID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DataName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("SensorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DataPublishID");

                    b.ToTable("MDataPublishes");
                });

            modelBuilder.Entity("EntityLayer.Model.Result", b =>
                {
                    b.Property<int>("ResultID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PredictedDataValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("RealDataValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SensorName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResultID");

                    b.ToTable("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
