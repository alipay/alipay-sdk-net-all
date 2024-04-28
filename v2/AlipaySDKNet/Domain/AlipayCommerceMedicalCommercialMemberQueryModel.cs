using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalCommercialMemberQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalCommercialMemberQueryModel : AopObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 会员卡订单id
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// out_product_id为商户侧唯一权益id，和用户的业务子单一一对应
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
