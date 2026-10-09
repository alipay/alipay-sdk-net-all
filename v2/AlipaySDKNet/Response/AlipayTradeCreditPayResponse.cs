using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditPayResponse.
    /// </summary>
    public class AlipayTradeCreditPayResponse : AopResponse
    {
        /// <summary>
        /// 在未生成真实交易时，不返回，需要商户调用交易查询接口或接入支付通知，获取最终的用户信息
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 信用单id
        /// </summary>
        [XmlElement("credit_biz_order_id")]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 交易付款时间
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部商户交易号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 本次使用信用资产下单的金额
        /// </summary>
        [XmlElement("pre_auth_pay_amount")]
        public string PreAuthPayAmount { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 在未生成真实交易时，不返回，需要商户调用交易查询接口或接入支付通知，获取最终的交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
