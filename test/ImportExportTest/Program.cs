using Marquitos.Salesforce.Commerce.Helpers;
using Marquitos.Salesforce.Commerce.Models.Promotions;
using Marquitos.Salesforce.Commerce.Models.Promotions.Conditions;
using Marquitos.Salesforce.Commerce.Models.Promotions.Discounts;
using Marquitos.Salesforce.Commerce.Models.Promotions.ProductDiscounts.Tiered;

namespace ImportExportTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var productPromotionRule = new ProductPromotionRule
            {
                QualifyingProducts = new ProductSpecification
                {
                    IncludedProducts = new ConditionGroups()
                    {
                        new() {
                            Conditions = new List<Condition>()
                            {
                                new BrandCondition
                                {
                                    Values = new List<string> { "brand1", "brand2" }
                                },
                                new AttributeCondition()
                                {
                                    AttributeID = "color",
                                    Values = new List<string> { "red", "blue" }
                                }
                            }
                        },
                        new() {
                            Conditions = new List<Condition>()
                            {
                                new BrandCondition
                                {
                                    Values = new List<string> { "brand3", "brand4" }
                                }
                            }
                        },
                        new()
                        {
                            Conditions = new List<Condition>()
                            {
                                new AttributeCondition()
                                {
                                    AttributeID = "color",
                                    Values = new List<string> { "red", "blue" }
                                }
                            }
                        }
                    }
                },
                DiscountedProducts = new ProductSpecification
                {
                    IncludedProducts = new ConditionGroups()
                    {
                        new() {
                            Conditions = new List<Condition>()
                            {
                                new CategoryCondition
                                {
                                    Values = new List<string> { "category3", "category4" }
                                }
                            }
                        }
                    },
                    ExcludedProducts = new ConditionGroups()
                    {
                        new() {
                            Conditions = new List<Condition>()
                            {
                                new BrandCondition
                                {
                                    Values = new List<string> { "brand5", "brand6" }
                                }
                            }
                        }
                    }
                },
                PromotionDiscount = new TieredProductDiscounts
                {
                    ConditionType = Marquitos.Salesforce.Commerce.Enums.ProductPromotionConditionType.ProductQuantity,
                    Discounts = new()
                    {
                        new TieredProductDiscount(new PriceBookPriceDiscount("teste")),
                    } 
                },
                MaxApplications = 5
            };

            var promotion = new Promotion { PromotionRule = productPromotionRule };

            var resultStr = XmlImpex.ToXml(promotion);

            Console.WriteLine(resultStr);
        }
    }
}
