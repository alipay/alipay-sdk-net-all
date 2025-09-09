using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOfflineMarketingAiplayfieldbusPayorderCheckResponse.
    /// </summary>
    public class AlipayOfflineMarketingAiplayfieldbusPayorderCheckResponse : AopResponse
    {
        /// <summary>
        /// 校验结果
        /// </summary>
        [XmlElement("allow")]
        public bool Allow { get; set; }

        /// <summary>
        /// 用户补充
        /// </summary>
        [XmlElement("ext_text")]
        public string ExtText { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
