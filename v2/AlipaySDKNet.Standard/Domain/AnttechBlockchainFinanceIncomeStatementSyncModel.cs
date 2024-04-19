using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceIncomeStatementSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechBlockchainFinanceIncomeStatementSyncModel : AopObject
    {
        /// <summary>
        /// 结算单同步流水号，幂等ID
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 减免金额，单位元
        /// </summary>
        [XmlElement("deduction_amount")]
        public string DeductionAmount { get; set; }

        /// <summary>
        /// 明细合计金额，单位元
        /// </summary>
        [XmlElement("detailed_summary_amount")]
        public string DetailedSummaryAmount { get; set; }

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
        /// 结算单应收金额，按实际结算单应收金额填写，单位元
        /// </summary>
        [XmlElement("receivable_amount")]
        public string ReceivableAmount { get; set; }

        /// <summary>
        /// 结算单明细列表
        /// </summary>
        [XmlElement("statement_detaileds")]
        public StatementDetaileds StatementDetaileds { get; set; }

        /// <summary>
        /// 结算单文件id，按结算单文件提交后返回的fileId填写
        /// </summary>
        [XmlElement("statement_file_id")]
        public string StatementFileId { get; set; }

        /// <summary>
        /// 结算单出具日，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("statement_issue_date")]
        public string StatementIssueDate { get; set; }

        /// <summary>
        /// 结算单编号，按实际结算单编号填写
        /// </summary>
        [XmlElement("statement_no")]
        public string StatementNo { get; set; }

        /// <summary>
        /// 统计结束日期，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("statistics_end_date")]
        public string StatisticsEndDate { get; set; }

        /// <summary>
        /// 统计起始日期，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("statistics_start_date")]
        public string StatisticsStartDate { get; set; }

        /// <summary>
        /// 补收金额，单位元
        /// </summary>
        [XmlElement("supplementary_amount")]
        public string SupplementaryAmount { get; set; }

        /// <summary>
        /// 交易ID，租赁交易登记后返回，结算单同步时填写
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
