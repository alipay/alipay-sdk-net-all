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
    }
}
