using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Durur.Modules.Generic.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Country_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ISO_Code = table.Column<string>(type: "char(2)", nullable: false),
                    Country_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone_Code = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Country_ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee_CompanyPositions",
                columns: table => new
                {
                    Department_ID = table.Column<int>(type: "int", nullable: false),
                    Position_ID = table.Column<int>(type: "int", nullable: false),
                    Employee_ID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_CompanyPositions", x => new { x.Department_ID, x.Position_ID, x.Employee_ID });
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Job_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Job_Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Job_ID);
                });

            migrationBuilder.CreateTable(
                name: "Order_Statuses",
                columns: table => new
                {
                    Order_Status_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Current_Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Statuses", x => x.Order_Status_ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "Customers",
                columns: table => new
                {
                    Customer_ID = table.Column<int>(type: "int", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Primary_Phone_Number = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Secondary_Phone_Number = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customer_ID);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Location_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Location_ID);
                    table.ForeignKey(
                        name: "FK_Locations_Countries_Country_ID",
                        column: x => x.Country_ID,
                        principalTable: "Countries",
                        principalColumn: "Country_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompanyPositions",
                columns: table => new
                {
                    Company_Position_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Position_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Company_Position_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeCompanyPositionDepartment_ID = table.Column<int>(type: "int", nullable: true),
                    EmployeeCompanyPositionPosition_ID = table.Column<int>(type: "int", nullable: true),
                    EmployeeCompanyPositionEmployee_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyPositions", x => x.Company_Position_ID);
                    table.ForeignKey(
                        name: "FK_CompanyPositions_Employee_CompanyPositions_EmployeeCompanyPositionDepartment_ID_EmployeeCompanyPositionPosition_ID_EmployeeC~",
                        columns: x => new { x.EmployeeCompanyPositionDepartment_ID, x.EmployeeCompanyPositionPosition_ID, x.EmployeeCompanyPositionEmployee_ID },
                        principalTable: "Employee_CompanyPositions",
                        principalColumns: new[] { "Department_ID", "Position_ID", "Employee_ID" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Employee_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EMail = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Phone_Number = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Hire_Date = table.Column<DateTime>(type: "date", nullable: false),
                    Salary = table.Column<decimal>(type: "money", nullable: false),
                    EmployeeMasterEmployee_ID = table.Column<int>(type: "int", nullable: true),
                    Job_ID = table.Column<int>(type: "int", nullable: true),
                    PositionDepartment_ID = table.Column<int>(type: "int", nullable: true),
                    Position_ID = table.Column<int>(type: "int", nullable: true),
                    PositionEmployee_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Employee_ID);
                    table.ForeignKey(
                        name: "FK_Employees_Employee_CompanyPositions_PositionDepartment_ID_Position_ID_PositionEmployee_ID",
                        columns: x => new { x.PositionDepartment_ID, x.Position_ID, x.PositionEmployee_ID },
                        principalTable: "Employee_CompanyPositions",
                        principalColumns: new[] { "Department_ID", "Position_ID", "Employee_ID" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_EmployeeMasterEmployee_ID",
                        column: x => x.EmployeeMasterEmployee_ID,
                        principalTable: "Employees",
                        principalColumn: "Employee_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_Jobs_Job_ID",
                        column: x => x.Job_ID,
                        principalTable: "Jobs",
                        principalColumn: "Job_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customer_Addresses",
                columns: table => new
                {
                    CustomerAddress_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location_ID = table.Column<int>(type: "int", nullable: true),
                    Customer_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer_Addresses", x => x.CustomerAddress_ID);
                    table.ForeignKey(
                        name: "FK_Customer_Addresses_Customers_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customer_Addresses_Locations_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "Locations",
                        principalColumn: "Location_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Department_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department_Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Location_ID = table.Column<int>(type: "int", nullable: true),
                    EmployeePositionDepartment_ID = table.Column<int>(type: "int", nullable: true),
                    EmployeePositionPosition_ID = table.Column<int>(type: "int", nullable: true),
                    EmployeePositionEmployee_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Department_ID);
                    table.ForeignKey(
                        name: "FK_Departments_Employee_CompanyPositions_EmployeePositionDepartment_ID_EmployeePositionPosition_ID_EmployeePositionEmployee_ID",
                        columns: x => new { x.EmployeePositionDepartment_ID, x.EmployeePositionPosition_ID, x.EmployeePositionEmployee_ID },
                        principalTable: "Employee_CompanyPositions",
                        principalColumns: new[] { "Department_ID", "Position_ID", "Employee_ID" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_Locations_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "Locations",
                        principalColumn: "Location_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Supplier_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Supplier_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Location_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Supplier_ID);
                    table.ForeignKey(
                        name: "FK_Suppliers_Locations_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "Locations",
                        principalColumn: "Location_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    Warehouse_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Warehouse_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Location_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Warehouse_ID);
                    table.ForeignKey(
                        name: "FK_Warehouses_Locations_Location_ID",
                        column: x => x.Location_ID,
                        principalTable: "Locations",
                        principalColumn: "Location_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Order_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Total = table.Column<decimal>(type: "money", nullable: false),
                    Order_Status_ID = table.Column<int>(type: "int", nullable: true),
                    Customer_ID = table.Column<int>(type: "int", nullable: true),
                    Delivery_AddressCustomerAddress_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Order_ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customer_Addresses_Delivery_AddressCustomerAddress_ID",
                        column: x => x.Delivery_AddressCustomerAddress_ID,
                        principalTable: "Customer_Addresses",
                        principalColumn: "CustomerAddress_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_Customer_ID",
                        column: x => x.Customer_ID,
                        principalTable: "Customers",
                        principalColumn: "Customer_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Order_Statuses_Order_Status_ID",
                        column: x => x.Order_Status_ID,
                        principalTable: "Order_Statuses",
                        principalColumn: "Order_Status_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Product_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Product_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Warranty_Period = table.Column<int>(type: "int", nullable: false),
                    List_Price = table.Column<decimal>(type: "money", nullable: false),
                    Supplier_ID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Product_ID);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_Supplier_ID",
                        column: x => x.Supplier_ID,
                        principalTable: "Suppliers",
                        principalColumn: "Supplier_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Warehouse_ID = table.Column<int>(type: "int", nullable: false),
                    Product_ID = table.Column<int>(type: "int", nullable: false),
                    QuantityOnHand = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => new { x.Warehouse_ID, x.Product_ID });
                    table.ForeignKey(
                        name: "FK_Inventories_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inventories_Warehouses_Warehouse_ID",
                        column: x => x.Warehouse_ID,
                        principalTable: "Warehouses",
                        principalColumn: "Warehouse_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordered_Items",
                columns: table => new
                {
                    Ordered_Item_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Unit_Price = table.Column<decimal>(type: "money", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Order_ID = table.Column<int>(type: "int", nullable: true),
                    Product_ID = table.Column<int>(type: "int", nullable: true),
                    InventoryWarehouse_ID = table.Column<int>(type: "int", nullable: true),
                    InventoryProduct_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordered_Items", x => x.Ordered_Item_ID);
                    table.ForeignKey(
                        name: "FK_Ordered_Items_Inventories_InventoryWarehouse_ID_InventoryProduct_ID",
                        columns: x => new { x.InventoryWarehouse_ID, x.InventoryProduct_ID },
                        principalTable: "Inventories",
                        principalColumns: new[] { "Warehouse_ID", "Product_ID" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordered_Items_Orders_Order_ID",
                        column: x => x.Order_ID,
                        principalTable: "Orders",
                        principalColumn: "Order_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ordered_Items_Products_Product_ID",
                        column: x => x.Product_ID,
                        principalTable: "Products",
                        principalColumn: "Product_ID",
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
                name: "IX_CompanyPositions_EmployeeCompanyPositionDepartment_ID_EmployeeCompanyPositionPosition_ID_EmployeeCompanyPositionEmployee_ID",
                table: "CompanyPositions",
                columns: new[] { "EmployeeCompanyPositionDepartment_ID", "EmployeeCompanyPositionPosition_ID", "EmployeeCompanyPositionEmployee_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Addresses_Customer_ID",
                table: "Customer_Addresses",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Customer_Addresses_Location_ID",
                table: "Customer_Addresses",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeePositionDepartment_ID_EmployeePositionPosition_ID_EmployeePositionEmployee_ID",
                table: "Departments",
                columns: new[] { "EmployeePositionDepartment_ID", "EmployeePositionPosition_ID", "EmployeePositionEmployee_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Location_ID",
                table: "Departments",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeMasterEmployee_ID",
                table: "Employees",
                column: "EmployeeMasterEmployee_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Job_ID",
                table: "Employees",
                column: "Job_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionDepartment_ID_Position_ID_PositionEmployee_ID",
                table: "Employees",
                columns: new[] { "PositionDepartment_ID", "Position_ID", "PositionEmployee_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Product_ID",
                table: "Inventories",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_Country_ID",
                table: "Locations",
                column: "Country_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ordered_Items_InventoryWarehouse_ID_InventoryProduct_ID",
                table: "Ordered_Items",
                columns: new[] { "InventoryWarehouse_ID", "InventoryProduct_ID" });

            migrationBuilder.CreateIndex(
                name: "IX_Ordered_Items_Order_ID",
                table: "Ordered_Items",
                column: "Order_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Ordered_Items_Product_ID",
                table: "Ordered_Items",
                column: "Product_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Customer_ID",
                table: "Orders",
                column: "Customer_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Delivery_AddressCustomerAddress_ID",
                table: "Orders",
                column: "Delivery_AddressCustomerAddress_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_Order_Status_ID",
                table: "Orders",
                column: "Order_Status_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Supplier_ID",
                table: "Products",
                column: "Supplier_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Location_ID",
                table: "Suppliers",
                column: "Location_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_Location_ID",
                table: "Warehouses",
                column: "Location_ID");
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
                name: "CompanyPositions");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Ordered_Items");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Employee_CompanyPositions");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Customer_Addresses");

            migrationBuilder.DropTable(
                name: "Order_Statuses");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
