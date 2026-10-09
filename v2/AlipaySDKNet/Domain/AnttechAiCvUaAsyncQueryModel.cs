using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechAiCvUaAsyncQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechAiCvUaAsyncQueryModel : AopObject
    {
        /// <summary>
        /// 业务接入在m2平台申请的接入appid
        /// </summary>
        [XmlElement("m_app_id")]
        public string MAppId { get; set; }

        /// <summary>
        /// 模型服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 异步服务调用返回的taskid
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 默认可以不填
        /// </summary>
        [XmlElement("uri")]
        public string Uri { get; set; }
    }
}
