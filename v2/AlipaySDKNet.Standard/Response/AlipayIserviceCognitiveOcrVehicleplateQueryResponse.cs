using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicleplateQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehicleplateQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务识别失败后对应的详细错误原因
        /// </summary>
        [XmlElement("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 识别正确概率
        /// </summary>
        [XmlElement("prob")]
        public string Prob { get; set; }

        /// <summary>
        /// 服务器id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// true: 识别成功  false: 识别失败
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [XmlElement("txt")]
        public string Txt { get; set; }
    }
}
