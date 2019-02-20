using System;
using Microsoft.EntityFrameworkCore;
using TODO.API.Model;

namespace TODO.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options){

        }

        public DbSet <Item> TODOS {get;set;}


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Description = "First thing to do",
                    Date = "2020-09-09"
   
                },
                new Item
                {
                    Id = 2,
                    Description = "Second thing to do",
                    Date = "2021-09-19"
                }
            );
        }


    }
}