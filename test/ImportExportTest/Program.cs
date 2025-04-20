using Marquitos.Salesforce.Commerce.Builders;
using Marquitos.Salesforce.Commerce.Enums.Comparators;
using Marquitos.Salesforce.Commerce.Enums.Conditions;
using Marquitos.Salesforce.Commerce.Helpers;
using Marquitos.Salesforce.Commerce.Models.Promotions;
using Marquitos.Salesforce.Commerce.Models.Promotions.Conditions;
using Marquitos.Salesforce.Commerce.Models.Promotions.Discounts;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered;
using Marquitos.Salesforce.Commerce.Models.Shared;

namespace ImportExportTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productPromotionRule = new ProductPromotionRule
            {
                QualifyingProducts = 
                    ProductSpecificationBuilder.Create()
                        .AddIncludedProducts(
                            ConditionGroupBuilder.Create()
                                .AddBrandCondition(["brand1", "brand2"])
                                .AddAttributeCondition("color", ["red", "blue"], AttributeComparator.Contains))
                        .AddIncludedProducts(
                            ConditionGroupBuilder.Create()
                                .AddBrandCondition(["brand3", "brand4"]))
                        .AddIncludedProducts(
                            ConditionGroupBuilder.Create()
                                .AddAttributeCondition("color", ["red", "blue"], AttributeComparator.Equals)),
                DiscountedProducts = 
                    ProductSpecificationBuilder.Create()
                        .AddIncludedProducts(
                            ConditionGroupBuilder.Create()
                                .AddCategoryCondition(["category3", "category4"]))
                        .AddExcludedProducts(
                            ConditionGroupBuilder.Create()
                                .AddBrandCondition(["brand5", "brand6"])),
                Discounts = 
                    ProductDiscountBuilder.Create()
                        .WithTieredPriceBookPriceDiscounts(new PriceBookPriceDiscount("teste"), 0, ProductPromotionConditionType.ProductQuantity),
                MaxApplications = 5
            };

            var promotion = new Promotion 
            {
                Name = new LocalizedStrings("Test Promotion"),
                Details = new LocalizedStrings("Test Promotion Description"),
                PromotionRule = productPromotionRule,
                PromotionID = "test_promotion",
            };

            var resultStr = XmlImpex.ToXml(promotion);

            Console.WriteLine(resultStr);

            var result = XmlImpex.ReadFrom<Promotion>(resultStr);
        }
    }
}
