using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppAuditReason Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppAuditReason : AopObject
    {
        /// <summary>
        /// 审核图片列表
        /// </summary>
        [XmlArray("audit_images")]
        [XmlArrayItem("string")]
        public List<string> AuditImages { get; set; }

        /// <summary>
        /// 驳回原因列表
        /// </summary>
        [XmlArray("memos")]
        [XmlArrayItem("mini_app_audit_reason_memo")]
        public List<MiniAppAuditReasonMemo> Memos { get; set; }
    }
}
