﻿// <auto-generated />
using System;
using Finance.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Finance.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221105082547_Finance")]
    partial class Finance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Finance.Model.ClassModel", b =>
                {
                    b.Property<int>("Id_Class")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Credit")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Majors")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name_Class")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Quantity")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("School_Year")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Tariff_Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Tariff_Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Type_Education")
                        .HasColumnType("int");

                    b.HasKey("Id_Class");

                    b.ToTable("ClassModels");
                });

            modelBuilder.Entity("Finance.Model.ExemptionsModel", b =>
                {
                    b.Property<int>("Id_Exemptions")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("EndDate")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyBy")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Money_Exemptions")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name_Exemptions")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Percent")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("StartDate")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("Total_Payment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("tariffModelsId_Tariff")
                        .HasColumnType("int");

                    b.HasKey("Id_Exemptions");

                    b.HasIndex("tariffModelsId_Tariff");

                    b.ToTable("ExemptionsModels");
                });

            modelBuilder.Entity("Finance.Model.RoleModel", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Finance.Model.StudentModel", b =>
                {
                    b.Property<int>("Id_Student")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Card")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("ClassModelId_Class")
                        .HasColumnType("int");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("DienThoai")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<int>("Id_Class")
                        .HasColumnType("int");

                    b.Property<int>("Id_Profile")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NgaySinh")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("Type_Education")
                        .HasColumnType("int");

                    b.HasKey("Id_Student");

                    b.HasIndex("ClassModelId_Class");

                    b.ToTable("StudentModels");
                });

            modelBuilder.Entity("Finance.Model.TariffModel", b =>
                {
                    b.Property<int>("Id_Tariff")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Autumn")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<int>("CodeBill")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("EndDate")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifyBy")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Money")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasMaxLength(10)
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Total_Payment")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id_Tariff");

                    b.ToTable("TariffModels");
                });

            modelBuilder.Entity("Finance.Model.TeacherModel", b =>
                {
                    b.Property<int>("Teacher_ID")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Birthday")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("timekeepingModelsID_Timekeeping")
                        .HasColumnType("int");

                    b.HasKey("Teacher_ID");

                    b.HasIndex("timekeepingModelsID_Timekeeping");

                    b.ToTable("TeacherModels");
                });

            modelBuilder.Entity("Finance.Model.TimekeepingModel", b =>
                {
                    b.Property<int>("ID_Timekeeping")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ID_Teacher")
                        .HasColumnType("int");

                    b.Property<int>("ID_User")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID_Timekeeping");

                    b.ToTable("TimekeepingModels");
                });

            modelBuilder.Entity("Finance.Model.UserModel", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("Birthday")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("ClassID")
                        .HasColumnType("int");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<int>("Id_Tariff")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("classsId_Class")
                        .HasColumnType("int");

                    b.Property<int?>("rolesRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("tariffModelsId_Tariff")
                        .HasColumnType("int");

                    b.Property<int?>("timekeepingModelsID_Timekeeping")
                        .HasColumnType("int");

                    b.HasKey("User_ID");

                    b.HasIndex("classsId_Class");

                    b.HasIndex("rolesRoleId");

                    b.HasIndex("tariffModelsId_Tariff");

                    b.HasIndex("timekeepingModelsID_Timekeeping");

                    b.ToTable("UserModel");
                });

            modelBuilder.Entity("Finance.Model.ExemptionsModel", b =>
                {
                    b.HasOne("Finance.Model.TariffModel", "tariffModels")
                        .WithMany("exemptionsModels")
                        .HasForeignKey("tariffModelsId_Tariff");

                    b.Navigation("tariffModels");
                });

            modelBuilder.Entity("Finance.Model.StudentModel", b =>
                {
                    b.HasOne("Finance.Model.ClassModel", null)
                        .WithMany("studentModels")
                        .HasForeignKey("ClassModelId_Class");
                });

            modelBuilder.Entity("Finance.Model.TeacherModel", b =>
                {
                    b.HasOne("Finance.Model.ClassModel", null)
                        .WithMany("teacherModels")
                        .HasForeignKey("Teacher_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Finance.Model.TimekeepingModel", "timekeepingModels")
                        .WithMany()
                        .HasForeignKey("timekeepingModelsID_Timekeeping");

                    b.Navigation("timekeepingModels");
                });

            modelBuilder.Entity("Finance.Model.UserModel", b =>
                {
                    b.HasOne("Finance.Model.ClassModel", "classs")
                        .WithMany("userModels")
                        .HasForeignKey("classsId_Class");

                    b.HasOne("Finance.Model.RoleModel", "roles")
                        .WithMany()
                        .HasForeignKey("rolesRoleId");

                    b.HasOne("Finance.Model.TariffModel", "tariffModels")
                        .WithMany("userModels")
                        .HasForeignKey("tariffModelsId_Tariff");

                    b.HasOne("Finance.Model.TimekeepingModel", "timekeepingModels")
                        .WithMany()
                        .HasForeignKey("timekeepingModelsID_Timekeeping");

                    b.Navigation("classs");

                    b.Navigation("roles");

                    b.Navigation("tariffModels");

                    b.Navigation("timekeepingModels");
                });

            modelBuilder.Entity("Finance.Model.ClassModel", b =>
                {
                    b.Navigation("studentModels");

                    b.Navigation("teacherModels");

                    b.Navigation("userModels");
                });

            modelBuilder.Entity("Finance.Model.TariffModel", b =>
                {
                    b.Navigation("exemptionsModels");

                    b.Navigation("userModels");
                });
#pragma warning restore 612, 618
        }
    }
}