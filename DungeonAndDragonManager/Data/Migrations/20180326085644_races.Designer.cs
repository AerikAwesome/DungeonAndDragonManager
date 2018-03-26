﻿// <auto-generated />
using DungeonAndDragonManager.Data;
using DungeonAndDragonManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace DungeonAndDragonManager.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180326085644_races")]
    partial class races
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbCampaign", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("DungeonMasterId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DungeonMasterId");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("BaseCharisma");

                    b.Property<byte>("BaseConstitution");

                    b.Property<byte>("BaseDexterity");

                    b.Property<byte>("BaseIntelligence");

                    b.Property<byte>("BaseStrength");

                    b.Property<byte>("BaseWisdom");

                    b.Property<int>("Experience");

                    b.Property<string>("Name");

                    b.Property<int>("PartyId");

                    b.Property<int?>("RaceId");

                    b.Property<int?>("SubRaceId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("PartyId");

                    b.HasIndex("RaceId");

                    b.HasIndex("SubRaceId");

                    b.HasIndex("UserId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbCharacterClass", b =>
                {
                    b.Property<int>("CharacterId");

                    b.Property<int>("ClassId");

                    b.Property<byte>("Level");

                    b.Property<bool>("Primary");

                    b.Property<int>("SkillProficiencies");

                    b.Property<int?>("SubClassId");

                    b.HasKey("CharacterId", "ClassId");

                    b.HasIndex("ClassId");

                    b.HasIndex("SubClassId");

                    b.ToTable("CharacterClasses");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("HitDie");

                    b.Property<byte>("MinimumCharisma");

                    b.Property<byte>("MinimumConstitution");

                    b.Property<byte>("MinimumDexterity");

                    b.Property<byte>("MinimumIntelligence");

                    b.Property<byte>("MinimumStrength");

                    b.Property<byte>("MinimumWisdom");

                    b.Property<string>("Name");

                    b.Property<byte>("PrimaryAbility");

                    b.Property<string>("Regex");

                    b.Property<int>("SaveProficiencies");

                    b.Property<int>("SkillProficiencies");

                    b.Property<int>("SourceId");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbParty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CampaignId");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbRace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Age");

                    b.Property<short>("BonusCharisma");

                    b.Property<short>("BonusConstitution");

                    b.Property<short>("BonusDexterity");

                    b.Property<short>("BonusIntelligence");

                    b.Property<short>("BonusStrength");

                    b.Property<short>("BonusWisdom");

                    b.Property<string>("Description");

                    b.Property<string>("Height");

                    b.Property<string>("Name");

                    b.Property<string>("Plural");

                    b.Property<string>("Regex");

                    b.Property<int>("Size");

                    b.Property<int>("SourceId");

                    b.Property<string>("Trait");

                    b.Property<string>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("SourceId");

                    b.ToTable("Races");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbSource", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Abbreviation");

                    b.Property<string>("CreatorId");

                    b.Property<DateTime?>("Date");

                    b.Property<string>("Group");

                    b.Property<string>("Name");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Sources");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbSubClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClassId");

                    b.Property<string>("Name");

                    b.Property<int>("SourceId");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.HasIndex("SourceId");

                    b.ToTable("SubClasses");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbSubRace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("BonusCharisma");

                    b.Property<short>("BonusConstitution");

                    b.Property<short>("BonusDexterity");

                    b.Property<short>("BonusIntelligence");

                    b.Property<short>("BonusStrength");

                    b.Property<short>("BonusWisdom");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("RaceId");

                    b.Property<string>("Regex");

                    b.Property<int>("SourceId");

                    b.Property<string>("Trait");

                    b.HasKey("Id");

                    b.HasIndex("RaceId");

                    b.HasIndex("SourceId");

                    b.ToTable("SubRaces");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbCampaign", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Models.ApplicationUser", "DungeonMaster")
                        .WithMany()
                        .HasForeignKey("DungeonMasterId");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbCharacter", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Data.Models.DbParty", "Party")
                        .WithMany("PartyMembers")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DungeonAndDragonManager.Data.Models.DbRace", "Race")
                        .WithMany()
                        .HasForeignKey("RaceId");

                    b.HasOne("DungeonAndDragonManager.Data.Models.DbSubRace", "SubRace")
                        .WithMany()
                        .HasForeignKey("SubRaceId");

                    b.HasOne("DungeonAndDragonManager.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbCharacterClass", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Data.Models.DbCharacter", "Character")
                        .WithMany("Classes")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DungeonAndDragonManager.Data.Models.DbClass", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DungeonAndDragonManager.Data.Models.DbSubClass", "SubClass")
                        .WithMany()
                        .HasForeignKey("SubClassId");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbClass", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Data.Models.DbSource", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbParty", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Data.Models.DbCampaign", "Campaign")
                        .WithMany("Parties")
                        .HasForeignKey("CampaignId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbRace", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Data.Models.DbSource", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbSource", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbSubClass", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Data.Models.DbClass", "Class")
                        .WithMany("SubClasses")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DungeonAndDragonManager.Data.Models.DbSource", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DungeonAndDragonManager.Data.Models.DbSubRace", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Data.Models.DbRace", "Race")
                        .WithMany("SubRaces")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("DungeonAndDragonManager.Data.Models.DbSource", "Source")
                        .WithMany()
                        .HasForeignKey("SourceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DungeonAndDragonManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DungeonAndDragonManager.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}