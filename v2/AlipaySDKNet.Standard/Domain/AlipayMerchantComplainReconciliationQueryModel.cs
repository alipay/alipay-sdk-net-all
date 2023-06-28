using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantComplainReconciliationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantComplainReconciliationQueryModel : AopObject
    {
        /// <summary>
        /// 商家支付宝账号
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商家类型，分为直连商家、间连商家
        /// </summary>
        [XmlElement("merchant_type")]
        public string MerchantType { get; set; }

        /// <summary>
        /// 支付宝订单号，从账单中获取
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
