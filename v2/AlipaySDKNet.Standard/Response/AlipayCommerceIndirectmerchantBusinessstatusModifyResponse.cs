using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceIndirectmerchantBusinessstatusModifyResponse.
    /// </summary>
    public class AlipayCommerceIndirectmerchantBusinessstatusModifyResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("res")]
        public bool Res { get; set; }
    }
}
