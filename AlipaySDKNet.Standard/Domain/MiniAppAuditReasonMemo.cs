using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniAppAuditReasonMemo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppAuditReasonMemo : AopObject
    {
        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
