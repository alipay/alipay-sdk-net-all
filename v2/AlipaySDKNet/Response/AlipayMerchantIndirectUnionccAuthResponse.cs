using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantIndirectUnionccAuthResponse.
    /// </summary>
    public class AlipayMerchantIndirectUnionccAuthResponse : AopResponse
    {
        /// <summary>
        /// 报备状态，当前仅返回SUCCESS
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
