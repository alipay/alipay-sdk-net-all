using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceYuntaskGuidedcodeQueryResponse.
    /// </summary>
    public class AlipayCommerceYuntaskGuidedcodeQueryResponse : AopResponse
    {
        /// <summary>
        /// 推广码
        /// </summary>
        [XmlElement("guided_code")]
        public string GuidedCode { get; set; }
    }
}
