using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniOrderReceiveraddressModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniOrderReceiveraddressModifyModel : AopObject
    {
        /// <summary>
        /// 收货地址
        /// </summary>
        [XmlElement("address_info")]
        public MiniReceiverAddressInfoDTO AddressInfo { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 交易组件订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号，创建订单请求由商户传入
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
