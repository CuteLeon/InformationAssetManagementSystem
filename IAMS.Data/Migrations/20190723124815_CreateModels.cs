using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IAMS.Data.Migrations
{
    public partial class CreateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AuxiliaryComputers",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    NameNumber = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    BuyDateTime = table.Column<DateTime>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    Admin = table.Column<string>(nullable: true),
                    Use = table.Column<string>(nullable: true),
                    CPU = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    Memory = table.Column<string>(nullable: true),
                    Disk = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SSDSerialNumber = table.Column<string>(nullable: true),
                    MDSerialNumber = table.Column<string>(nullable: true),
                    WiredMAC = table.Column<string>(nullable: true),
                    WirelessMAC = table.Column<string>(nullable: true),
                    Borrower = table.Column<string>(nullable: true),
                    BorrowDateTime = table.Column<DateTime>(nullable: false),
                    Returner = table.Column<string>(nullable: true),
                    ReturnDateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuxiliaryComputers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DesktopComputers",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    NameNumber = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    BuyDateTime = table.Column<DateTime>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    Admin = table.Column<string>(nullable: true),
                    Use = table.Column<string>(nullable: true),
                    CPU = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    Memory = table.Column<string>(nullable: true),
                    Disk = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SSDSerialNumber = table.Column<string>(nullable: true),
                    MDSerialNumber = table.Column<string>(nullable: true),
                    MAC = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesktopComputers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LaptopComputers",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    NameNumber = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    BuyDateTime = table.Column<DateTime>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    Admin = table.Column<string>(nullable: true),
                    Use = table.Column<string>(nullable: true),
                    CPU = table.Column<string>(nullable: true),
                    GPU = table.Column<string>(nullable: true),
                    Memory = table.Column<string>(nullable: true),
                    Disk = table.Column<string>(nullable: true),
                    Size = table.Column<string>(nullable: true),
                    SSDSerialNumber = table.Column<string>(nullable: true),
                    MDSerialNumber = table.Column<string>(nullable: true),
                    WiredMAC = table.Column<string>(nullable: true),
                    WirelessMAC = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaptopComputers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OtherEquipments",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    NameNumber = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    BuyDateTime = table.Column<DateTime>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    Admin = table.Column<string>(nullable: true),
                    Use = table.Column<string>(nullable: true),
                    ManagementDepartment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherEquipments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IDNumber = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    OuterNetComputerNumber = table.Column<string>(nullable: true),
                    OuterNetComputerIP = table.Column<string>(nullable: true),
                    InnerNetComputerNumber = table.Column<string>(nullable: true),
                    InnerNetComputerIP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RoomEquipments",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    NameNumber = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    BuyDateTime = table.Column<DateTime>(nullable: false),
                    BuyPrice = table.Column<double>(nullable: false),
                    Admin = table.Column<string>(nullable: true),
                    Use = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    User = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomEquipments", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuxiliaryComputers");

            migrationBuilder.DropTable(
                name: "DesktopComputers");

            migrationBuilder.DropTable(
                name: "LaptopComputers");

            migrationBuilder.DropTable(
                name: "OtherEquipments");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "RoomEquipments");
        }
    }
}
