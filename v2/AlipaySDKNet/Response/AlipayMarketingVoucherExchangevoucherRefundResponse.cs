using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVoucherExchangevoucherRefundResponse.
    /// </summary>
    public class AlipayMarketingVoucherExchangevoucherRefundResponse : AopResponse
    {
        /// <summary>
        /// 被冲正的券
        /// </summary>
        [XmlElement("voucher")]
        public OpenVoucherDTO Voucher { get; set; }
    }
}
