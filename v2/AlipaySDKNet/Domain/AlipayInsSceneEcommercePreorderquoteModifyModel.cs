using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderquoteModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePreorderquoteModifyModel : AopObject
    {
        /// <summary>
        /// 合作商标识
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 预下单id
        /// </summary>
        [XmlElement("pre_order_id")]
        public string PreOrderId { get; set; }

        /// <summary>
        /// 报价id
        /// </summary>
        [XmlElement("quote_id")]
        public string QuoteId { get; set; }
    }
}
