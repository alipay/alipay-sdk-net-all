using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommerceOrderlogisticsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommerceOrderlogisticsQueryModel : AopObject
    {
        /// <summary>
        /// 买家ID，渠道唯一标识买家的唯一ID
        /// </summary>
        [XmlElement("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 合作商ID，由蚂蚁保线下分配
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }
    }
}
