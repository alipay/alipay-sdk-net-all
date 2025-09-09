using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorNlinkUrlsecurityVerifyResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorNlinkUrlsecurityVerifyResponse : AopResponse
    {
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
        /// 查询服务端日志使用
        /// </summary>
        [XmlElement("trace_id_info")]
        public string TraceIdInfo { get; set; }

        /// <summary>
        /// 是否验签成功
        /// </summary>
        [XmlElement("verify_flag")]
        public bool VerifyFlag { get; set; }
    }
}
