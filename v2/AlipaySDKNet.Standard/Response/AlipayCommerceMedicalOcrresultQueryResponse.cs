using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceMedicalOcrresultQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalOcrresultQueryResponse : AopResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
