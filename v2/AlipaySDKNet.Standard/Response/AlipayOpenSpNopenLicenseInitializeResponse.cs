using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNopenLicenseInitializeResponse.
    /// </summary>
    public class AlipayOpenSpNopenLicenseInitializeResponse : AopResponse
    {
        /// <summary>
        /// 耗时单位毫秒
        /// </summary>
        [XmlElement("cost_time")]
        public long CostTime { get; set; }

        /// <summary>
        /// 查询服务端日志使用
        /// </summary>
        [XmlElement("trace_id_info")]
        public string TraceIdInfo { get; set; }
    }
}
