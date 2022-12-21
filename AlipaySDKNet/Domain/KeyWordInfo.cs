using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KeyWordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KeyWordInfo : AopObject
    {
        /// <summary>
        /// 审核单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 审核中的关键词
        /// </summary>
        [XmlElement("audit_key_word")]
        public string AuditKeyWord { get; set; }

        /// <summary>
        /// 审核人的备注信息
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [XmlElement("audit_time")]
        public string AuditTime { get; set; }

        /// <summary>
        /// 关键词配置ID
        /// </summary>
        [XmlElement("config_id")]
        public string ConfigId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 审核完成的关键词
        /// </summary>
        [XmlElement("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 关键词当前状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
