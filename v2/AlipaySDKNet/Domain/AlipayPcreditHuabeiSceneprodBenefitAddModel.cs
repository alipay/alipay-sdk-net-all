using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiSceneprodBenefitAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditHuabeiSceneprodBenefitAddModel : AopObject
    {
        /// <summary>
        /// 权益ID，创建权益时返回的ID
        /// </summary>
        [XmlElement("benefit_id")]
        public string BenefitId { get; set; }

        /// <summary>
        /// 追加的预算金额
        /// </summary>
        [XmlElement("budget_amount")]
        public long BudgetAmount { get; set; }

        /// <summary>
        /// 外部业务号，幂等ID
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 创建权益的支付宝商户ID
        /// </summary>
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 调用方来源
        /// </summary>
        [XmlElement("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 上游权益id
        /// </summary>
        [XmlElement("upper_benefit_id")]
        public string UpperBenefitId { get; set; }

        /// <summary>
        /// 上游业务商家id
        /// </summary>
        [XmlElement("upper_seller_id")]
        public string UpperSellerId { get; set; }
    }
}
