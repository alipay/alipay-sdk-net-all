using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantIndirectCollectionAnalysisTimeLineRecord Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantIndirectCollectionAnalysisTimeLineRecord : AopObject
    {
        /// <summary>
        /// 渠道维度 收款摘要信息
        /// </summary>
        [XmlArray("channel_trade")]
        [XmlArrayItem("merchant_indirect_collection_analysis_channel_trade_info")]
        public List<MerchantIndirectCollectionAnalysisChannelTradeInfo> ChannelTrade { get; set; }

        /// <summary>
        /// 同请求中的end_time
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 实收金额，实际到账金额
        /// </summary>
        [XmlElement("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 同请求中的start_time
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 交易金额，累计收款金额
        /// </summary>
        [XmlElement("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 累计收款笔数
        /// </summary>
        [XmlElement("total_trade_count")]
        public long TotalTradeCount { get; set; }
    }
}
