using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHdfServicerightConfirmModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHdfServicerightConfirmModel : AopObject
    {
        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 业务订单id
        /// </summary>
        [XmlElement("business_order_id")]
        public string BusinessOrderId { get; set; }

        /// <summary>
        /// 合作方userId
        /// </summary>
        [XmlElement("open_partner_user_id")]
        public string OpenPartnerUserId { get; set; }

        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 服务类型
        /// </summary>
        [XmlElement("service_type")]
        public string ServiceType { get; set; }
    }
}
