using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalInsuranceDiffrecoveryPayResponse.
    /// </summary>
    public class AlipayCommerceMedicalInsuranceDiffrecoveryPayResponse : AopResponse
    {
        /// <summary>
        /// 支付宝交易订单号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
