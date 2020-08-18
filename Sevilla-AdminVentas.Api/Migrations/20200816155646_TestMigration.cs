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
                name: "CatAmbitTypeEntity",
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
                name: "CatInvoiceStatusEntity",
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
                name: "CatInvoiceTypeEntity",
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
                name: "CatStatusEntity",
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
                name: "CatTaxTypeEntity",
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
                name: "ProductEntity",
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
                name: "UserEntity",
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
                        principalTable: "CatStatusEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEntity",
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
                        principalTable: "CatStatusEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_User",
                        column: x => x.UserID,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceEntity",
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
                        principalTable: "CatInvoiceStatusEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_CatTypeInvoice",
                        column: x => x.TypeID,
                        principalTable: "CatInvoiceTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice_User",
                        column: x => x.UserId,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TaxEntity",
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
                        principalTable: "CatStatusEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tax_CatAmbitType",
                        column: x => x.TypeAmbitId,
                        principalTable: "CatAmbitTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tax_CatTaxType",
                        column: x => x.TypeId,
                        principalTable: "CatTaxTypeEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tax_User",
                        column: x => x.UserId,
                        principalTable: "UserEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product2TaxEntity",
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
                        principalTable: "ProductEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoice2Tax_Tax",
                        column: x => x.TaxId,
                        principalTable: "TaxEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_StatusID",
                table: "CustomerEntity",
                column: "StatusID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_UserID",
                table: "CustomerEntity",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_StatusId",
                table: "InvoiceEntity",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_TypeID",
                table: "InvoiceEntity",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_UserId",
                table: "InvoiceEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product2Tax_ProductId",
                table: "Product2TaxEntity",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product2Tax_TaxId",
                table: "Product2TaxEntity",
                column: "TaxId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_StatusId",
                table: "TaxEntity",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_TypeAmbitId",
                table: "TaxEntity",
                column: "TypeAmbitId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_TypeId",
                table: "TaxEntity",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tax_UserId",
                table: "TaxEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_StatusId",
                table: "UserEntity",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerEntity");

            migrationBuilder.DropTable(
                name: "InvoiceEntity");

            migrationBuilder.DropTable(
                name: "Product2TaxEntity");

            migrationBuilder.DropTable(
                name: "CatInvoiceStatusEntity");

            migrationBuilder.DropTable(
                name: "CatInvoiceTypeEntity");

            migrationBuilder.DropTable(
                name: "ProductEntity");

            migrationBuilder.DropTable(
                name: "TaxEntity");

            migrationBuilder.DropTable(
                name: "CatAmbitTypeEntity");

            migrationBuilder.DropTable(
                name: "CatTaxTypeEntity");

            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "CatStatusEntity");
        }
    }
}
