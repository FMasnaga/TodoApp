﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TODO.API.Data;

namespace TODO.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("TODO.API.Model.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Date");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("TODOS");

                    b.HasData(
                        new { Id = 1, Date = "2020-09-09", Description = "First thing to do" },
                        new { Id = 2, Date = "2021-09-19", Description = "Second thing to do" }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
