using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsServiceServicestatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsServiceServicestatusSyncModel : AopObject
    {
        /// <summary>
        /// 因为不同的服务产品、不同的供应商都具有差异化的服务状态和流程，服务状态流转的流程在健康管理服务系统中都可以自定义设置。
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 服务单号
        /// </summary>
        [XmlElement("service_no")]
        public string ServiceNo { get; set; }

        /// <summary>
        /// 服务单的当前状态
        /// </summary>
        [XmlElement("service_status")]
        public string ServiceStatus { get; set; }

        /// <summary>
        /// 服务状态更新时间
        /// </summary>
        [XmlElement("status_update_time")]
        public string StatusUpdateTime { get; set; }

        /// <summary>
        /// 本次请求的唯一标识
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
