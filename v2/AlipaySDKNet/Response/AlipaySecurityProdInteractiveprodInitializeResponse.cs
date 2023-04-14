using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdInteractiveprodInitializeResponse.
    /// </summary>
    public class AlipaySecurityProdInteractiveprodInitializeResponse : AopResponse
    {
        /// <summary>
        /// 扩展参数，JSON格式
        /// </summary>
        [XmlElement("ext_params")]
        public string ExtParams { get; set; }

        /// <summary>
        /// 交互Id，格式为SSP_CONTEXT_bizId
        /// </summary>
        [XmlElement("interact_id")]
        public string InteractId { get; set; }

        /// <summary>
        /// 交互产品跳转地址
        /// </summary>
        [XmlElement("interact_url")]
        public string InteractUrl { get; set; }
    }
}
