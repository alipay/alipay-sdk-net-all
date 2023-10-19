using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCloudDevopsBaseUseResponse.
    /// </summary>
    public class AlipayCloudDevopsBaseUseResponse : AopResponse
    {
        /// <summary>
        /// 业务描述
        /// </summary>
        [XmlElement("biz_msg")]
        public string BizMsg { get; set; }

        /// <summary>
        /// 通过
        /// </summary>
        [XmlElement("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 业务状态
        /// </summary>
        [XmlElement("biz_status")]
        public bool BizStatus { get; set; }

        /// <summary>
        /// 业务traceId
        /// </summary>
        [XmlElement("biz_trace")]
        public string BizTrace { get; set; }

        /// <summary>
        /// 闪退列表
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
