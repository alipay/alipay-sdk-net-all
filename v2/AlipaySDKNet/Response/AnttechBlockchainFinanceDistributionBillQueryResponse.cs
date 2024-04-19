using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceDistributionBillQueryResponse.
    /// </summary>
    public class AnttechBlockchainFinanceDistributionBillQueryResponse : AopResponse
    {
        /// <summary>
        /// 来自于结算单核销流水金额,单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 收益分配订单号
        /// </summary>
        [XmlElement("distribution_order_id")]
        public string DistributionOrderId { get; set; }

        /// <summary>
        /// 收益分配规则Id
        /// </summary>
        [XmlElement("distribution_rule_id")]
        public string DistributionRuleId { get; set; }

        /// <summary>
        /// 关联的结算单编号
        /// </summary>
        [XmlElement("statement_no")]
        public string StatementNo { get; set; }

        /// <summary>
        /// 01-初始；02-执行中；03-执行成功；04-执行失败；
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }

        /// <summary>
        /// 收款方详情
        /// </summary>
        [XmlArray("trans_in_detail_list")]
        [XmlArrayItem("income_distribution_order_trans_in_detail")]
        public List<IncomeDistributionOrderTransInDetail> TransInDetailList { get; set; }

        /// <summary>
        /// 分出方账号
        /// </summary>
        [XmlElement("trans_out_account_no")]
        public string TransOutAccountNo { get; set; }

        /// <summary>
        /// 分出方账号类型 01-数币子钱包 02-支付宝账户 03-外部银行账户 04-标准数币钱包
        /// </summary>
        [XmlElement("trans_out_account_type")]
        public string TransOutAccountType { get; set; }

        /// <summary>
        /// 分出方名称
        /// </summary>
        [XmlElement("trans_out_name")]
        public string TransOutName { get; set; }

        /// <summary>
        /// 关联的结算单核销流水号
        /// </summary>
        [XmlElement("write_off_biz_no")]
        public string WriteOffBizNo { get; set; }
    }
}
