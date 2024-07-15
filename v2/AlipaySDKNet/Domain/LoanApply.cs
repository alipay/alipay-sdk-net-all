using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LoanApply Data Structure.
    /// </summary>
    [Serializable]
    public class LoanApply : AopObject
    {
        /// <summary>
        /// 申请时间
        /// </summary>
        [XmlElement("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 借款申请单号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 银行名称
        /// </summary>
        [XmlElement("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// 授信金额，单位元
        /// </summary>
        [XmlElement("capital_limit")]
        public string CapitalLimit { get; set; }

        /// <summary>
        /// 放款日
        /// </summary>
        [XmlElement("disburse_date")]
        public string DisburseDate { get; set; }

        /// <summary>
        /// 到期日
        /// </summary>
        [XmlElement("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 是否逾期
        /// </summary>
        [XmlElement("is_delinquent")]
        public bool IsDelinquent { get; set; }

        /// <summary>
        /// 借贷申请状态
        /// </summary>
        [XmlElement("load_status")]
        public string LoadStatus { get; set; }

        /// <summary>
        /// 借贷金额，单位元
        /// </summary>
        [XmlElement("loan_amount")]
        public string LoanAmount { get; set; }

        /// <summary>
        /// 银行授信合同编号
        /// </summary>
        [XmlElement("loan_cont_no")]
        public string LoanContNo { get; set; }

        /// <summary>
        /// 借款费率，百分比
        /// </summary>
        [XmlElement("loan_cont_rate")]
        public string LoanContRate { get; set; }

        /// <summary>
        /// 外部业务单号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
