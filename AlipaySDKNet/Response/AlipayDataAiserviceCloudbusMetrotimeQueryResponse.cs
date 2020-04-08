using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusMetrotimeQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusMetrotimeQueryResponse : AopResponse
    {
        /// <summary>
        /// 结果
        /// </summary>
        [XmlElement("result")]
        public MetroOdDetailResult Result { get; set; }
    }
}
