using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceBusinessMallCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceBusinessMallCreateResponse : AopResponse
    {
        /// <summary>
        /// 商圈ID
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
