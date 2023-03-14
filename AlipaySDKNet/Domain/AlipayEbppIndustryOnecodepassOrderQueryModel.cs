using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppIndustryOnecodepassOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppIndustryOnecodepassOrderQueryModel : AopObject
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 商户订单号。 和支付宝交易号不能同时为空
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。商户订单号不为空时，卖家支付宝用户ID必选
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 支付宝交易号。和商户订单号不能同时为空
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
