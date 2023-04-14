using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTesttestnumberQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTesttestnumberQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
