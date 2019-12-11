﻿// <auto-generated />
using System;
using BabyPoll;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace babypoll.Migrations
{
    [DbContext(typeof(BabyPollContext))]
    [Migration("20191211130534_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0");

            modelBuilder.Entity("BabyPoll.Models.Entry", b =>
                {
                    b.Property<Guid?>("EntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Guess")
                        .HasColumnType("TEXT");

                    b.Property<string>("Participant")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("PollId")
                        .HasColumnType("TEXT");

                    b.HasKey("EntryId");

                    b.HasIndex("PollId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("BabyPoll.Models.Poll", b =>
                {
                    b.Property<Guid>("PollId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .HasColumnType("TEXT");

                    b.HasKey("PollId");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("BabyPoll.Models.Entry", b =>
                {
                    b.HasOne("BabyPoll.Models.Poll", null)
                        .WithMany("Entries")
                        .HasForeignKey("PollId");
                });
#pragma warning restore 612, 618
        }
    }
}
