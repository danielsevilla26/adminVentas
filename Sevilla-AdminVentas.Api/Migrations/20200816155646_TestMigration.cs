using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SevillaAdminVentas.Api.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatAmbitType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatAmbitType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatInvoiceStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatInvoiceStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatInvoiceType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatInvoiceType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CatTaxType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTaxType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProdServKey = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    UnitKey = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    IDNumber = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10, 2)", nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_CatStatus",
                        column: x => x.StatusId,
                        principalTable: "CatStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    ComertialName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    RFC = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    TaxResidence = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    CP = table.Column<int>(nullable: false),
                    Address = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    StateId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    StatusID = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_CatStatus",
                        column: x => x.StatusID,
                        principalTable: "CatStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_User",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UUID = table.Column<byte[]>(maxLength: 50, nullable: false),
                    RCFReceiver = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10, 3)", nullable: false),
                    Serie = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Folio = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    TypeID = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice_CatStatusInvoice",
                        column: x => x.StatusId,
                        principalTable: "CatInvoiceStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_CatTypeInvoice",
                        column: x => x.TypeID,
                        principalTable: "CatInvoiceType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tax",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    TypeId = table.Column<int>(nullable: false),
                    TypeAmbitId = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(type: "decimal(10, 6)", nullable: false),
                    TaxKey = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    FactorType = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    FeeRate = table.Column<string>(unicode: false, maxLength: 20, nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tax_CatStatus",
                        column: x => x.StatusId,
                        principalTable: "CatStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tax_CatAmbitType",
                        column: x => x.TypeAmbitId,
                        principalTable: "CatAmbitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tax_CatTaxType",
                        column: x => x.TypeId,
                        principalTable: "CatTaxType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tax_User",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product2Tax",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    TaxId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product2Tax", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoice2Tax_Product",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice2Tax_Tax",
                        column: x => x.TaxId,
                        principalTable: "Tax",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_StatusID",
                table: "Customer",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserID",
                table: "Customer",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_StatusId",
                table: "Invoice",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_TypeID",
                table: "Invoice",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_UserId",
                table: "Invoice",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product2Tax_ProductId",
                table: "Product2Tax",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product2Tax_TaxId",
                table: "Product2Tax",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_StatusId",
                table: "Tax",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_TypeAmbitId",
                table: "Tax",
                column: "TypeAmbitId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_TypeId",
                table: "Tax",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_UserId",
                table: "Tax",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_StatusId",
                table: "User",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "Product2Tax");

            migrationBuilder.DropTable(
                name: "CatInvoiceStatus");

            migrationBuilder.DropTable(
                name: "CatInvoiceType");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Tax");

            migrationBuilder.DropTable(
                name: "CatAmbitType");

            migrationBuilder.DropTable(
                name: "CatTaxType");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "CatStatus");
        }
    }
}
