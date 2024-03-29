﻿// <auto-generated />
using System;
using LoginAndAdminPanel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoginAndAdminPanel.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210522104044_initialdb")]
    partial class initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoginAndAdminPanel.Models.Kurucu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kurucus");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Mudur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KurucuId")
                        .HasColumnType("int");

                    b.Property<int?>("OkulId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KurucuId");

                    b.HasIndex("OkulId");

                    b.ToTable("Mudurs");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KurucuId")
                        .HasColumnType("int");

                    b.Property<int?>("MudurId")
                        .HasColumnType("int");

                    b.Property<int?>("OgretmenId")
                        .HasColumnType("int");

                    b.Property<int?>("OkulId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KurucuId");

                    b.HasIndex("MudurId");

                    b.HasIndex("OgretmenId");

                    b.HasIndex("OkulId");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Ogretmen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KurucuId")
                        .HasColumnType("int");

                    b.Property<int?>("MudurId")
                        .HasColumnType("int");

                    b.Property<int?>("OkulId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KurucuId");

                    b.HasIndex("MudurId");

                    b.HasIndex("OkulId");

                    b.ToTable("Ogretmens");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Okul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Isim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KurucuId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KurucuId");

                    b.ToTable("Okuls");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Mudur", b =>
                {
                    b.HasOne("LoginAndAdminPanel.Models.Kurucu", "Kurucu")
                        .WithMany("Mudurs")
                        .HasForeignKey("KurucuId");

                    b.HasOne("LoginAndAdminPanel.Models.Okul", "Okul")
                        .WithMany()
                        .HasForeignKey("OkulId");

                    b.Navigation("Kurucu");

                    b.Navigation("Okul");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Ogrenci", b =>
                {
                    b.HasOne("LoginAndAdminPanel.Models.Kurucu", "Kurucu")
                        .WithMany("Ogrencis")
                        .HasForeignKey("KurucuId");

                    b.HasOne("LoginAndAdminPanel.Models.Mudur", "Mudur")
                        .WithMany("Ogrencis")
                        .HasForeignKey("MudurId");

                    b.HasOne("LoginAndAdminPanel.Models.Ogretmen", "Ogretmen")
                        .WithMany("Ogrencis")
                        .HasForeignKey("OgretmenId");

                    b.HasOne("LoginAndAdminPanel.Models.Okul", "Okul")
                        .WithMany("Ogrencis")
                        .HasForeignKey("OkulId");

                    b.Navigation("Kurucu");

                    b.Navigation("Mudur");

                    b.Navigation("Ogretmen");

                    b.Navigation("Okul");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Ogretmen", b =>
                {
                    b.HasOne("LoginAndAdminPanel.Models.Kurucu", "Kurucu")
                        .WithMany("Ogretmens")
                        .HasForeignKey("KurucuId");

                    b.HasOne("LoginAndAdminPanel.Models.Mudur", "Mudur")
                        .WithMany("Ogretmens")
                        .HasForeignKey("MudurId");

                    b.HasOne("LoginAndAdminPanel.Models.Okul", "Okul")
                        .WithMany("Ogretmens")
                        .HasForeignKey("OkulId");

                    b.Navigation("Kurucu");

                    b.Navigation("Mudur");

                    b.Navigation("Okul");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Okul", b =>
                {
                    b.HasOne("LoginAndAdminPanel.Models.Kurucu", "Kurucu")
                        .WithMany("Okuls")
                        .HasForeignKey("KurucuId");

                    b.Navigation("Kurucu");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Kurucu", b =>
                {
                    b.Navigation("Mudurs");

                    b.Navigation("Ogrencis");

                    b.Navigation("Ogretmens");

                    b.Navigation("Okuls");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Mudur", b =>
                {
                    b.Navigation("Ogrencis");

                    b.Navigation("Ogretmens");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Ogretmen", b =>
                {
                    b.Navigation("Ogrencis");
                });

            modelBuilder.Entity("LoginAndAdminPanel.Models.Okul", b =>
                {
                    b.Navigation("Ogrencis");

                    b.Navigation("Ogretmens");
                });
#pragma warning restore 612, 618
        }
    }
}
