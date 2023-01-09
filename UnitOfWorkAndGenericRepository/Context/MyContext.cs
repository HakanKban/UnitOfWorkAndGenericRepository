using Microsoft.EntityFrameworkCore;
using System;
using UnitOfWorkAndGenericRepository.Entity;

namespace UnitOfWorkAndGenericRepository.Context
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }
        DbSet<Product> Products { get; set; }
        DbSet<Category> Categories { get; set; }
    }
}
