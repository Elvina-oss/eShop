using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShop.Models;
namespace eShop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)

        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if(!context.Brands.Any())
                {
                    context.Brands.AddRange(new List<Brand>()
                    {
                        new Brand()
                        {
                            BrandPictureURL = "https://diskontsp.ru/wa-data/public/shop/brands/16550/16550.jpg",
                            BrandName = "Chanel",
                            Description = "Ароматы CHANEL сопровождают жизнь смелой, сияющей женщины в постоянном движении. Каждый женский аромат CHANEL вдохновлен вселенной Великой мадемуазель и раскрывает новую грань женской парфюмерии, создавая для каждой ее собственный ольфакторный мир. Звучание ароматов продолжается в полной гамме продуктов для ванны и тела."

                },
                        new Brand()
                        {
                            BrandPictureURL = "https://lavego.ru/uploads/catalog/dolce-gabbana-1/th_Dolce_Gabbana_Logo.jpg",
                            BrandName = "Dolce & Gabbana",
                            Description = "Творения Dolce&Gabbana удивляют, шокируют, поражают, вдохновляют и восхищают! В ольфакторных пирамидах, как правило, присутствуют классические цветочно-фруктовые акценты, а также необычные и пикантные нюансы (например, дикие пряности или экзотические островные плоды)."
                        },
                        new Brand()
                        {
                            BrandPictureURL = "https://make4make.ru/image/catalog/brand_logo/dg-logo.jpg",
                            BrandName = "Gucci",
                            Description = "Итальянская фирма, производящая самые страстные и чувственные ароматы. Парфюмерная команда представлена подлинными мастерами своего дела, всегда стремящимися к созданию чего-то уникального и самобытного. Новинки выпускаются ежегодно, что особенно радует поклонников лейбла."
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(new List<Category>()
                    {
                        new Category()
                        {
                            CategoryName = "Для женщин"
                        },
                        new Category()
                        {
                            CategoryName = "Для мужчин"
                        },
                        new Category()
                        {
                            CategoryName = "Унисекс"
                        },
                        new Category()
                        {
                            CategoryName = "Новинки"
                        },
                        new Category()
                        {
                            CategoryName = "Популярное"
                        }
                    });
                    context.SaveChanges();
                }
                if (!context.Perfumes.Any())
                {
                    context.Perfumes.AddRange(new List<Perfume>()
                    {
                        new Perfume()
                        {
                            PerfumePictureURL = "https://cdn.spellsmell.ru/o/7bc9a9ea-c359-4745-a1f8-3dc7ebb04a17.webp",
                            PerfumeName = "Женские духи Cacharel Amor Amor",
                            ReleaseYear = 2020,
                            Description = "Верхние ноты аромата представлены грейпфрутом, черной смородиной, мандарином и кассией. В сердце аромата раскрываются аккорды абрикоса, лилии, ландыша и розы. Вся парфюмерная композиция построена на базе кедра, мускуса, амбры, бобов тонка и ванили.  Ярко-красный флакончик парфюма символизирует яркие эмоции и страсть, а также хорошее настроение и радость от каждого дня. Флакон декорирован задорными сердечками.",
                            Price = 4090,
                            BrandId = 1
                        },
                        new Perfume()
                        {
                            PerfumePictureURL = "https://cdn.spellsmell.ru/o/7bc9a9ea-c359-4745-a1f8-3dc7ebb04a17.webp",
                            PerfumeName = "Женские духи Cacharel Amor Amor",
                            ReleaseYear = 2020,
                            Description = "Верхние ноты аромата представлены грейпфрутом, черной смородиной, мандарином и кассией. В сердце аромата раскрываются аккорды абрикоса, лилии, ландыша и розы. Вся парфюмерная композиция построена на базе кедра, мускуса, амбры, бобов тонка и ванили.  Ярко-красный флакончик парфюма символизирует яркие эмоции и страсть, а также хорошее настроение и радость от каждого дня. Флакон декорирован задорными сердечками.",
                            Price = 4090,
                            BrandId = 1
                        }
                    });
               
                    context.SaveChanges();
                }
                if (!context.Category_Perfumes.Any())
                {
                    //тут что то не работает
                    //context.Category_Perfumes.AddRange(new List<Category_Perfume>()
                    //{
                    //    new Category_Perfume()
                    //    {
                    //        PerfumeId = 1,
                    //        CategoryId = 1
                    //    }
                    //});
                    context.SaveChanges();
                }

            }
        }
    }
}
