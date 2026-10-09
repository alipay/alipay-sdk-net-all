using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayAipayAgentPaymentPrecreateResponse.
    /// </summary>
    public class AlipayAipayAgentPaymentPrecreateResponse : AopResponse
    {
        /// <summary>
        /// 按量付费预下单订单号，用于后续支付
        /// </summary>
        [XmlElement("amt_pre_pay_id")]
        public string AmtPrePayId { get; set; }

        /// <summary>
        /// 支付二维码链接，仅接入商户通知的返回
        /// </summary>
        [XmlElement("qr_code_url")]
        public string QrCodeUrl { get; set; }
    }
}
