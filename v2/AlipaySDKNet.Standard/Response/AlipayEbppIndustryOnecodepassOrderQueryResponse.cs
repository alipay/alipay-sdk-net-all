using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppIndustryOnecodepassOrderQueryResponse.
    /// </summary>
    public class AlipayEbppIndustryOnecodepassOrderQueryResponse : AopResponse
    {
        /// <summary>
        /// 买家实付金额，单位为元，两位小数。该金额代表该笔交易买家实际支付的金额，不包含商户折扣等金额
        /// </summary>
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("org_buyer_openid")]
        public string OrgBuyerOpenid { get; set; }

        /// <summary>
        /// 买家在支付宝的unionid
        /// </summary>
        [XmlElement("org_buyer_unionid")]
        public string OrgBuyerUnionid { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// I("I", "等待付款"),     N("N","付款失败"),     C("C", "单据关闭"),     F("F", "失败"),     S("S", "成功"),     H("H", "部分退款");
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数。该参数的值为支付时传入的total_amount
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
