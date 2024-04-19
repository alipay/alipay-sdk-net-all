using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppOpenmockQueryResponse.
    /// </summary>
    public class AlipayOpenAppOpenmockQueryResponse : AopResponse
    {
        /// <summary>
        /// xxxx
        /// </summary>
        [XmlElement("xxxsa")]
        public string Xxxsa { get; set; }
    }
}
