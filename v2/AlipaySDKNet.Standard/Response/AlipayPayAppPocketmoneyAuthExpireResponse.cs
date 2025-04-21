using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPocketmoneyAuthExpireResponse.
    /// </summary>
    public class AlipayPayAppPocketmoneyAuthExpireResponse : AopResponse
    {
        /// <summary>
        /// 解除结果
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
