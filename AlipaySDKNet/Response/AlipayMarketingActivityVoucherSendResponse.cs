using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityVoucherSendResponse.
    /// </summary>
    public class AlipayMarketingActivityVoucherSendResponse : AopResponse
    {
        /// <summary>
        /// 本次发放的支付券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
