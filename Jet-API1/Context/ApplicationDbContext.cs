﻿using Jet_API1.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace Jet_API1.Context
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddControllers().AddJsonOptions(options =>
        //    {
        //        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
        //    });
        //}
        public DbSet<City> City { get; set; }
        public DbSet<Place> Places { get; set; }
    }
}