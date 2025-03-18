using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DutyResidueAmount Data Structure.
    /// </summary>
    [Serializable]
    public class DutyResidueAmount : AopObject
    {
        /// <summary>
        /// 理赔责任编码
        /// </summary>
        [XmlElement("claim_duty_code")]
        public string ClaimDutyCode { get; set; }

        /// <summary>
        /// 理赔责任名称
        /// </summary>
        [XmlElement("claim_duty_name")]
        public string ClaimDutyName { get; set; }

        /// <summary>
        /// 单位：元 保留俩位小数
        /// </summary>
        [XmlElement("duty_deductible_excess")]
        public string DutyDeductibleExcess { get; set; }

        /// <summary>
        /// 责任剩余保额，单位：元，保留俩位小数
        /// </summary>
        [XmlElement("duty_residue_amount")]
        public string DutyResidueAmount_ { get; set; }
    }
}
