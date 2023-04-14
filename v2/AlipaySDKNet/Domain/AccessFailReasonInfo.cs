using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AccessFailReasonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AccessFailReasonInfo : AopObject
    {
        /// <summary>
        /// 一般为引导商户修改账号配置的链接
        /// </summary>
        [XmlElement("action_url")]
        public string ActionUrl { get; set; }

        /// <summary>
        /// 用于对客展示功能无法使用的原因
        /// </summary>
        [XmlElement("reason_text")]
        public string ReasonText { get; set; }
    }
}
