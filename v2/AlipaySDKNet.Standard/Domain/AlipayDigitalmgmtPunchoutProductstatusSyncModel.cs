using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDigitalmgmtPunchoutProductstatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDigitalmgmtPunchoutProductstatusSyncModel : AopObject
    {
        /// <summary>
        /// 消息描述
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 通知的标识
        /// </summary>
        [XmlElement("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 来源类型
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }

        /// <summary>
        /// 状态 enabled,disabled
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [XmlElement("supplier_name")]
        public string SupplierName { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant_id")]
        public long TenantId { get; set; }
    }
}
