using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransGroupfundsFundbillsQueryResponse.
    /// </summary>
    public class AlipayFundTransGroupfundsFundbillsQueryResponse : AopResponse
    {
        /// <summary>
        /// 批次状态,包括:  COLLECT:收款中, COLLECT_SUC: 全部收款完成, PAYMENT_SUC: 全部付款完成, CLOSE: 超时收款未完成已关闭，REFUND：付款部分未成功,部分退款
        /// </summary>
        [XmlElement("batch_status")]
        public string BatchStatus { get; set; }

        /// <summary>
        /// 当前查询用户关联的资金单据
        /// </summary>
        [XmlElement("current_fund_bill")]
        public GroupFundBill CurrentFundBill { get; set; }

        /// <summary>
        /// 当前活动所关联的所有付款/收款单据
        /// </summary>
        [XmlArray("fund_bills")]
        [XmlArrayItem("group_fund_bill")]
        public List<GroupFundBill> FundBills { get; set; }

        /// <summary>
        /// 批次是否过期
        /// </summary>
        [XmlElement("timeout")]
        public bool Timeout { get; set; }
    }
}
