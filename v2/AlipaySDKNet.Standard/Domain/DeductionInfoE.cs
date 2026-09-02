using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionInfoE Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionInfoE : AopObject
    {
        /// <summary>
        /// 扣除金额，单位：元
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 扣除原因
        /// </summary>
        [XmlElement("deduction_reason")]
        public string DeductionReason { get; set; }
    }
}
