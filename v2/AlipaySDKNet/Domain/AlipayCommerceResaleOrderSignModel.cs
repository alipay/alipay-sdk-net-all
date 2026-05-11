using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceResaleOrderSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceResaleOrderSignModel : AopObject
    {
        /// <summary>
        /// 签约成功后的回调地址，例如私域订单详情页
        /// </summary>
        [XmlElement("callback_url")]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_order_id")]
        public string OutOrderId { get; set; }

        /// <summary>
        /// 签约类型
        /// </summary>
        [XmlElement("sign_pay_type")]
        public string SignPayType { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
