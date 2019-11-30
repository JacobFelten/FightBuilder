using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FightBuilder.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    PhysDam = table.Column<int>(nullable: false),
                    MagDam = table.Column<int>(nullable: false),
                    FireDam = table.Column<int>(nullable: false),
                    PhysDef = table.Column<int>(nullable: false),
                    MagDef = table.Column<int>(nullable: false),
                    FireDef = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentID);
                });

            migrationBuilder.CreateTable(
                name: "Fighters",
                columns: table => new
                {
                    FighterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    HeadEquipmentID = table.Column<int>(nullable: true),
                    ChestEquipmentID = table.Column<int>(nullable: true),
                    GlovesEquipmentID = table.Column<int>(nullable: true),
                    PantsEquipmentID = table.Column<int>(nullable: true),
                    ShoesEquipmentID = table.Column<int>(nullable: true),
                    RingEquipmentID = table.Column<int>(nullable: true),
                    RightHandEquipmentID = table.Column<int>(nullable: true),
                    LeftHandEquipmentID = table.Column<int>(nullable: true),
                    Wins = table.Column<int>(nullable: false),
                    Losses = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fighters", x => x.FighterID);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_ChestEquipmentID",
                        column: x => x.ChestEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_GlovesEquipmentID",
                        column: x => x.GlovesEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_HeadEquipmentID",
                        column: x => x.HeadEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_LeftHandEquipmentID",
                        column: x => x.LeftHandEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_PantsEquipmentID",
                        column: x => x.PantsEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_RightHandEquipmentID",
                        column: x => x.RightHandEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_RingEquipmentID",
                        column: x => x.RingEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Fighters_Equipment_ShoesEquipmentID",
                        column: x => x.ShoesEquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "EquipmentID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_ChestEquipmentID",
                table: "Fighters",
                column: "ChestEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_GlovesEquipmentID",
                table: "Fighters",
                column: "GlovesEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_HeadEquipmentID",
                table: "Fighters",
                column: "HeadEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_LeftHandEquipmentID",
                table: "Fighters",
                column: "LeftHandEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_PantsEquipmentID",
                table: "Fighters",
                column: "PantsEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_RightHandEquipmentID",
                table: "Fighters",
                column: "RightHandEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_RingEquipmentID",
                table: "Fighters",
                column: "RingEquipmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Fighters_ShoesEquipmentID",
                table: "Fighters",
                column: "ShoesEquipmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fighters");

            migrationBuilder.DropTable(
                name: "Equipment");
        }
    }
}
