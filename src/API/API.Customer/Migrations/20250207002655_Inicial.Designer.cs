﻿// <auto-generated />
using System;
using API.Customer.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Customer.Migrations
{
    [DbContext(typeof(CustomerAppDbContext))]
    [Migration("20250207002655_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Customer.Domain.AccountEntity", b =>
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

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("API.Customer.Domain.AccountProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountSubscriptionId")
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

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AccountSubscriptionId");

                    b.ToTable("AccountProduct");
                });

            modelBuilder.Entity("API.Customer.Domain.AccountSubscriptionEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountId")
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

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<Guid>("SubscriptionPlanId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("SubscriptionPlanId");

                    b.ToTable("AccountSubscription");
                });

            modelBuilder.Entity("API.Customer.Domain.MessageUsageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AccountSubscriptionId")
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

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("AccountSubscriptionId");

                    b.ToTable("MessageUsage");
                });

            modelBuilder.Entity("API.Customer.Domain.MessageUsageItemEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("CostPerUnit")
                        .HasColumnType("decimal(18,2)");

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

                    b.Property<string>("MessageType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid>("MessageUsageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("MessageUsageId");

                    b.ToTable("MessageUsageItem");
                });

            modelBuilder.Entity("API.Customer.Domain.SubscriptionPlanEntity", b =>
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

                    b.Property<int>("EmailLimit")
                        .HasColumnType("int");

                    b.Property<decimal>("MonthlyPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("OverageCostPerEmail")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OverageCostPerSms")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OverageCostPerWhatsApp")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SmsLimit")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("WhatsAppLimit")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionPlan");
                });

            modelBuilder.Entity("Common.Core._08.Domain.BaseEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(34)
                        .HasColumnType("nvarchar(34)");

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

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("BaseEntity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEntity");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("API.Customer.Domain.AccountPersonUserEntity", b =>
                {
                    b.HasBaseType("Common.Core._08.Domain.BaseEntity");

                    b.Property<Guid>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasIndex("AccountId");

                    b.HasDiscriminator().HasValue("AccountPersonUserEntity");
                });

            modelBuilder.Entity("API.Customer.Domain.AccountProductEntity", b =>
                {
                    b.HasOne("API.Customer.Domain.AccountSubscriptionEntity", "AccountSubscription")
                        .WithMany()
                        .HasForeignKey("AccountSubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountSubscription");
                });

            modelBuilder.Entity("API.Customer.Domain.AccountSubscriptionEntity", b =>
                {
                    b.HasOne("API.Customer.Domain.AccountEntity", "Account")
                        .WithMany("Subscriptions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Customer.Domain.SubscriptionPlanEntity", "SubscriptionPlan")
                        .WithMany()
                        .HasForeignKey("SubscriptionPlanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("SubscriptionPlan");
                });

            modelBuilder.Entity("API.Customer.Domain.MessageUsageEntity", b =>
                {
                    b.HasOne("API.Customer.Domain.AccountSubscriptionEntity", "AccountSubscription")
                        .WithMany("MessageUsages")
                        .HasForeignKey("AccountSubscriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccountSubscription");
                });

            modelBuilder.Entity("API.Customer.Domain.MessageUsageItemEntity", b =>
                {
                    b.HasOne("API.Customer.Domain.MessageUsageEntity", "MessageUsage")
                        .WithMany("MessageUsageItems")
                        .HasForeignKey("MessageUsageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MessageUsage");
                });

            modelBuilder.Entity("API.Customer.Domain.AccountPersonUserEntity", b =>
                {
                    b.HasOne("API.Customer.Domain.AccountEntity", "Account")
                        .WithMany("PersonUsers")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("API.Customer.Domain.AccountEntity", b =>
                {
                    b.Navigation("PersonUsers");

                    b.Navigation("Subscriptions");
                });

            modelBuilder.Entity("API.Customer.Domain.AccountSubscriptionEntity", b =>
                {
                    b.Navigation("MessageUsages");
                });

            modelBuilder.Entity("API.Customer.Domain.MessageUsageEntity", b =>
                {
                    b.Navigation("MessageUsageItems");
                });
#pragma warning restore 612, 618
        }
    }
}
