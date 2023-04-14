using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeCreditPayConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeCreditPayConsultModel : AopObject
    {
        /// <summary>
        /// 标识买家授信额度的来源
        /// </summary>
        [XmlElement("buyer_credit_source")]
        public string BuyerCreditSource { get; set; }

        /// <summary>
        /// 标识本次授信拆分的业务场景，具体的值由支付宝定义
        /// </summary>
        [XmlElement("credit_scene")]
        public string CreditScene { get; set; }

        /// <summary>
        /// 标识商家授信额度的来源，具体的值由支付宝定义
        /// </summary>
        [XmlElement("merchant_credit_source")]
        public string MerchantCreditSource { get; set; }

        /// <summary>
        /// 交易金额,单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易买家的userId
        /// </summary>
        [XmlElement("trade_buyer_id")]
        public string TradeBuyerId { get; set; }

        /// <summary>
        /// 交易卖家的userId
        /// </summary>
        [XmlElement("trade_seller_id")]
        public string TradeSellerId { get; set; }
    }
}
