using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniHmcodeCreateResponse.
    /// </summary>
    public class AlipayOpenMiniHmcodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 异形码图片链接地址
        /// </summary>
        [XmlElement("hm_code_url")]
        public string HmCodeUrl { get; set; }
    }
}
