using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcActivityVoucherSendResponse.
    /// </summary>
    public class AlipayCommerceEcActivityVoucherSendResponse : AopResponse
    {
        /// <summary>
        /// 券id
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
