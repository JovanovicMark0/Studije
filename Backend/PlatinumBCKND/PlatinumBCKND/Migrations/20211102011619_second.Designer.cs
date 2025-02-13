﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatinumBCKND.Models;

namespace PlatinumBCKND.Migrations
{
    [DbContext(typeof(OglasContext))]
    [Migration("20211102011619_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20");

            modelBuilder.Entity("PlatinumBCKND.Models.Grad", b =>
                {
                    b.Property<int>("idGrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("nazivGrada")
                        .HasColumnType("TEXT");

                    b.HasKey("idGrada");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.Gradnja", b =>
                {
                    b.Property<int>("idGradnje")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("tipGradnje")
                        .HasColumnType("TEXT");

                    b.HasKey("idGradnje");

                    b.ToTable("Gradnja");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.Login", b =>
                {
                    b.Property<Guid>("idUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<string>("salt")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.HasKey("idUser");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.Namestenost", b =>
                {
                    b.Property<int>("idNamestenosti")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("namestenost")
                        .HasColumnType("TEXT");

                    b.HasKey("idNamestenosti");

                    b.ToTable("Namestenost");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.Oglas", b =>
                {
                    b.Property<Guid>("idOglasa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("brojLajkova")
                        .HasColumnType("INTEGER");

                    b.Property<int>("cena")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("datumIsteka")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("idStana")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("idVlasnika")
                        .HasColumnType("TEXT");

                    b.Property<string>("naslovOglasa")
                        .HasColumnType("TEXT");

                    b.Property<string>("opisOglasa")
                        .HasColumnType("TEXT");

                    b.Property<int>("prodajaDaNe")
                        .HasColumnType("INTEGER");

                    b.HasKey("idOglasa");

                    b.ToTable("Oglas");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.Stan", b =>
                {
                    b.Property<Guid>("idStana")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("KATV")
                        .HasColumnType("INTEGER");

                    b.Property<string>("adresa")
                        .HasColumnType("TEXT");

                    b.Property<int>("brojSoba")
                        .HasColumnType("INTEGER");

                    b.Property<string>("dodatniOpis")
                        .HasColumnType("TEXT");

                    b.Property<int>("grejanje")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idGrada")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idGradnje")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idNamestenosti")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idStanjaObjekta")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idTipaStana")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("idVlasnika")
                        .HasColumnType("TEXT");

                    b.Property<int>("interfon")
                        .HasColumnType("INTEGER");

                    b.Property<int>("internet")
                        .HasColumnType("INTEGER");

                    b.Property<int>("klima")
                        .HasColumnType("INTEGER");

                    b.Property<int>("lift")
                        .HasColumnType("INTEGER");

                    b.Property<int>("parking")
                        .HasColumnType("INTEGER");

                    b.Property<int>("povrsina")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sprat")
                        .HasColumnType("INTEGER");

                    b.Property<int>("telefon")
                        .HasColumnType("INTEGER");

                    b.Property<int>("terasa")
                        .HasColumnType("INTEGER");

                    b.Property<int>("videoNadzor")
                        .HasColumnType("INTEGER");

                    b.HasKey("idStana");

                    b.ToTable("Stan");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.StanjeObjekta", b =>
                {
                    b.Property<int>("idStanja")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("stanje")
                        .HasColumnType("TEXT");

                    b.HasKey("idStanja");

                    b.ToTable("StanjeObjekta");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.TipStana", b =>
                {
                    b.Property<int>("idTipa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("tipStana")
                        .HasColumnType("TEXT");

                    b.HasKey("idTipa");

                    b.ToTable("TipStana");
                });

            modelBuilder.Entity("PlatinumBCKND.Models.Vlasnik", b =>
                {
                    b.Property<Guid>("idVlasnika")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("brojOcena")
                        .HasColumnType("INTEGER");

                    b.Property<int>("brojOglasa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("brojTelefona")
                        .HasColumnType("TEXT");

                    b.Property<string>("punoIme")
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .HasColumnType("TEXT");

                    b.Property<int>("zbirSvihOcena")
                        .HasColumnType("INTEGER");

                    b.HasKey("idVlasnika");

                    b.ToTable("Vlasnik");
                });
#pragma warning restore 612, 618
        }
    }
}
