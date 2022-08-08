using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppTestagainCreateResponse.
    /// </summary>
    public class AlipayOpenAppTestagainCreateResponse : AopResponse
    {
        /// <summary>
        /// 1313
        /// </summary>
        [XmlElement("xxxxxx")]
        public string Xxxxxx { get; set; }
    }
}
