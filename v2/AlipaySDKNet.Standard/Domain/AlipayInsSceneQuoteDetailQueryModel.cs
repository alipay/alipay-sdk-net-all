using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneQuoteDetailQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneQuoteDetailQueryModel : AopObject
    {
        /// <summary>
        /// 外部订单id
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

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
    }
}
