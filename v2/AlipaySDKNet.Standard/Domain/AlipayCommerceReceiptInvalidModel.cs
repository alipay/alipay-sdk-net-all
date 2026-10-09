using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceReceiptInvalidModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceReceiptInvalidModel : AopObject
    {
        /// <summary>
        /// 支付宝用户openid
        /// </summary>
        [XmlElement("alipay_open_id")]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户uid
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 失效(退换货)时间，必填; 时间格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("invalid_date")]
        public string InvalidDate { get; set; }

        /// <summary>
        /// 外部商户订单号;out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号，酒店6小件场景时,传入履约号; 支付宝支付时，必填; 特殊情况: 0元订单, 可不填; 无支付场景时，可不填;
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
