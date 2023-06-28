using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCommonGuidedcodeReceiveResponse.
    /// </summary>
    public class AlipayCommerceCommonGuidedcodeReceiveResponse : AopResponse
    {
        /// <summary>
        /// 二维码地址
        /// </summary>
        [XmlElement("guided_code")]
        public string GuidedCode { get; set; }

        /// <summary>
        /// 二维码图片
        /// </summary>
        [XmlElement("guided_code_img")]
        public string GuidedCodeImg { get; set; }
    }
}
