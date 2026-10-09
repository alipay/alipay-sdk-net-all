using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityOrdervoucherSendResponse.
    /// </summary>
    public class AlipayMarketingActivityOrdervoucherSendResponse : AopResponse
    {
        /// <summary>
        /// 本次发放的券码
        /// </summary>
        [XmlElement("voucher_code")]
        public string VoucherCode { get; set; }
    }
}
