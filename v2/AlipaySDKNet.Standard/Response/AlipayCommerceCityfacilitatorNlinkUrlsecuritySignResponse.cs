using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorNlinkUrlsecuritySignResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorNlinkUrlsecuritySignResponse : AopResponse
    {
        /// <summary>
        /// 设备biztid
        /// </summary>
        [XmlElement("biztid")]
        public string Biztid { get; set; }

        /// <summary>
        /// 耗时单位毫秒
        /// </summary>
        [XmlElement("cost_time")]
        public long CostTime { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [XmlElement("msg_info")]
        public string MsgInfo { get; set; }

        /// <summary>
        /// 服务端签名
        /// </summary>
        [XmlElement("server_sign")]
        public string ServerSign { get; set; }

        /// <summary>
        /// trace_id_info
        /// </summary>
        [XmlElement("trace_id_info")]
        public string TraceIdInfo { get; set; }

        /// <summary>
        /// 原始url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
