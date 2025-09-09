using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataDataserviceSchemaerrorcodeRainyQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceSchemaerrorcodeRainyQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
