using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantComplainReconciliationSubmitModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantComplainReconciliationSubmitModel : AopObject
    {
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [XmlElement("merchant_cert_no")]
        public string MerchantCertNo { get; set; }

        /// <summary>
        /// 支付宝侧订单号，可从账单中获取
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
