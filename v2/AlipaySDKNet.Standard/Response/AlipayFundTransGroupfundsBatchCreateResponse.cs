using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFundTransGroupfundsBatchCreateResponse.
    /// </summary>
    public class AlipayFundTransGroupfundsBatchCreateResponse : AopResponse
    {
        /// <summary>
        /// 团体资金批次号,后续业务流水以及预付款业务透传
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 当前批次创建者所关联的资金单据
        /// </summary>
        [XmlElement("current_fund_bill")]
        public GroupFundBill CurrentFundBill { get; set; }

        /// <summary>
        /// 当前批次对应的所有资金单据
        /// </summary>
        [XmlArray("fund_bills")]
        [XmlArrayItem("group_fund_bill")]
        public List<GroupFundBill> FundBills { get; set; }
    }
}
