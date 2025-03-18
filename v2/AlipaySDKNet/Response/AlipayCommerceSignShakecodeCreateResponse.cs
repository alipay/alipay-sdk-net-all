using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceSignShakecodeCreateResponse.
    /// </summary>
    public class AlipayCommerceSignShakecodeCreateResponse : AopResponse
    {
        /// <summary>
        /// 创建的吱口令，可复制拉起签约页面
        /// </summary>
        [XmlElement("shake_code")]
        public string ShakeCode { get; set; }

        /// <summary>
        /// 签约链接转换的短链接，点击打开签约页面
        /// </summary>
        [XmlElement("short_url")]
        public string ShortUrl { get; set; }
    }
}
