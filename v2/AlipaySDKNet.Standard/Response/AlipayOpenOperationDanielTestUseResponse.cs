using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationDanielTestUseResponse.
    /// </summary>
    public class AlipayOpenOperationDanielTestUseResponse : AopResponse
    {
        /// <summary>
        /// 12
        /// </summary>
        [XmlElement("output_er")]
        public string OutputEr { get; set; }
    }
}
