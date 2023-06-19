using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockTestparameterQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockTestparameterQueryResponse : AopResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
