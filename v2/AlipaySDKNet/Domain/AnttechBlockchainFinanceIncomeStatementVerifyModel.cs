using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeStatementVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceIncomeStatementVerifyModel : AopObject
    {
        /// <summary>
        /// 核销流水号，幂等ID
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 收益分配产品码，可联系产品或运营同学获取
        /// </summary>
        [XmlElement("distribution_pro_no")]
        public string DistributionProNo { get; set; }

        /// <summary>
        /// 收益分配合约规则ID，可联系产品或运营同学获取
        /// </summary>
        [XmlElement("distribution_rule_id")]
        public string DistributionRuleId { get; set; }

        /// <summary>
        /// 结算单编号，同结算单同步时的编号
        /// </summary>
        [XmlElement("statement_no")]
        public string StatementNo { get; set; }

        /// <summary>
        /// 交易ID，租赁交易登记后返回，按返回ID填写
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 核销金额，单位元
        /// </summary>
        [XmlElement("write_off_amount")]
        public string WriteOffAmount { get; set; }

        /// <summary>
        /// 核销时间，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("write_off_time")]
        public string WriteOffTime { get; set; }
    }
}
