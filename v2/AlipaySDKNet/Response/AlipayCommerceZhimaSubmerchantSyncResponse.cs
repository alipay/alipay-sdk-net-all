using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceZhimaSubmerchantSyncResponse.
    /// </summary>
    public class AlipayCommerceZhimaSubmerchantSyncResponse : AopResponse
    {
        /// <summary>
        /// status用于展示进件结果
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
