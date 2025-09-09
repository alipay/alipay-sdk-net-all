using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DeductionPlanInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DeductionPlanInfo : AopObject
    {
        /// <summary>
        /// 凭证次序号
        /// </summary>
        [XmlElement("certificate_serial_no")]
        public string CertificateSerialNo { get; set; }

        /// <summary>
        /// 扣款金额，单位分
        /// </summary>
        [XmlElement("deduction_amount")]
        public long DeductionAmount { get; set; }

        /// <summary>
        /// 扣款计划状态
        /// </summary>
        [XmlElement("deduction_plan_status")]
        public string DeductionPlanStatus { get; set; }

        /// <summary>
        /// 原价金额，单位分
        /// </summary>
        [XmlElement("original_amount")]
        public long OriginalAmount { get; set; }

        /// <summary>
        /// 期数
        /// </summary>
        [XmlElement("period")]
        public long Period { get; set; }

        /// <summary>
        /// 计划扣款时间
        /// </summary>
        [XmlElement("plan_deduction_time")]
        public string PlanDeductionTime { get; set; }
    }
}
