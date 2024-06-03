using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DspCreativeAuditResult Data Structure.
    /// </summary>
    [Serializable]
    public class DspCreativeAuditResult : AopObject
    {
        /// <summary>
        /// 创意id
        /// </summary>
        [XmlElement("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// 标题不符合要求
        /// </summary>
        [XmlElement("refuse_reason")]
        public string RefuseReason { get; set; }

        /// <summary>
        /// 审核状态（0-初始化，1-审核通过，2-待审核，3-创意过期，-1-审核拒绝)
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 模版id，和样式相关
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }
    }
}
