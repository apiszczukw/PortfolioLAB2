using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioLAB2.Migrations
{
    public partial class Dane : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "ImageSrc", "Name", "Tags" },
                values: new object[,]
                {
                    { 10, "Personal portfolio using HTML, CSS, and JS.", "https://images.unsplash.com/photo-1581090700227-1c9730b46ec6", "Portfolio Website", "HTML,CSS,JavaScript" },
                    { 11, "A simple weather forecast app using API.", "https://images.pexels.com/photos/212240/pexels-photo-212240.jpeg", "Weather App", "JavaScript,API,HTML,CSS" },
                    { 12, "To-do list application with local storage.", "https://images.unsplash.com/photo-1554774853-b414d4b8040b", "Task Manager", "JavaScript,HTML,CSS" },
                    { 13, "A simple blogging platform built in ASP.NET.", "https://images.pexels.com/photos/261579/pexels-photo-261579.jpeg", "Blog Platform", "ASP.NET,C#,HTML,CSS" },
                    { 14, "Online store frontend with product catalog.", "https://images.unsplash.com/photo-1589187155475-9d4a39e0dd22", "E-commerce Store", "HTML,CSS,JavaScript" },
                    { 15, "Real-time chat application using SignalR.", "https://images.pexels.com/photos/1181244/pexels-photo-1181244.jpeg", "Chat App", "SignalR,C#,JavaScript" },
                    { 16, "Web app to store and search recipes.", "https://images.unsplash.com/photo-1504674900247-0877df9cc836", "Recipe Book", "HTML,CSS,JavaScript" },
                    { 17, "Track your personal expenses easily.", "https://images.pexels.com/photos/4386375/pexels-photo-4386375.jpeg", "Expense Tracker", "JavaScript,HTML,CSS" },
                    { 18, "Responsive photo gallery with lightbox.", "https://images.unsplash.com/photo-1518779578993-ec3579fee39f", "Photo Gallery", "HTML,CSS,JavaScript" },
                    { 19, "Editor that converts markdown to HTML.", "https://images.pexels.com/photos/574071/pexels-photo-574071.jpeg", "Markdown Editor", "JavaScript,Markdown,HTML,CSS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
