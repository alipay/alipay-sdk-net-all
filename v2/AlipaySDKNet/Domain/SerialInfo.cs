using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SerialInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SerialInfo : AopObject
    {
        /// <summary>
        /// 标识每笔流水是否赔付，0--不赔付，1--赔付
        /// </summary>
        [XmlElement("claim_result")]
        public long ClaimResult { get; set; }

        /// <summary>
        /// 描述当笔流水拒赔的原因，当笔流水拒赔时必传
        /// </summary>
        [XmlElement("reject_reason")]
        public string RejectReason { get; set; }

        /// <summary>
        /// 对应一笔支付流水的唯一标识
        /// </summary>
        [XmlElement("serial_number")]
        public string SerialNumber { get; set; }
    }
}
