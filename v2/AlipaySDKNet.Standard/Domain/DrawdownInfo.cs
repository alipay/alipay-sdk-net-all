using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DrawdownInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DrawdownInfo : AopObject
    {
        /// <summary>
        /// 实际还款日期
        /// </summary>
        [XmlElement("act_repay_date")]
        public string ActRepayDate { get; set; }

        /// <summary>
        /// 实还利息，单位：元
        /// </summary>
        [XmlElement("actual_inte")]
        public string ActualInte { get; set; }

        /// <summary>
        /// 实还利息罚息（即实还复利），单位：元
        /// </summary>
        [XmlElement("actual_intefine")]
        public string ActualIntefine { get; set; }

        /// <summary>
        /// 实还本金，单位：元
        /// </summary>
        [XmlElement("actual_overdue_corp")]
        public string ActualOverdueCorp { get; set; }

        /// <summary>
        /// 实还本金罚息，单位：元
        /// </summary>
        [XmlElement("actual_overdue_corp_inte")]
        public string ActualOverdueCorpInte { get; set; }

        /// <summary>
        /// 实还违约罚息，单位：元
        /// </summary>
        [XmlElement("actual_poundage_inte")]
        public string ActualPoundageInte { get; set; }

        /// <summary>
        /// 实还服务费（含融担费、保费等），单位：元
        /// </summary>
        [XmlElement("actual_service_fee")]
        public string ActualServiceFee { get; set; }

        /// <summary>
        /// 优惠的金额，单位：元
        /// </summary>
        [XmlElement("exempt_amt")]
        public string ExemptAmt { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }

        /// <summary>
        /// 机构侧借据单号
        /// </summary>
        [XmlElement("org_drawdown_no")]
        public string OrgDrawdownNo { get; set; }

        /// <summary>
        /// 机构侧外部还款单号
        /// </summary>
        [XmlElement("out_repayment_no")]
        public string OutRepaymentNo { get; set; }

        /// <summary>
        /// 提前结清实还违约金，单位：元
        /// </summary>
        [XmlElement("poundage")]
        public string Poundage { get; set; }

        /// <summary>
        /// 总金额，单位：元。= 实还本金 +  实还利息 + 实还服务费 + 提前结清实还违约金 + 实还本金罚息 + 实还利息罚息 + 实还违约罚息- 优惠金额
        /// </summary>
        [XmlElement("total_amt")]
        public string TotalAmt { get; set; }
    }
}
