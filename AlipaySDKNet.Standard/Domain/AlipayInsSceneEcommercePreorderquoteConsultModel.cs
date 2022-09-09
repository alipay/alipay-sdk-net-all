using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEcommercePreorderquoteConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEcommercePreorderquoteConsultModel : AopObject
    {
        /// <summary>
        /// 订单
        /// </summary>
        [XmlElement("order")]
        public EcomOrderDTO Order { get; set; }

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
    }
}
