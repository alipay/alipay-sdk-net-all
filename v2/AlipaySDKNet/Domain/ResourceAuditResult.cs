using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ResourceAuditResult Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceAuditResult : AopObject
    {
        /// <summary>
        /// 要审核的资源value值，文字为文案，图片为图片url，视频为视频url
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }

        /// <summary>
        /// 不通过原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
