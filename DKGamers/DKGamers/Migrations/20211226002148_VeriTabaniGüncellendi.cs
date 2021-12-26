using Microsoft.EntityFrameworkCore.Migrations;

namespace DKGamers.Migrations
{
    public partial class VeriTabaniGüncellendi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e117364-e21d-5613-a6d7-9413e041cdb9", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e217364-e21d-5613-a6d7-9413e041cdb9", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e317364-e21d-5613-a6d7-9413e041cdb9", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e117364-e21d-5613-a6d7-9413e041cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e217364-e21d-5613-a6d7-9413e041cdb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e317364-e21d-5613-a6d7-9413e041cdb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "489db2cc-e945-4df9-9572-08c8271f5fcd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "01f88459-0a99-486f-bb3d-efeddd09f433");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e117364-e21d-4613-a6d7-9423e041cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fe1f3b69-6555-42b0-8667-fce88ccddb6c", "g191210094@sakarya.edu.tr", "G191210094@SAKARYA.EDU.TR", "G191210094@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEMoQHmwuR7qWP/81uK7ZZ1yruc8D27SaZmE4B5BGc2rGdWMoBuJSpW6OGdDrfBdO/g==", "e5dd6c48-201a-4e9e-b054-cbf9ee652f62", "g191210094@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e117364-e21d-4713-a6d7-9423d041edb9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "91270e1d-8b93-4903-b458-859bf03970c3", "bayiremir2@gmail.com", "BAYİREMİR2@GMAİL.COM", "BAYİREMİR2@GMAİL.COM", "AQAAAAEAACcQAAAAEMWK2g1M1CsjuArQo+V/WAsoGTvKwAEOa2zezIpzDhjgoW3QyhQg4kQMjazM+7lsdg==", "923a864e-3b88-48d4-9f5c-bb2c39ffe612", "emir24" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "74b093fb-ee7c-45a0-91e7-962b9fe86656");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "80a65347-4a6e-4703-a9d2-baef8a137b60");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e117364-e21d-4613-a6d7-9423e041cdb9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "54bb3558-31f9-4975-b656-534dee245cca", "b181210057@sakarya.edu.tr", "B181210057@SAKARYA.EDU.TR", "B181210057@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAENi3uklsXLw+2ndNW8cqo+PeDED7DriN9GEtg4vAB9Z+JSZRDx+zzy5n4OV4hcim3A==", "6ca6d02d-c943-4f37-a532-ba61a7b309c6", "b181210057@sakarya.edu.tr" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e117364-e21d-4713-a6d7-9423d041edb9",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "66cf4266-3c89-456e-af80-6a43ccd12ea0", "b181210051@sakarya.edu.tr", "B181210051@SAKARYA.EDU.TR", "B181210051@SAKARYA.EDU.TR", "AQAAAAEAACcQAAAAEM2OB3RLcIzRJ6x6pqSZNjnP6mJcghFosb/IBPd5zrH099ogMq4ltPLWkLsvwYPXyQ==", "bcd7d032-8c9d-493e-9691-888cbf4ea8d1", "b181210051@sakarya.edu.tr" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e117364-e21d-5613-a6d7-9413e041cdb9", 0, "fc7876bc-4f30-4a7b-a6bf-0378da767667", "bayram@outlook.com", true, false, null, "BAYRAM@OUTLOOK.COM", "BAYRAM57", "AQAAAAEAACcQAAAAELkxaEUNoKznB63MC0T06YfS/9guVH6KpXL8Epre+EOJXwLAMn6tdcSHNAF263N5KA==", null, false, "6fe8b204-23f1-486a-952c-18db006c2cfb", false, "bayram57" },
                    { "8e217364-e21d-5613-a6d7-9413e041cdb9", 0, "5887d29c-8fda-4914-b472-923ccafdc8e8", "batuhan34@outlook.com", true, false, null, "BATUHAN34@OUTLOOK.COM", "BATUHAN34", "AQAAAAEAACcQAAAAEBMwI6ZQ1NNZ2TZvqXqSIeWxC6ZNHUe65+hCCoGTeH/fvlsi2ZfRfSb80MRGCwdIBA==", null, false, "1fb3e6ef-d28a-4f21-b352-1e0143928a0a", false, "batuhan34" },
                    { "8e317364-e21d-5613-a6d7-9413e041cdb9", 0, "9e5fc502-894b-4c03-b837-7c0eeb897337", "berk77@outlook.com", true, false, null, "BERK77@OUTLOOK.COM", "BERK77", "AQAAAAEAACcQAAAAEKubhPYY28YrDpBDMADc2RcqE/xfAP8kFPC0bSA0usCykRTO62a36NnHITko7HsOQw==", null, false, "c44d5e53-aac6-493f-85b9-e5e87a90a6eb", false, "berk77" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8e117364-e21d-5613-a6d7-9413e041cdb9", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8e217364-e21d-5613-a6d7-9413e041cdb9", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8e317364-e21d-5613-a6d7-9413e041cdb9", "2" });
        }
    }
}
