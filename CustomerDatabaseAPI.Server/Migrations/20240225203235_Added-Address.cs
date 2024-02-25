using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustomerDatabaseAPI.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCall_Customer_CustomerId",
                table: "CompanyCall");

            migrationBuilder.DropForeignKey(
                name: "FK_Email_Customer_CustomerId",
                table: "Email");

            migrationBuilder.DropForeignKey(
                name: "FK_Phone_Customer_CustomerID",
                table: "Phone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phone",
                table: "Phone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Email",
                table: "Email");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyCall",
                table: "CompanyCall");

            migrationBuilder.RenameTable(
                name: "Phone",
                newName: "PhoneNumber");

            migrationBuilder.RenameTable(
                name: "Email",
                newName: "CustEmail");

            migrationBuilder.RenameTable(
                name: "CompanyCall",
                newName: "CompanyCalls");

            migrationBuilder.RenameIndex(
                name: "IX_Phone_CustomerID",
                table: "PhoneNumber",
                newName: "IX_PhoneNumber_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_Email_CustomerId",
                table: "CustEmail",
                newName: "IX_CustEmail_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCall_CustomerId",
                table: "CompanyCalls",
                newName: "IX_CompanyCalls_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhoneNumber",
                table: "PhoneNumber",
                column: "PhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustEmail",
                table: "CustEmail",
                column: "EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyCalls",
                table: "CompanyCalls",
                column: "CallId");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zip = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.AddressId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_AddressId",
                table: "CustomerAddress",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCalls_Customer_CustomerId",
                table: "CompanyCalls",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustEmail_Customer_CustomerId",
                table: "CustEmail",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAddress_Address_AddressId",
                table: "CustomerAddress",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PhoneNumber_Customer_CustomerID",
                table: "PhoneNumber",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompanyCalls_Customer_CustomerId",
                table: "CompanyCalls");

            migrationBuilder.DropForeignKey(
                name: "FK_CustEmail_Customer_CustomerId",
                table: "CustEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAddress_Address_AddressId",
                table: "CustomerAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PhoneNumber_Customer_CustomerID",
                table: "PhoneNumber");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAddress_AddressId",
                table: "CustomerAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhoneNumber",
                table: "PhoneNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustEmail",
                table: "CustEmail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyCalls",
                table: "CompanyCalls");

            migrationBuilder.RenameTable(
                name: "PhoneNumber",
                newName: "Phone");

            migrationBuilder.RenameTable(
                name: "CustEmail",
                newName: "Email");

            migrationBuilder.RenameTable(
                name: "CompanyCalls",
                newName: "CompanyCall");

            migrationBuilder.RenameIndex(
                name: "IX_PhoneNumber_CustomerID",
                table: "Phone",
                newName: "IX_Phone_CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_CustEmail_CustomerId",
                table: "Email",
                newName: "IX_Email_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyCalls_CustomerId",
                table: "CompanyCall",
                newName: "IX_CompanyCall_CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phone",
                table: "Phone",
                column: "PhoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Email",
                table: "Email",
                column: "EmailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyCall",
                table: "CompanyCall",
                column: "CallId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompanyCall_Customer_CustomerId",
                table: "CompanyCall",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Email_Customer_CustomerId",
                table: "Email",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_Customer_CustomerID",
                table: "Phone",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
