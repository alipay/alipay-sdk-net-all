using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsurePlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsurePlanDTO : AopObject
    {
        /// <summary>
        /// 折扣率
        /// </summary>
        [XmlElement("discount_rate")]
        public string DiscountRate { get; set; }

        /// <summary>
        /// 保障期限
        /// </summary>
        [XmlElement("ins_period")]
        public InsPeriodDTO InsPeriod { get; set; }

        /// <summary>
        /// 保障方案名称
        /// </summary>
        [XmlElement("insure_plan_name")]
        public string InsurePlanName { get; set; }

        /// <summary>
        /// 折扣前原保费
        /// </summary>
        [XmlElement("original_premium")]
        public long OriginalPremium { get; set; }

        /// <summary>
        /// 折扣前原保费，单位元，两位小数
        /// </summary>
        [XmlElement("original_premium_yuan")]
        public string OriginalPremiumYuan { get; set; }

        /// <summary>
        /// 保费，单位分
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 保费费率
        /// </summary>
        [XmlElement("premium_rate")]
        public string PremiumRate { get; set; }

        /// <summary>
        /// 保费，单位元，两位小数
        /// </summary>
        [XmlElement("premium_yuan")]
        public string PremiumYuan { get; set; }

        /// <summary>
        /// 产品方案id
        /// </summary>
        [XmlElement("product_plan_id")]
        public string ProductPlanId { get; set; }

        /// <summary>
        /// 报价id
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }

        /// <summary>
        /// 是否推荐
        /// </summary>
        [XmlElement("recommend")]
        public bool Recommend { get; set; }

        /// <summary>
        /// 保额，单位分
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }

        /// <summary>
        /// 保额，单位元，两位小数
        /// </summary>
        [XmlElement("sum_insured_yuan")]
        public string SumInsuredYuan { get; set; }
    }
}
