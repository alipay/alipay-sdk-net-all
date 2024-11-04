using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AnttechBlockchainFinanceTvpAccountbalanceReleaseResponse.
    /// </summary>
    public class AnttechBlockchainFinanceTvpAccountbalanceReleaseResponse : AopResponse
    {
        /// <summary>
        /// 机构侧资金释放流水
        /// </summary>
        [XmlElement("channel_order_id")]
        public string ChannelOrderId { get; set; }

        /// <summary>
        /// 释放成功
        /// </summary>
        [XmlElement("fund_status")]
        public string FundStatus { get; set; }
    }
}
