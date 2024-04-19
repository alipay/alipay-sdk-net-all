using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommercePromoterRelationDeleteResponse.
    /// </summary>
    public class AlipayCommercePromoterRelationDeleteResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
