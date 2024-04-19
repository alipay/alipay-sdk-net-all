using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechAiCvRsVectorQueryResponse.
    /// </summary>
    public class AnttechAiCvRsVectorQueryResponse : AopResponse
    {
        /// <summary>
        /// 碳汇地块信息
        /// </summary>
        [XmlElement("vector_result")]
        public string VectorResult { get; set; }
    }
}
