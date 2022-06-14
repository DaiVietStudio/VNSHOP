using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VNSHOP.Data.Migrations
{
    public partial class selectedmi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(name: "Selected", table: "DonViTinh_SanPham", nullable: false, defaultValue: false);
           
            //migrationBuilder.CreateTable(
            //    name: "DonViTinh_SanPham",
            //    columns: table => new
            //    {
            //        id = table.Column<long>(type: "bigint", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        DonViTinh = table.Column<long>(type: "bigint", nullable: true),
            //        SanPham = table.Column<long>(type: "bigint", nullable: true),
            //        GiaLe = table.Column<double>(type: "float", nullable: true),
            //        GiaSi = table.Column<double>(type: "float", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DonViTinh_SanPham", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_DonViTinh_SanPham_DonViTinh",
            //            column: x => x.DonViTinh,
            //            principalTable: "DonViTinh",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_DonViTinh_SanPham_SanPham1",
            //            column: x => x.SanPham,
            //            principalTable: "SanPham",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_DonViTinh_SanPham_DonViTinh",
            //    table: "DonViTinh_SanPham",
            //    column: "DonViTinh");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DonViTinh_SanPham_SanPham",
            //    table: "DonViTinh_SanPham",
            //    column: "SanPham");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
        }
    }
}
