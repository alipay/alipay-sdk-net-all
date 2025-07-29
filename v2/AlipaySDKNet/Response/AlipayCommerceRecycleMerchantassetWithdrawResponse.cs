using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceRecycleMerchantassetWithdrawResponse.
    /// </summary>
    public class AlipayCommerceRecycleMerchantassetWithdrawResponse : AopResponse
    {
        /// <summary>
        /// 流水id，保证是唯一的
        /// </summary>
        [XmlElement("record_id")]
        public string RecordId { get; set; }
    }
}
