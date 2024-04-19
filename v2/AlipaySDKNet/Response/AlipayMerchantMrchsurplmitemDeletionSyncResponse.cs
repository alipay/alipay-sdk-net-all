using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantMrchsurplmitemDeletionSyncResponse.
    /// </summary>
    public class AlipayMerchantMrchsurplmitemDeletionSyncResponse : AopResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
