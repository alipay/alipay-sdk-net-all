using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RepayBankInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RepayBankInfo : AopObject
    {
        /// <summary>
        /// 还款银行编码
        /// </summary>
        [XmlElement("repay_bank_code")]
        public string RepayBankCode { get; set; }

        /// <summary>
        /// 还款银行分行名称
        /// </summary>
        [XmlElement("repay_branch_name")]
        public string RepayBranchName { get; set; }

        /// <summary>
        /// 还款银行所在城市
        /// </summary>
        [XmlElement("repay_city")]
        public string RepayCity { get; set; }

        /// <summary>
        /// 还款银行机构ID
        /// </summary>
        [XmlElement("repay_inst_id")]
        public string RepayInstId { get; set; }

        /// <summary>
        /// 还款账户
        /// </summary>
        [XmlElement("repay_name")]
        public string RepayName { get; set; }

        /// <summary>
        /// 还款账号
        /// </summary>
        [XmlElement("repay_no")]
        public string RepayNo { get; set; }

        /// <summary>
        /// 还款银行所在省
        /// </summary>
        [XmlElement("repay_province")]
        public string RepayProvince { get; set; }
    }
}
