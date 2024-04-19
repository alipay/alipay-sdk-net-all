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

        /// <summary>
        /// 推广码图片地址
        /// </summary>
        [XmlElement("guided_code_img")]
        public string GuidedCodeImg { get; set; }
    }
}
