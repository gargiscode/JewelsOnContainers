using Microsoft.EntityFrameworkCore;
using ProductCatalogAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalogAPI.Data
{
    public static class CatalogSeed
    {
        public static void Seed(CatalogContext cc)
        {
            cc.Database.Migrate();
            if (!cc.CatalogBrands.Any())
            {
                cc.CatalogBrands.AddRange(GetCatalogBrands());
                cc.SaveChanges();
            }
            if(!cc.CatalogTypes.Any())
            {
                cc.CatalogTypes.AddRange(GetCatalogTypes());
                cc.SaveChanges();
            }
            if (!cc.Catalog.Any())
            {
                cc.Catalog.AddRange(GetCatalogItems());
                cc.SaveChanges();
            }

        }
 
        private static IEnumerable<CatalogItem> GetCatalogItems()
        {
            return new List<CatalogItem>()
            {
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 3, Description = "A ring that has been around for over 100 years", Name = "World Star", Cost = 199.5M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/1" },
                new CatalogItem { CatalogTypeId = 1, CatalogBrandId = 2, Description = "will make you world champions", Name = "White Line", Cost = 88.50M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/2" },
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 3, Description = "You have already won gold medal", Name = "Prism White", Cost = 129, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/3" },
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 2, Description = "Olympic runner", Name = "Foundation Hitech", Cost = 12, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/4" },
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 1, Description = "Roslyn Red Sheet", Name = "Roslyn White", Cost = 188.5M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/5" },
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 2, Description = "Lala Land", Name = "Blue Star", Cost = 112, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/6" },
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 1, Description = "High in the sky", Name = "Roslyn Green", Cost = 212, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/7" },
                new CatalogItem { CatalogTypeId = 1, CatalogBrandId = 1, Description = "Light as carbon", Name = "Deep Purple", Cost = 238.5M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/8" },
                new CatalogItem { CatalogTypeId = 1, CatalogBrandId = 2, Description = "High Jumper", Name = "Antique Ring", Cost = 129, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/9" },
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 3, Description = "Dunker", Name = "Elequent", Cost = 12, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/10" },
                new CatalogItem { CatalogTypeId = 1, CatalogBrandId = 2, Description = "All round", Name = "Inredeible", Cost = 248.5M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/11" },
                new CatalogItem { CatalogTypeId = 2, CatalogBrandId = 1, Description = "Priceless", Name = "London Sky", Cost = 412, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/12" },
                new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 3, Description = "You ar ethe star", Name = "Elequent", Cost = 123, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/13" },
                new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 2, Description = "A ring popular in the 16th and 17th century in Western Europe that was used as an engagement wedding ring", Name = "London Star", Cost = 218.5M, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/14" },
                new CatalogItem { CatalogTypeId = 3, CatalogBrandId = 1, Description = "A floppy, bendable ring made out of links of metal", Name = "Paris Blues", Cost = 312, PictureUrl = "http://externalcatalogbaseurltobereplaced/api/pic/15" }
            };
        }

        private static IEnumerable<CatalogType> GetCatalogTypes()
        {
            return new List<CatalogType>
            {
                new CatalogType
                {
                    TypeName = "Engagement Ring"
                },
                new CatalogType
                {
                    TypeName = "Wedding Ring"
                },
                new CatalogType
                {
                    TypeName="Fashion Ring"
                }
            };
        }
        private static IEnumerable<CatalogBrand> GetCatalogBrands()
        {
            return new List<CatalogBrand>
            {
                new CatalogBrand
                {
                    BrandName = "Tiffany & Co."
                },
                new CatalogBrand
                {
                    BrandName = "DeBeers"
                },
                new CatalogBrand
                {
                    BrandName = "Graff"
                }
            };
        }
    }
}
