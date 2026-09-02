using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoanCostDisclosureInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LoanCostDisclosureInfo : AopObject
    {
        /// <summary>
        /// 综合服务费率是否有盖帽
        /// </summary>
        [XmlElement("capped")]
        public bool Capped { get; set; }

        /// <summary>
        /// 综合融资成本率，正常履约年化综合融资成本，小数格式
        /// </summary>
        [XmlElement("cost_rate")]
        public string CostRate { get; set; }

        /// <summary>
        /// 担保费收取主体（机构简称）
        /// </summary>
        [XmlElement("guarantee_fee_org_name")]
        public string GuaranteeFeeOrgName { get; set; }

        /// <summary>
        /// 担保费年化费率，小数格式
        /// </summary>
        [XmlElement("guarantee_fee_rate")]
        public string GuaranteeFeeRate { get; set; }

        /// <summary>
        /// 担保费利率类型
        /// </summary>
        [XmlElement("guarantee_fee_rate_type")]
        public string GuaranteeFeeRateType { get; set; }

        /// <summary>
        /// 担保费还款方式
        /// </summary>
        [XmlElement("guarantee_fee_repay_mode")]
        public string GuaranteeFeeRepayMode { get; set; }

        /// <summary>
        /// 贷款利息收取主体（机构简称）
        /// </summary>
        [XmlElement("loan_interest_org_name")]
        public string LoanInterestOrgName { get; set; }

        /// <summary>
        /// 贷款年化利率，小数格式
        /// </summary>
        [XmlElement("loan_interest_rate")]
        public string LoanInterestRate { get; set; }

        /// <summary>
        /// 贷款利率类型
        /// </summary>
        [XmlElement("loan_interest_rate_type")]
        public string LoanInterestRateType { get; set; }

        /// <summary>
        /// 贷款利率还款方式
        /// </summary>
        [XmlElement("loan_interest_repay_mode")]
        public string LoanInterestRepayMode { get; set; }

        /// <summary>
        /// 挪用罚息收取主体（机构简称）
        /// </summary>
        [XmlElement("misappropriation_penalty_interest_org_name")]
        public string MisappropriationPenaltyInterestOrgName { get; set; }

        /// <summary>
        /// 挪用罚息利率及上浮比例和具体文案
        /// </summary>
        [XmlElement("misappropriation_penalty_interest_text")]
        public string MisappropriationPenaltyInterestText { get; set; }

        /// <summary>
        /// 其他费用收取主体（机构简称）
        /// </summary>
        [XmlElement("other_fee_org_name")]
        public string OtherFeeOrgName { get; set; }

        /// <summary>
        /// 其他费用具体文案
        /// </summary>
        [XmlElement("other_fee_text")]
        public string OtherFeeText { get; set; }

        /// <summary>
        /// 逾期罚息收取主体（机构简称）
        /// </summary>
        [XmlElement("overdue_penalty_interest_org_name")]
        public string OverduePenaltyInterestOrgName { get; set; }

        /// <summary>
        /// 逾期罚息利率及上浮比例和具体文案
        /// </summary>
        [XmlElement("overdue_penalty_interest_text")]
        public string OverduePenaltyInterestText { get; set; }

        /// <summary>
        /// 提前结清违约金/提前还款手续费费项名称
        /// </summary>
        [XmlElement("prepayment_penalty_name")]
        public string PrepaymentPenaltyName { get; set; }

        /// <summary>
        /// 提前结清违约金收取主体（机构简称）
        /// </summary>
        [XmlElement("prepayment_penalty_org_name")]
        public string PrepaymentPenaltyOrgName { get; set; }

        /// <summary>
        /// 提前结清违约金费率/收取标准和具体文案
        /// </summary>
        [XmlElement("prepayment_penalty_text")]
        public string PrepaymentPenaltyText { get; set; }
    }
}
