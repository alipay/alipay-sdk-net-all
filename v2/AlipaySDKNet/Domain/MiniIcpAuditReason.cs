using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniIcpAuditReason Data Structure.
    /// </summary>
    [Serializable]
    public class MiniIcpAuditReason : AopObject
    {
        /// <summary>
        /// 小程序备案结果说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }
    }
}
