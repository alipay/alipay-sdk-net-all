using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivitySettleQueryResponse.
    /// </summary>
    public class AlipayMarketingActivitySettleQueryResponse : AopResponse
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 兑换券发起结算之后的每笔订单的资金结算明细，如入账，结算金额等
        /// </summary>
        [XmlArray("settle_info")]
        [XmlArrayItem("biz_fund_settle_detail_info")]
        public List<BizFundSettleDetailInfo> SettleInfo { get; set; }

        /// <summary>
        /// 兑换券发起结算之后关于结算的汇总信息的描述
        /// </summary>
        [XmlElement("summary")]
        public BizFundSettleSummary Summary { get; set; }
    }
}
