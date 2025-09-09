using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardRejectReasonInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardRejectReasonInfo : AopObject
    {
        /// <summary>
        /// 驳回项
        /// </summary>
        [XmlElement("reject_item")]
        public string RejectItem { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }
    }
}
