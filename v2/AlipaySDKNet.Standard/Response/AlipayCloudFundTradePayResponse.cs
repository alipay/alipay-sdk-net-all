using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudFundTradePayResponse.
    /// </summary>
    public class AlipayCloudFundTradePayResponse : AopResponse
    {
        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [XmlElement("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("buyer_open_id")]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [XmlElement("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 是否可以转为app支付，仅当商户代扣失败场景才会返回该字段信息。
        /// </summary>
        [XmlElement("can_turn_to_app_pay")]
        public bool CanTurnToAppPay { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易金额，单位元
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
