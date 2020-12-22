using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Woorj.Migrations
{
    public partial class Init_00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateSequence<int>(
                name: "ApplicationRoleCode",
                startValue: 1000L);

            migrationBuilder.CreateSequence<int>(
                name: "ApplicationUserCode",
                startValue: 1000L);

            migrationBuilder.CreateSequence<int>(
                name: "ContactCode",
                startValue: 1000L);

            migrationBuilder.CreateSequence<int>(
                name: "CountryCode",
                startValue: 1000L);

            migrationBuilder.CreateSequence<int>(
                name: "GenderCode",
                startValue: 1000L);

            migrationBuilder.CreateSequence<int>(
                name: "IndividualCode",
                startValue: 1000L);

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Code = table.Column<int>(nullable: true, defaultValueSql: "NEXT VALUE FOR ApplicationRoleCode"),
                    Description = table.Column<string>(maxLength: 512, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Code = table.Column<int>(nullable: true, defaultValueSql: "NEXT VALUE FOR ApplicationUserCode"),
                    FirstName = table.Column<string>(maxLength: 32, nullable: true),
                    SecondName = table.Column<string>(maxLength: 32, nullable: true),
                    LastName = table.Column<string>(maxLength: 32, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Department = table.Column<string>(nullable: true),
                    EmploymentDate = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false, defaultValueSql: "NEXT VALUE FOR GenderCode"),
                    Name = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tmp1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F1 = table.Column<string>(nullable: true),
                    F2 = table.Column<string>(nullable: true),
                    F3 = table.Column<string>(nullable: true),
                    F4 = table.Column<string>(nullable: true),
                    F5 = table.Column<string>(nullable: true),
                    F6 = table.Column<string>(nullable: true),
                    F7 = table.Column<string>(nullable: true),
                    F8 = table.Column<string>(nullable: true),
                    F9 = table.Column<string>(nullable: true),
                    F10 = table.Column<string>(nullable: true),
                    F11 = table.Column<string>(nullable: true),
                    F12 = table.Column<string>(nullable: true),
                    F13 = table.Column<string>(nullable: true),
                    F14 = table.Column<string>(nullable: true),
                    F15 = table.Column<string>(nullable: true),
                    F16 = table.Column<string>(nullable: true),
                    F17 = table.Column<string>(nullable: true),
                    F18 = table.Column<string>(nullable: true),
                    F19 = table.Column<string>(nullable: true),
                    F20 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tmp1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tmp2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F1 = table.Column<string>(nullable: true),
                    F2 = table.Column<string>(nullable: true),
                    F3 = table.Column<string>(nullable: true),
                    F4 = table.Column<string>(nullable: true),
                    F5 = table.Column<string>(nullable: true),
                    F6 = table.Column<string>(nullable: true),
                    F7 = table.Column<string>(nullable: true),
                    F8 = table.Column<string>(nullable: true),
                    F9 = table.Column<string>(nullable: true),
                    F10 = table.Column<string>(nullable: true),
                    F11 = table.Column<string>(nullable: true),
                    F12 = table.Column<string>(nullable: true),
                    F13 = table.Column<string>(nullable: true),
                    F14 = table.Column<string>(nullable: true),
                    F15 = table.Column<string>(nullable: true),
                    F16 = table.Column<string>(nullable: true),
                    F17 = table.Column<string>(nullable: true),
                    F18 = table.Column<string>(nullable: true),
                    F19 = table.Column<string>(nullable: true),
                    F20 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tmp2", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tmp3",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    F1 = table.Column<string>(nullable: true),
                    F2 = table.Column<string>(nullable: true),
                    F3 = table.Column<string>(nullable: true),
                    F4 = table.Column<string>(nullable: true),
                    F5 = table.Column<string>(nullable: true),
                    F6 = table.Column<string>(nullable: true),
                    F7 = table.Column<string>(nullable: true),
                    F8 = table.Column<string>(nullable: true),
                    F9 = table.Column<string>(nullable: true),
                    F10 = table.Column<string>(nullable: true),
                    F11 = table.Column<string>(nullable: true),
                    F12 = table.Column<string>(nullable: true),
                    F13 = table.Column<string>(nullable: true),
                    F14 = table.Column<string>(nullable: true),
                    F15 = table.Column<string>(nullable: true),
                    F16 = table.Column<string>(nullable: true),
                    F17 = table.Column<string>(nullable: true),
                    F18 = table.Column<string>(nullable: true),
                    F19 = table.Column<string>(nullable: true),
                    F20 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tmp3", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false, defaultValueSql: "NEXT VALUE FOR CountryCode"),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    FullName = table.Column<string>(maxLength: 256, nullable: false),
                    English = table.Column<string>(maxLength: 256, nullable: false),
                    Alpha2 = table.Column<string>(maxLength: 2, nullable: false),
                    Alpha3 = table.Column<string>(maxLength: 3, nullable: false),
                    Iso = table.Column<string>(maxLength: 3, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Individual",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false, defaultValueSql: "NEXT VALUE FOR IndividualCode"),
                    FirstName = table.Column<string>(maxLength: 128, nullable: false),
                    SecondName = table.Column<string>(maxLength: 128, nullable: true),
                    LastName = table.Column<string>(maxLength: 128, nullable: true),
                    FirstNameEN = table.Column<string>(maxLength: 128, nullable: true),
                    SecondNameEN = table.Column<string>(maxLength: 128, nullable: true),
                    LastNameEN = table.Column<string>(maxLength: 128, nullable: true),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    TaxCode = table.Column<string>(maxLength: 256, nullable: true),
                    PassSerial = table.Column<string>(maxLength: 5, nullable: true),
                    PassCode = table.Column<string>(maxLength: 128, nullable: true),
                    DocDate = table.Column<DateTime>(nullable: true),
                    DocDateEnd = table.Column<DateTime>(nullable: true),
                    PassOrg = table.Column<string>(maxLength: 128, nullable: true),
                    Address = table.Column<string>(maxLength: 256, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValueSql: "getdate()"),
                    GenderId = table.Column<int>(nullable: true),
                    BirthPlace_CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individual", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Individual_Country_BirthPlace_CountryId",
                        column: x => x.BirthPlace_CountryId,
                        principalSchema: "dbo",
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Individual_Gender_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Gender",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(nullable: false, defaultValueSql: "NEXT VALUE FOR ContactCode"),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    IndividualId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Individual_IndividualId",
                        column: x => x.IndividualId,
                        principalTable: "Individual",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_Code",
                table: "AspNetRoles",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoles_Name",
                table: "AspNetRoles",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Code",
                table: "AspNetUsers",
                column: "Code",
                unique: true,
                filter: "[Code] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FirstName",
                table: "AspNetUsers",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_LastName",
                table: "AspNetUsers",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SecondName",
                table: "AspNetUsers",
                column: "SecondName");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_Code",
                table: "Contact",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_IndividualId",
                table: "Contact",
                column: "IndividualId");

            migrationBuilder.CreateIndex(
                name: "IX_Gender_Code",
                table: "Gender",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Individual_BirthPlace_CountryId",
                table: "Individual",
                column: "BirthPlace_CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_Code",
                table: "Individual",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Individual_FirstName",
                table: "Individual",
                column: "FirstName");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_GenderId",
                table: "Individual",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_LastName",
                table: "Individual",
                column: "LastName");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_PassCode",
                table: "Individual",
                column: "PassCode");

            migrationBuilder.CreateIndex(
                name: "IX_Individual_SecondName",
                table: "Individual",
                column: "SecondName");

            migrationBuilder.CreateIndex(
                name: "IX_Country_Alpha2",
                schema: "dbo",
                table: "Country",
                column: "Alpha2",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_Alpha3",
                schema: "dbo",
                table: "Country",
                column: "Alpha3",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_Code",
                schema: "dbo",
                table: "Country",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_Iso",
                schema: "dbo",
                table: "Country",
                column: "Iso",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Country_Name",
                schema: "dbo",
                table: "Country",
                column: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Tmp1");

            migrationBuilder.DropTable(
                name: "Tmp2");

            migrationBuilder.DropTable(
                name: "Tmp3");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Individual");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropSequence(
                name: "ApplicationRoleCode");

            migrationBuilder.DropSequence(
                name: "ApplicationUserCode");

            migrationBuilder.DropSequence(
                name: "ContactCode");

            migrationBuilder.DropSequence(
                name: "CountryCode");

            migrationBuilder.DropSequence(
                name: "GenderCode");

            migrationBuilder.DropSequence(
                name: "IndividualCode");
        }
    }
}
