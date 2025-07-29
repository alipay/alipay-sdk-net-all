using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationDistributionFloworderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationDistributionFloworderCreateModel : AopObject
    {
        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 机构订单id
        /// </summary>
        [XmlElement("inst_order_id")]
        public string InstOrderId { get; set; }

        /// <summary>
        /// 分销商品id
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 订购价格，单位元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 协议id
        /// </summary>
        [XmlElement("protocol_sequence_id")]
        public string ProtocolSequenceId { get; set; }

        /// <summary>
        /// 短信验证码
        /// </summary>
        [XmlElement("sms_code")]
        public string SmsCode { get; set; }
    }
}
