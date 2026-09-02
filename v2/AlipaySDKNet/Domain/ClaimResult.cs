using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimResult Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimResult : AopObject
    {
        /// <summary>
        /// 理赔申请号（保司)
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 支付宝生成的业务流水号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 报案号（保司）
        /// </summary>
        [XmlElement("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 理赔状态
        /// </summary>
        [XmlElement("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 保司类型
        /// </summary>
        [XmlElement("company_type")]
        public string CompanyType { get; set; }

        /// <summary>
        /// 挂号流水号,同就诊id
        /// </summary>
        [XmlElement("mdtrt_id")]
        public string MdtrtId { get; set; }

        /// <summary>
        /// 保单信息
        /// </summary>
        [XmlElement("policy_info")]
        public ClaimResultPolicyInfo PolicyInfo { get; set; }

        /// <summary>
        /// 报案状态字段。非枚举类型
        /// </summary>
        [XmlElement("report_status")]
        public string ReportStatus { get; set; }
    }
}
