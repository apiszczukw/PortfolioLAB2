﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PortfolioLAB2.DAL;

#nullable disable

namespace PortfolioLAB2.Migrations
{
    [DbContext(typeof(ProjectsContext))]
    [Migration("20250527140100_Dane")]
    partial class Dane
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PortfolioLAB2.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSrc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 10,
                            Description = "Personal portfolio using HTML, CSS, and JS.",
                            ImageSrc = "https://images.unsplash.com/photo-1581090700227-1c9730b46ec6",
                            Name = "Portfolio Website",
                            Tags = "HTML,CSS,JavaScript"
                        },
                        new
                        {
                            Id = 11,
                            Description = "A simple weather forecast app using API.",
                            ImageSrc = "https://images.pexels.com/photos/212240/pexels-photo-212240.jpeg",
                            Name = "Weather App",
                            Tags = "JavaScript,API,HTML,CSS"
                        },
                        new
                        {
                            Id = 12,
                            Description = "To-do list application with local storage.",
                            ImageSrc = "https://images.unsplash.com/photo-1554774853-b414d4b8040b",
                            Name = "Task Manager",
                            Tags = "JavaScript,HTML,CSS"
                        },
                        new
                        {
                            Id = 13,
                            Description = "A simple blogging platform built in ASP.NET.",
                            ImageSrc = "https://images.pexels.com/photos/261579/pexels-photo-261579.jpeg",
                            Name = "Blog Platform",
                            Tags = "ASP.NET,C#,HTML,CSS"
                        },
                        new
                        {
                            Id = 14,
                            Description = "Online store frontend with product catalog.",
                            ImageSrc = "https://images.unsplash.com/photo-1589187155475-9d4a39e0dd22",
                            Name = "E-commerce Store",
                            Tags = "HTML,CSS,JavaScript"
                        },
                        new
                        {
                            Id = 15,
                            Description = "Real-time chat application using SignalR.",
                            ImageSrc = "https://images.pexels.com/photos/1181244/pexels-photo-1181244.jpeg",
                            Name = "Chat App",
                            Tags = "SignalR,C#,JavaScript"
                        },
                        new
                        {
                            Id = 16,
                            Description = "Web app to store and search recipes.",
                            ImageSrc = "https://images.unsplash.com/photo-1504674900247-0877df9cc836",
                            Name = "Recipe Book",
                            Tags = "HTML,CSS,JavaScript"
                        },
                        new
                        {
                            Id = 17,
                            Description = "Track your personal expenses easily.",
                            ImageSrc = "https://images.pexels.com/photos/4386375/pexels-photo-4386375.jpeg",
                            Name = "Expense Tracker",
                            Tags = "JavaScript,HTML,CSS"
                        },
                        new
                        {
                            Id = 18,
                            Description = "Responsive photo gallery with lightbox.",
                            ImageSrc = "https://images.unsplash.com/photo-1518779578993-ec3579fee39f",
                            Name = "Photo Gallery",
                            Tags = "HTML,CSS,JavaScript"
                        },
                        new
                        {
                            Id = 19,
                            Description = "Editor that converts markdown to HTML.",
                            ImageSrc = "https://images.pexels.com/photos/574071/pexels-photo-574071.jpeg",
                            Name = "Markdown Editor",
                            Tags = "JavaScript,Markdown,HTML,CSS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
