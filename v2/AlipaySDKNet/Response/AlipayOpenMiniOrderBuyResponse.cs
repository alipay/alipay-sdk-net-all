using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenMiniOrderBuyResponse.
    /// </summary>
    public class AlipayOpenMiniOrderBuyResponse : AopResponse
    {
        /// <summary>
        /// 合并交易号
        /// </summary>
        [XmlElement("merge_trade_no")]
        public string MergeTradeNo { get; set; }

        /// <summary>
        /// 聚合交易子订单信息列表
        /// </summary>
        [XmlArray("mini_trade_create_responses")]
        [XmlArrayItem("order_buy_response")]
        public List<OrderBuyResponse> MiniTradeCreateResponses { get; set; }

        /// <summary>
        /// 合并交易号的业务类型
        /// </summary>
        [XmlElement("trade_no_biz_type")]
        public string TradeNoBizType { get; set; }
    }
}
