using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniPromodecisionOrderconsultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPromodecisionOrderconsultQueryModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单页咨询信息
        /// </summary>
        [XmlElement("order_detail_info")]
        public OrderDetailInfo OrderDetailInfo { get; set; }

        /// <summary>
        /// 外部优惠信息
        /// </summary>
        [XmlElement("out_promo_info")]
        public OutPromoInfo OutPromoInfo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
