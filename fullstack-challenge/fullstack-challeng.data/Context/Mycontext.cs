using fullstack_challenge.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Xml;
using System.IO;
using Microsoft.Extensions.Configuration.Json;

namespace fullstack_challeng.data.Context
{
    public class Mycontext : DbContext
    {

        public DbSet<Classified> Classifieds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory()) // <== compile failing here
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }
    }

}
