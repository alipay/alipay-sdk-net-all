using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetroodQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusMetroodQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public MetroOdDetailResult Result { get; set; }
    }
}
