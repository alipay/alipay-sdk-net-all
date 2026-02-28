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
        /// 保障详情
        /// </summary>
        [XmlElement("benefit_detail")]
        public string BenefitDetail { get; set; }

        /// <summary>
        /// 剩余理赔次数
        /// </summary>
        [XmlElement("claim_count")]
        public long ClaimCount { get; set; }

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
        /// 示例：100.00 单位：元 保留俩位小数
        /// </summary>
        [XmlElement("duty_init_amount")]
        public string DutyInitAmount { get; set; }

        /// <summary>
        /// 责任剩余保额，单位：元，保留俩位小数
        /// </summary>
        [XmlElement("duty_residue_amount")]
        public string DutyResidueAmount_ { get; set; }

        /// <summary>
        /// 拓展信息
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 父责任节点
        /// </summary>
        [XmlElement("parent_claim_duty_code")]
        public string ParentClaimDutyCode { get; set; }

        /// <summary>
        /// 备注中文
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 备注英文
        /// </summary>
        [XmlElement("remark_en")]
        public string RemarkEn { get; set; }

        /// <summary>
        /// 等待期,单位：天。
        /// </summary>
        [XmlElement("waiting_period")]
        public string WaitingPeriod { get; set; }
    }
}
