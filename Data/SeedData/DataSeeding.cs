using Furni.Entities;
using Furni.Enums;
using Microsoft.AspNetCore.Antiforgery;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Furni.Data.SeedData
{
    public static class DataSeeding
    {
        public static void AddData(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product
                {
                    Id = Guid.Parse("80086632-658A-40B0-B152-A471A7A64DF0"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("B88C6C96-2E03-4100-A364-983A5A08149B"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("81CECEE6-B6A8-4BBA-A937-E88E40C228A6"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("E40EE004-DCCB-42BF-9AF0-CF52FF265C9B"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("DD2896CF-FCEF-45ED-8AE9-93A5D02C662D"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("46FD8E61-7670-4037-9EC4-A772F602B27B"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("20BB2DB5-43F9-45AE-B74D-541DF5D6E75A"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("E60070AA-0B4A-42D0-8F8D-0C84806DC10B"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                },
                new Product
                {
                    Id = Guid.Parse("E40F7CE6-DDFB-4484-8FD7-3A93C456D5BE"),
                    Name = "Nordic chair",
                    Description = $"The Nordic Chair blends minimalism with comfort, " +
                    $"inspired by Scandinavian design principles. " +
                    $"Crafted from durable oak wood and upholstered with soft linen fabric, " +
                    $"it provides both elegance and support. " +
                    $"Its clean lines, natural finish, " +
                    $"and ergonomic shape make it perfect for modern homes, cafes, " +
                    $"or offices seeking timeless, cozy sophistication.",
                    Price = 59M,
                }
            );

            #region Feature
            var feature = Feature.Instance;
            feature.Id = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4");
            feature.Title = "We Help You Make Modern Interior Design";
            feature.Description = "Donec facilisis quam ut purus rutrum lobortis. " +
                "Donec vitae odio quis nisl dapibus malesuada. " +
                "Nullam ac aliquet velit. Aliquam vulputate velit imperdiet dolor tempor tristique. " +
                "Pellentesque habitant morbi tristique senectus et netus et malesuada";

            builder.Entity<Feature>().HasData(feature);
            #endregion
            #region SliderImage
            var sliderImage = SliderImage.Instance;
            sliderImage.Id = Guid.Parse("4DE142FB-97F9-4A34-88A6-F3F6D32B17EB");
            sliderImage.Alt = "Modern Nordic Chair in minimal room";
            sliderImage.Url = "furni/images/sliders/images/couch.png";

            builder.Entity<SliderImage>().HasData(sliderImage);
            #endregion

            builder.Entity<Slider>().HasData(
                new Slider
                {
                    Id = Guid.Parse("C4F9293B-9370-44EA-A561-54609AACA790"),
                    Tittle = "About Us",
                    Description = "Donec vitae odio quis nisl dapibus malesuada. " +
                                  "Nullam ac aliquet velit. " +
                                  "Aliquam vulputate velit imperdiet dolor tempor tristique.",
                    Page = PageKey.About,
                    SliderImageId = Guid.Parse("4DE142FB-97F9-4A34-88A6-F3F6D32B17EB")
                },
                new Slider
                {
                    Id = Guid.Parse("534105D0-908F-47FA-A2C6-248F6D49FF7D"),
                    Tittle = "Contact",
                    Description = "Donec vitae odio quis nisl dapibus malesuada. " +
                                  "Nullam ac aliquet velit. " +
                                  "Aliquam vulputate velit imperdiet dolor tempor tristique.",
                    Page = PageKey.Contact,
                    SliderImageId = Guid.Parse("4DE142FB-97F9-4A34-88A6-F3F6D32B17EB")
                },
                new Slider
                {
                    Id = Guid.Parse("C9B2E447-AFB2-4609-A54F-2D8722557707"),
                    Tittle = "Modern Interior Design Studio",
                    Description = "Donec vitae odio quis nisl dapibus malesuada. " +
                                  "Nullam ac aliquet velit. " +
                                  "Aliquam vulputate velit imperdiet dolor tempor tristique.",
                    Page = PageKey.Home,
                    SliderImageId = Guid.Parse("4DE142FB-97F9-4A34-88A6-F3F6D32B17EB")
                },
                new Slider
                {
                    Id = Guid.Parse("4C093D51-7E4B-4788-907D-39337C610A84"),
                    Tittle = "Services",
                    Description = "Donec vitae odio quis nisl dapibus malesuada. " +
                                  "Nullam ac aliquet velit. " +
                                  "Aliquam vulputate velit imperdiet dolor tempor tristique.",
                    Page = PageKey.Service,
                    SliderImageId = Guid.Parse("4DE142FB-97F9-4A34-88A6-F3F6D32B17EB")
                }
            );

            builder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    Id = Guid.Parse("836ABEBE-B2F0-4A99-B035-C1CE0535D8D0"),
                    Name = "John",
                    Surname = "Smith",
                    Title = "Founder & CEO",
                    Description = "John leads the company with over 10 years of experience in furniture design and business strategy.",
                },
                new TeamMember
                {
                    Id = Guid.Parse("2D9EE73B-8E5E-4FDC-8B11-F8B2AC85D7B4"),
                    Name = "Sarah",
                    Surname = "Johnson",
                    Title = "Interior Designer",
                    Description = "Sarah specializes in creating modern and minimalist interior solutions that combine beauty and functionality.",
                },
                new TeamMember
                {
                    Id = Guid.Parse("2A36057B-6060-4C4C-A7CF-BEF3891DA8F1"),
                    Name = "Michael",
                    Surname = "Brown",
                    Title = "Marketing Director",
                    Description = "Michael manages the marketing strategy and ensures that Furni’s vision reaches customers worldwide.",
                },
                new TeamMember
                {
                    Id = Guid.Parse("ECF3EE48-C608-4C66-BE4A-D6AA586F50E9"),
                    Name = "Emma",
                    Surname = "Davis",
                    Title = "Customer Relations Manager",
                    Description = "Emma ensures a smooth and satisfying experience for every customer, from first contact to after-sales support.",
                }
            );

            builder.Entity<Image>().HasData(
            #region Product Images
                new Image
                {
                    Id = Guid.Parse("AFCDF3E8-83D8-496A-946E-B62B60584748"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-1.png",
                    RelatedEntityId = Guid.Parse("80086632-658A-40B0-B152-A471A7A64DF0"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
                new Image
                {
                    Id =Guid.Parse("2EB129B8-2521-4B56-B734-888E31F5DBB8"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-2.png",
                    RelatedEntityId = Guid.Parse("B88C6C96-2E03-4100-A364-983A5A08149B"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
                new Image
                {
                    Id = Guid.Parse("E8691E2F-3A21-4127-BBC7-FDC4BEB70DE4"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-3.png",
                    RelatedEntityId = Guid.Parse("81CECEE6-B6A8-4BBA-A937-E88E40C228A6"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
                new Image
                {
                    Id = Guid.Parse("BE25A131-F8AB-4157-A243-AD12EBE9020E"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-4.png",
                    RelatedEntityId = Guid.Parse("E40EE004-DCCB-42BF-9AF0-CF52FF265C9B"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
                new Image
                {
                    Id = Guid.Parse("E3CD5177-1B74-43D4-B911-14DE2C740371"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-1.png",
                    RelatedEntityId = Guid.Parse("DD2896CF-FCEF-45ED-8AE9-93A5D02C662D"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
                new Image
                {
                    Id = Guid.Parse("82E63A5E-7D60-460B-8298-A2867A24175B"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-2.png",
                    RelatedEntityId = Guid.Parse("46FD8E61-7670-4037-9EC4-A772F602B27B"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
                new Image
                {
                    Id = Guid.Parse("4042B3BE-3DAD-4F49-9DF8-F0EF3EA8C450"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-3.png",
                    RelatedEntityId = Guid.Parse("20BB2DB5-43F9-45AE-B74D-541DF5D6E75A"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
                new Image
                {
                    Id = Guid.Parse("5A9FE4D0-D610-4D10-AB0E-7963C160FF93"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/product/product-4.png",
                    RelatedEntityId = Guid.Parse("E40F7CE6-DDFB-4484-8FD7-3A93C456D5BE"),
                    RelatedEntityType = "Product",
                    ImageType = ImageType.Product
                },
            #endregion
            #region Feature Images
                new Image
                {
                    Id = Guid.Parse("EFD2CE03-B209-4BBF-8751-7BAC09C53AC4"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/features/img-grid-1.jpg",
                    RelatedEntityId = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4"),
                    RelatedEntityType = "Feature",
                    ImageType = ImageType.Feature
                },
                new Image
                {
                    Id = Guid.Parse("2710058D-7AA2-42D5-9DE3-54D4A197D679"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/features/img-grid-2.jpg",
                    RelatedEntityId = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4"),
                    RelatedEntityType = "Feature",
                    ImageType = ImageType.Feature
                },
                new Image
                {
                    Id = Guid.Parse("7CA74E81-A0B7-40DF-9773-D9EBA4541244"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/features/img-grid-3.jpg",
                    RelatedEntityId = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4"),
                    RelatedEntityType = "Feature",
                    ImageType = ImageType.Feature
                },
            #endregion
            #region TeamMember Images
                new Image
                {
                    Id = Guid.Parse("178145D8-237D-44C5-9AD1-A7AC37D0856A"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/team_member/person_1.jpg",
                    RelatedEntityId = Guid.Parse("836ABEBE-B2F0-4A99-B035-C1CE0535D8D0"),
                    RelatedEntityType = "TeamMember",
                    ImageType = ImageType.TeamMember
                },
                new Image
                {
                    Id = Guid.Parse("BEA822CF-509C-4A64-9FA8-03B67161BE56"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/team_member/person_1.jpg",
                    RelatedEntityId = Guid.Parse("2D9EE73B-8E5E-4FDC-8B11-F8B2AC85D7B4"),
                    RelatedEntityType = "TeamMember",
                    ImageType = ImageType.TeamMember
                },
                new Image
                {
                    Id = Guid.Parse("609CA707-CE3C-468A-9A6E-41E343F694B7"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/team_member/person_1.jpg",
                    RelatedEntityId = Guid.Parse("2A36057B-6060-4C4C-A7CF-BEF3891DA8F1"),
                    RelatedEntityType = "TeamMember",
                    ImageType = ImageType.TeamMember
                },
                new Image
                {
                    Id = Guid.Parse("D8C5B052-88B0-4369-9C47-2373EF7E4FBF"),
                    Alt = "nordic_chair",
                    Url = "/furni/images/team_member/person_1.jpg",
                    RelatedEntityId = Guid.Parse("ECF3EE48-C608-4C66-BE4A-D6AA586F50E9"),
                    RelatedEntityType = "TeamMember",
                    ImageType = ImageType.TeamMember
                }
                #endregion
            );

            builder.Entity<Address>().HasData(
                new Address
                {
                    Id = Guid.Parse("7EAA7B8A-DEA2-4081-91DD-83FF540E780E"),
                    City = "Baku",
                    Region = "Yasamal",
                    Street = "Tbilisi Avenue 45",
                    PostalCode = 1052,
                }
            );

            builder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = Guid.Parse("115378E2-FEA3-4ED5-A02A-AA732514164A"),
                    Mail = "info@furni.az",
                    Phone = "+994 50 123 45 67",
                }
            );

            builder.Entity<Offer>().HasData(
                new Offer
                {
                    Id = Guid.Parse("E61AC57A-E1AD-4995-9166-D3A286D7AC73"),
                    Text = "Modern design furniture for stylish homes.",
                    FeatureId = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4")
                },
                new Offer
                {
                    Id = Guid.Parse("7E352DFD-E936-43D2-96F6-D3C4D39E0C87"),
                    Text = "High-quality materials with long-lasting durability.",
                    FeatureId = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4")
                },
                new Offer
                {
                    Id = Guid.Parse("45407F1D-81BD-404D-B92F-B8775EE99B06"),
                    Text = "Exclusive discounts on all living room collections.",
                    FeatureId = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4")
                },
                new Offer
                {
                    Id = Guid.Parse("2C9EE229-15AB-46BB-9084-1F0EF190765A"),
                    Text = "Free delivery on orders over 500 AZN.",
                    FeatureId = Guid.Parse("4E75B8E2-B8B4-4956-985F-6C22F37610E4")
                }
            );

            builder.Entity<OurService>().HasData(
                new OurService
                {
                    Id = Guid.Parse("C9DE341C-A872-4736-832E-F7340883E762"),
                    Title = "Custom Furniture Design",
                    Description = "We design personalized furniture based on your taste and space layout.",
                },
                new OurService
                {
                    Id = Guid.Parse("6564EB6D-89EE-4AC5-9491-4A6E4D011FFE"),
                    Title = "Interior Consultation",
                    Description = "Our design experts help you choose the perfect combination of colors and furniture.",
                },
                new OurService
                {
                    Id = Guid.Parse("754BA866-D61A-4582-AB70-2EBB926F3EE1"),
                    Title = "Delivery & Assembly",
                    Description = "We ensure safe delivery and professional assembly of all furniture pieces.",
                },
                new OurService
                {
                    Id = Guid.Parse("9DB157B1-2563-4D4F-A86E-F4B9F889CA92"),
                    Title = "After-Sales Support",
                    Description = "Our support team assists with maintenance and warranty-related inquiries.",
                }
            );
        }
    }
}
