using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOpenbizmockOpenidQueryResponse.
    /// </summary>
    public class AlipayOpenOpenbizmockOpenidQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
