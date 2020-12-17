using Core.Entities;
using Core.Enumerations;
using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public static class SeedData
    {
        private const string DEFAULT_PASSWORD = "abcd1234";
        public static async Task SeedIdentity(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (await userManager.FindByNameAsync("username1@gmail.com") == null)
            {
                var user1 = new ApplicationUser
                {
                    Id = "idseed1",
                    UserName = "username1@gmail.com",
                    Email = "username1@gmail.com",
                    PhoneNumber="0123456789",
                };
                await userManager.CreateAsync(user1, DEFAULT_PASSWORD);
            }
        }

        public static async Task SeedAppDb(ApplicationDbContext context)
        {
            if(!context.Products.Any())
            {
                context.Products.AddRange(new List<Product>
                {
                    new Product
                    {
                        Id = "THIETBI-1",
                        Name="Chuột Có Dây Logitech B100 - Hàng Chính Hãng",
                        Price=100000,
                        Description="Description 1",
                        Producer="Logitech",
                        Quantity=50,
                        Type=ProductType.Mouse,
                        Storages=new List<Storage>
                        {
                            new Storage
                            {
                                Quantity=50,
                            }
                        }
                    },
                    new Product
                    {
                        Id = "THIETBI-2",
                        Name="Bàn Phím Có Dây Dell KB216 - Đen - Hàng Chính Hãng",
                        Price=200000,
                        Quantity=30,
                        Description="Description 2",
                        Producer="Logitech",
                        Type=ProductType.Keyboard,
                        Storages=new List<Storage>
                        {
                            new Storage
                            {
                                Quantity=30,
                            }
                        }
                    },
                });
                await context.SaveChangesAsync();
            }    
            if(!context.Combos.Any())
            {
                context.Combos.AddRange(new List<Combo>
                {
                    new Combo
                    {
                        Id = "COMBO-1",
                        Name="Combo chuột và bán phím",
                        Price=250000,
                        ComboDetails = new List<ComboDetail>
                        {
                            new ComboDetail
                            {
                                ProductId="THIETBI-1",
                                Quantity=1,
                            },
                            new ComboDetail
                            {
                                ProductId="THIETBI-2",
                                Quantity=1,
                            },
                        }
                    },
                });
                await context.SaveChangesAsync();
            }    
            if(!context.Customers.Any())
            {
                context.Customers.Add(new Customer
                {
                    UserId= "idseed1",
                    FullName="Nguyen Van A",
                    Address="Dia chi trai dat",
                });
                await context.SaveChangesAsync();
            }    
        }
    }
}
