using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAcommunicationCreditphoneRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAcommunicationCreditphoneRefundModel : AopObject
    {
        /// <summary>
        /// 当期支付宝订单号
        /// </summary>
        [XmlElement("alipay_biz_no")]
        public string AlipayBizNo { get; set; }

        /// <summary>
        /// 支付宝openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝主单号
        /// </summary>
        [XmlElement("alipay_order_no")]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 是否是提前结清单据
        /// </summary>
        [XmlElement("in_advance_order")]
        public bool InAdvanceOrder { get; set; }

        /// <summary>
        /// 退款请求号
        /// </summary>
        [XmlElement("refund_request_no")]
        public string RefundRequestNo { get; set; }
    }
}
