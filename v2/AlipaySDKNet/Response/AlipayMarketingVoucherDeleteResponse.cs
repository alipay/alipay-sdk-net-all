using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingVoucherDeleteResponse.
    /// </summary>
    public class AlipayMarketingVoucherDeleteResponse : AopResponse
    {
        /// <summary>
        /// 本张券的原始面额，单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }
    }
}
