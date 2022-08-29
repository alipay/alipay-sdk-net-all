using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PurchaseInsurePlanDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PurchaseInsurePlanDTO : AopObject
    {
        /// <summary>
        /// 是否当时选定的方案,查看或编辑订购时有效
        /// </summary>
        [XmlElement("current_selected")]
        public bool CurrentSelected { get; set; }

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
        /// 折扣前原参考保费
        /// </summary>
        [XmlElement("original_refer_premium")]
        public long OriginalReferPremium { get; set; }

        /// <summary>
        /// 参考价格
        /// </summary>
        [XmlElement("per_refer_premium")]
        public long PerReferPremium { get; set; }

        /// <summary>
        /// 参考保额
        /// </summary>
        [XmlElement("per_refer_sum_insured")]
        public long PerReferSumInsured { get; set; }

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
        /// 参考折扣率
        /// </summary>
        [XmlElement("refer_discount_rate")]
        public string ReferDiscountRate { get; set; }

        /// <summary>
        /// 参考保费费率
        /// </summary>
        [XmlElement("refer_premium_rate")]
        public string ReferPremiumRate { get; set; }
    }
}
