using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOpenbizmockNewinterfaceQueryResponse.
    /// </summary>
    public class AlipayOpenOpenbizmockNewinterfaceQueryResponse : AopResponse
    {
        /// <summary>
        /// 2
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
