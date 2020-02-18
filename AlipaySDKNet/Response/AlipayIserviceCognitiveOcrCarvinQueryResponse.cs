using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrCarvinQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrCarvinQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务id，唯一标示服务请求
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 开放平台trace_id，用于定位问题
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 车辆vin码
        /// </summary>
        [XmlElement("vin")]
        public string Vin { get; set; }
    }
}
