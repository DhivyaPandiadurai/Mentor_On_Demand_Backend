﻿// <auto-generated />
using System;
using MOD.PaymentService.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MOD.PaymentService.Migrations
{
    [DbContext(typeof(PaymentContext))]
    [Migration("20191123054635_paymentMig")]
    partial class paymentMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MOD.PaymentService.Models.Mentor", b =>
                {
                    b.Property<long>("Mid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Primary_skill")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("availability")
                        .HasColumnType("bit");

                    b.Property<int>("exp")
                        .HasColumnType("int");

                    b.Property<string>("timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Mid");

                    b.ToTable("Mentor");
                });

            modelBuilder.Entity("MOD.PaymentService.Models.Payment", b =>
                {
                    b.Property<long>("Pid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Mentor_Amount")
                        .HasColumnType("float");

                    b.Property<long>("Mid")
                        .HasColumnType("bigint");

                    b.Property<long>("Uid")
                        .HasColumnType("bigint");

                    b.Property<double>("amount")
                        .HasColumnType("float");

                    b.HasKey("Pid");

                    b.HasIndex("Mid");

                    b.HasIndex("Uid");

                    b.ToTable("Payment");

                    b.HasData(
                        new
                        {
                            Pid = 12L,
                            Mentor_Amount = 4589.0,
                            Mid = 23L,
                            Uid = 3L,
                            amount = 34567.889999999999
                        });
                });

            modelBuilder.Entity("MOD.PaymentService.Models.Technology", b =>
                {
                    b.Property<long>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<double>("Fee")
                        .HasColumnType("float");

                    b.Property<string>("SkillName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("TableOfContent")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SkillId");

                    b.ToTable("Technology");
                });

            modelBuilder.Entity("MOD.PaymentService.Models.Training", b =>
                {
                    b.Property<long>("TrainingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Mid")
                        .HasColumnType("bigint");

                    b.Property<long>("Progress")
                        .HasColumnType("bigint");

                    b.Property<long>("SkillId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("Uid")
                        .HasColumnType("bigint");

                    b.Property<float>("rating")
                        .HasColumnType("real");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timeslot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrainingID");

                    b.HasIndex("Mid");

                    b.HasIndex("SkillId");

                    b.HasIndex("Uid");

                    b.ToTable("Training");
                });

            modelBuilder.Entity("MOD.PaymentService.Models.User", b =>
                {
                    b.Property<long>("Uid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Mobile")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Uid");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MOD.PaymentService.Models.Payment", b =>
                {
                    b.HasOne("MOD.PaymentService.Models.Mentor", "Mentor")
                        .WithMany("Payment")
                        .HasForeignKey("Mid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.PaymentService.Models.User", "User")
                        .WithMany("Payment")
                        .HasForeignKey("Uid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MOD.PaymentService.Models.Training", b =>
                {
                    b.HasOne("MOD.PaymentService.Models.Mentor", "Mentor")
                        .WithMany("Training")
                        .HasForeignKey("Mid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.PaymentService.Models.Technology", "Technology")
                        .WithMany("Training")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MOD.PaymentService.Models.User", "User")
                        .WithMany("Training")
                        .HasForeignKey("Uid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}