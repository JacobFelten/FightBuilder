using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using FightBuilder.Models;

namespace FightBuilder.Repositories
{
    public static class SeedData
    {
        public static void Seed(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Equipment.Any())
            {
                Equipment e = Logic.blankEquipment;
                context.Equipment.Add(e);
                Logic.blankEquipment = e;
                context.SaveChanges();
            }
            else
            {
                Logic.blankEquipment = context.Equipment.First(e => e.EquipmentID == 1);
            }
        }
    }
}
