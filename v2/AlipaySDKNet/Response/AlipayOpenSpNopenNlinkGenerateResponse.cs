using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenSpNopenNlinkGenerateResponse.
    /// </summary>
    public class AlipayOpenSpNopenNlinkGenerateResponse : AopResponse
    {
        /// <summary>
        /// 耗时单位毫秒
        /// </summary>
        [XmlElement("cost_time")]
        public long CostTime { get; set; }

        /// <summary>
        /// 1绑定 0未绑定
        /// </summary>
        [XmlElement("device_bind_status")]
        public string DeviceBindStatus { get; set; }

        /// <summary>
        /// N链接对应的链接id
        /// </summary>
        [XmlElement("n_link_id")]
        public string NLinkId { get; set; }

        /// <summary>
        /// N链接的对应类型
        /// </summary>
        [XmlElement("n_link_type")]
        public string NLinkType { get; set; }

        /// <summary>
        /// 碰一下链接
        /// </summary>
        [XmlElement("n_link_url")]
        public string NLinkUrl { get; set; }

        /// <summary>
        /// 查询服务端日志使用
        /// </summary>
        [XmlElement("trace_id_info")]
        public string TraceIdInfo { get; set; }
    }
}
