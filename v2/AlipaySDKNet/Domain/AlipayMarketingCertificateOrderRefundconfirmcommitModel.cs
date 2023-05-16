using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingCertificateOrderRefundconfirmcommitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCertificateOrderRefundconfirmcommitModel : AopObject
    {
        /// <summary>
        /// 凭证标识ID。通过退款前向商户确认是否可以退款spi入参获取
        /// </summary>
        [XmlElement("certificate_id")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 拒绝退款的三方码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 订单号。通过退款前向商户确认是否可以退款spi入参获取
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退款前向商户确认退款结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 买家的支付宝uid
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 买家的支付宝openId
        /// </summary>
        [XmlElement("user_open_id")]
        public string UserOpenId { get; set; }
    }
}
