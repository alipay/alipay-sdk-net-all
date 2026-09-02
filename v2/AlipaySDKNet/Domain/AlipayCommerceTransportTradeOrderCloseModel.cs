using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTradeOrderCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTradeOrderCloseModel : AopObject
    {
        /// <summary>
        /// 恒星平台订单号（代扣发起时返回），推荐使用 bill_no 定位订单。bill_no、trade_no、out_biz_no 三者至少传一个
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 区分业务类型字段
        /// </summary>
        [XmlElement("merchant_biz_type")]
        public string MerchantBizType { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 恒星平台订单号（代扣发起时返回），推荐使用 bill_no 定位订单。bill_no、trade_no、out_biz_no 三者至少传一个
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [XmlElement("out_sub_biz_no")]
        public string OutSubBizNo { get; set; }

        /// <summary>
        /// 恒星平台订单号（代扣发起时返回），推荐使用 bill_no 定位订单。bill_no、trade_no、out_biz_no 三者至少传一个
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 支付宝用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
