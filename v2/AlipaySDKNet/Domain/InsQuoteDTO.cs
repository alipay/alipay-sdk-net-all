using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InsQuoteDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsQuoteDTO : AopObject
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
        /// 保司id
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 折扣前原保费
        /// </summary>
        [XmlElement("original_premium")]
        public long OriginalPremium { get; set; }

        /// <summary>
        /// 保费
        /// </summary>
        [XmlElement("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 保费费率
        /// </summary>
        [XmlElement("premium_rate")]
        public string PremiumRate { get; set; }

        /// <summary>
        /// 产品编码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [XmlElement("product_name")]
        public string ProductName { get; set; }

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
        /// 推荐流水ids
        /// </summary>
        [XmlElement("recommend_flow_id")]
        public string RecommendFlowId { get; set; }

        /// <summary>
        /// 保额
        /// </summary>
        [XmlElement("sum_insured")]
        public long SumInsured { get; set; }
    }
}
