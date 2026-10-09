using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvUaAsyncIdentifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvUaAsyncIdentifyModel : AopObject
    {
        /// <summary>
        /// 调用来源的app_id，需要在m2接入的申请注册
        /// </summary>
        [XmlElement("m_app_id")]
        public string MAppId { get; set; }

        /// <summary>
        /// 模型输入参数，具体跟模型相关
        /// </summary>
        [XmlElement("params")]
        public string Params { get; set; }

        /// <summary>
        /// 模型服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 该次调用的唯一id，用于日志排查
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 模型服务的uri信息，默认是inference
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
