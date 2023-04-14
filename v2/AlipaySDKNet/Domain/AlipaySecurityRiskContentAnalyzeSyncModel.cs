using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentAnalyzeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentAnalyzeSyncModel : AopObject
    {
        /// <summary>
        /// 来源渠道
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 调用者信息
        /// </summary>
        [XmlElement("invoker")]
        public SaaSInvoker Invoker { get; set; }

        /// <summary>
        /// 唯一请求ID
        /// </summary>
        [XmlElement("req_msg_id")]
        public string ReqMsgId { get; set; }

        /// <summary>
        /// 内容安全检测业务同步请求体
        /// </summary>
        [XmlElement("request")]
        public InfoSecAnalyzeSyncContent Request { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }
    }
}
