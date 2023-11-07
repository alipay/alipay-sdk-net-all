using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIndirectmerchantModifyResponse.
    /// </summary>
    public class AlipayCommerceIndirectmerchantModifyResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("res")]
        public bool Res { get; set; }
    }
}
