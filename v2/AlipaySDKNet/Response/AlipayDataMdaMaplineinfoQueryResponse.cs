using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaMaplineinfoQueryResponse.
    /// </summary>
    public class AlipayDataMdaMaplineinfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 火炬传递飞线图
        /// </summary>
        [XmlElement("line_map")]
        public string LineMap { get; set; }
    }
}
