using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DungeonAndDragonManager.Data.Migrations
{
    public partial class races : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "Campaigns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    DungeonMasterId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaigns_AspNetUsers_DungeonMasterId",
                        column: x => x.DungeonMasterId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Abbreviation = table.Column<string>(nullable: true),
                    CreatorId = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sources_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CampaignId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parties_Campaigns_CampaignId",
                        column: x => x.CampaignId,
                        principalTable: "Campaigns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HitDie = table.Column<byte>(nullable: false),
                    MinimumCharisma = table.Column<byte>(nullable: false),
                    MinimumConstitution = table.Column<byte>(nullable: false),
                    MinimumDexterity = table.Column<byte>(nullable: false),
                    MinimumIntelligence = table.Column<byte>(nullable: false),
                    MinimumStrength = table.Column<byte>(nullable: false),
                    MinimumWisdom = table.Column<byte>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PrimaryAbility = table.Column<byte>(nullable: false),
                    Regex = table.Column<string>(nullable: true),
                    SaveProficiencies = table.Column<int>(nullable: false),
                    SkillProficiencies = table.Column<int>(nullable: false),
                    SourceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classes_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Races",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Age = table.Column<string>(nullable: true),
                    BonusCharisma = table.Column<short>(nullable: false),
                    BonusConstitution = table.Column<short>(nullable: false),
                    BonusDexterity = table.Column<short>(nullable: false),
                    BonusIntelligence = table.Column<short>(nullable: false),
                    BonusStrength = table.Column<short>(nullable: false),
                    BonusWisdom = table.Column<short>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Plural = table.Column<string>(nullable: true),
                    Regex = table.Column<string>(nullable: true),
                    Size = table.Column<int>(nullable: false),
                    SourceId = table.Column<int>(nullable: false),
                    Trait = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Races", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Races_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubClasses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClassId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SourceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubClasses_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubRaces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BonusCharisma = table.Column<short>(nullable: false),
                    BonusConstitution = table.Column<short>(nullable: false),
                    BonusDexterity = table.Column<short>(nullable: false),
                    BonusIntelligence = table.Column<short>(nullable: false),
                    BonusStrength = table.Column<short>(nullable: false),
                    BonusWisdom = table.Column<short>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    RaceId = table.Column<int>(nullable: false),
                    Regex = table.Column<string>(nullable: true),
                    SourceId = table.Column<int>(nullable: false),
                    Trait = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubRaces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubRaces_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SubRaces_Sources_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Sources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BaseCharisma = table.Column<byte>(nullable: false),
                    BaseConstitution = table.Column<byte>(nullable: false),
                    BaseDexterity = table.Column<byte>(nullable: false),
                    BaseIntelligence = table.Column<byte>(nullable: false),
                    BaseStrength = table.Column<byte>(nullable: false),
                    BaseWisdom = table.Column<byte>(nullable: false),
                    Experience = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    PartyId = table.Column<int>(nullable: false),
                    RaceId = table.Column<int>(nullable: true),
                    SubRaceId = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Parties_PartyId",
                        column: x => x.PartyId,
                        principalTable: "Parties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Races_RaceId",
                        column: x => x.RaceId,
                        principalTable: "Races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_SubRaces_SubRaceId",
                        column: x => x.SubRaceId,
                        principalTable: "SubRaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Characters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CharacterClasses",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false),
                    ClassId = table.Column<int>(nullable: false),
                    Level = table.Column<byte>(nullable: false),
                    Primary = table.Column<bool>(nullable: false),
                    SkillProficiencies = table.Column<int>(nullable: false),
                    SubClassId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterClasses", x => new { x.CharacterId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_CharacterClasses_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterClasses_SubClasses_SubClassId",
                        column: x => x.SubClassId,
                        principalTable: "SubClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Campaigns_DungeonMasterId",
                table: "Campaigns",
                column: "DungeonMasterId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_ClassId",
                table: "CharacterClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterClasses_SubClassId",
                table: "CharacterClasses",
                column: "SubClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PartyId",
                table: "Characters",
                column: "PartyId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_RaceId",
                table: "Characters",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_SubRaceId",
                table: "Characters",
                column: "SubRaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Classes_SourceId",
                table: "Classes",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Parties_CampaignId",
                table: "Parties",
                column: "CampaignId");

            migrationBuilder.CreateIndex(
                name: "IX_Races_SourceId",
                table: "Races",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Sources_CreatorId",
                table: "Sources",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_SubClasses_ClassId",
                table: "SubClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_SubClasses_SourceId",
                table: "SubClasses",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubRaces_RaceId",
                table: "SubRaces",
                column: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubRaces_SourceId",
                table: "SubRaces",
                column: "SourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CharacterClasses");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "SubClasses");

            migrationBuilder.DropTable(
                name: "Parties");

            migrationBuilder.DropTable(
                name: "SubRaces");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Campaigns");

            migrationBuilder.DropTable(
                name: "Races");

            migrationBuilder.DropTable(
                name: "Sources");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
