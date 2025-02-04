﻿// <auto-generated />
using System;
using API.External.Person.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.External.Person.Migrations
{
    [DbContext(typeof(PersonAppDbContext))]
    partial class ExempleAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.External.Person.Feature.Domain.Exemple.ExempleEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DtDelete")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DtDeleteId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DtInsert")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DtInsertId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DtUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DtUpdateId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(6)
                        .IsUnicode(false)
                        .HasColumnType("varchar(6)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Notification")
                        .IsRequired()
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2048)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Exemple");
                });

            modelBuilder.Entity("API.External.Person.Feature.Domain.Exemple.ExempleEntity", b =>
                {
                    b.OwnsOne("Common.Core._08.Domain.ValueObjects.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ExempleEntityId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Address")
                                .IsRequired()
                                .HasMaxLength(254)
                                .IsUnicode(false)
                                .HasColumnType("varchar(254)")
                                .HasColumnName("Email");

                            b1.HasKey("ExempleEntityId");

                            b1.ToTable("Exemple");

                            b1.WithOwner()
                                .HasForeignKey("ExempleEntityId");
                        });

                    b.OwnsOne("Common.Core._08.Domain.ValueObjects.PhoneNumber", "Phone", b1 =>
                        {
                            b1.Property<Guid>("ExempleEntityId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Phone")
                                .IsRequired()
                                .HasMaxLength(20)
                                .IsUnicode(false)
                                .HasColumnType("varchar(20)")
                                .HasColumnName("Phone");

                            b1.HasKey("ExempleEntityId");

                            b1.ToTable("Exemple");

                            b1.WithOwner()
                                .HasForeignKey("ExempleEntityId");
                        });

                    b.Navigation("Email")
                        .IsRequired();

                    b.Navigation("Phone")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
