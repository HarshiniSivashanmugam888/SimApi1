﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimApi1.DataContext;

#nullable disable

namespace SimApi1.Migrations
{
    [DbContext(typeof(SimApi1DbContext))]
    partial class SimApi1DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SimApi1.Models.Component_Details", b =>
                {
                    b.Property<Guid>("Gu_Comp_Details_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Comp_Details_Id")
                        .HasColumnType("int");

                    b.Property<int>("Comp_Mast_Id")
                        .HasColumnType("int");

                    b.Property<string>("Comp_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Min_Qty")
                        .HasColumnType("float");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Gu_Comp_Details_Id");

                    b.ToTable("Comp_Details");
                });

            modelBuilder.Entity("SimApi1.Models.Component_Master", b =>
                {
                    b.Property<Guid>("Gu_Comp_Mast_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Comp_Mast_Id")
                        .HasColumnType("int");

                    b.Property<string>("Comp_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Min_Qty")
                        .HasColumnType("float");

                    b.Property<string>("Unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Gu_Comp_Mast_Id");

                    b.ToTable("Comp_Mast");
                });

            modelBuilder.Entity("SimApi1.Models.Product_Details", b =>
                {
                    b.Property<Guid>("Gu_Prod_Details_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Comp_Details_Id")
                        .HasColumnType("int");

                    b.Property<int>("Prod_Details_Id")
                        .HasColumnType("int");

                    b.Property<string>("Prod_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Qty")
                        .HasColumnType("float");

                    b.HasKey("Gu_Prod_Details_Id");

                    b.ToTable("Prod_Details");
                });

            modelBuilder.Entity("SimApi1.Models.Product_Master", b =>
                {
                    b.Property<Guid>("Gu_Prod_Mast_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Prod_Mast_Id")
                        .HasColumnType("int");

                    b.Property<string>("Prod_Mast_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Gu_Prod_Mast_Id");

                    b.ToTable("Prod_Mast");
                });

            modelBuilder.Entity("SimApi1.Models.Spares_Out_For_Production", b =>
                {
                    b.Property<Guid>("Gu_Spares_Out_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Comp_Details_Id")
                        .HasColumnType("int");

                    b.Property<int>("Prod_Mast_Id")
                        .HasColumnType("int");

                    b.Property<double>("Qty")
                        .HasColumnType("float");

                    b.Property<int>("Spares_Out_Id")
                        .HasColumnType("int");

                    b.Property<int>("Staff_Id")
                        .HasColumnType("int");

                    b.HasKey("Gu_Spares_Out_Id");

                    b.ToTable("Spares_Out_For_Production");
                });

            modelBuilder.Entity("SimApi1.Models.Staff_Production_In_Entry", b =>
                {
                    b.Property<Guid>("Gu_In_Entry_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("In_Entry_Id")
                        .HasColumnType("int");

                    b.Property<string>("Prod_Mast_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prod_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Qty")
                        .HasColumnType("float");

                    b.Property<int>("Staff_Id")
                        .HasColumnType("int");

                    b.HasKey("Gu_In_Entry_Id");

                    b.ToTable("Staff_Prod_In_Entry");
                });

            modelBuilder.Entity("SimApi1.Models.Stock", b =>
                {
                    b.Property<Guid>("Gu_Stock_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Box_unit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Buyer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Comp_Details_Id")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Qty")
                        .HasColumnType("float");

                    b.Property<int>("Stock_Id")
                        .HasColumnType("int");

                    b.HasKey("Gu_Stock_Id");

                    b.ToTable("Stock");
                });
#pragma warning restore 612, 618
        }
    }
}
