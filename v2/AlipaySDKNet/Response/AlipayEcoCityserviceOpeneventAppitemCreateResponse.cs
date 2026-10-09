using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEcoCityserviceOpeneventAppitemCreateResponse.
    /// </summary>
    public class AlipayEcoCityserviceOpeneventAppitemCreateResponse : AopResponse
    {
        /// <summary>
        /// 商品在光华侧的唯一标识
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }
    }
}
