using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaTorchreplayequityQueryResponse.
    /// </summary>
    public class AlipayDataMdaTorchreplayequityQueryResponse : AopResponse
    {
        /// <summary>
        /// 领取权益奖品分布
        /// </summary>
        [XmlElement("equity_prize_distribute")]
        public string EquityPrizeDistribute { get; set; }

        /// <summary>
        /// 领取权益用户次数
        /// </summary>
        [XmlElement("equity_pv")]
        public long EquityPv { get; set; }

        /// <summary>
        /// 领取权益用户数
        /// </summary>
        [XmlElement("equity_uv")]
        public long EquityUv { get; set; }

        /// <summary>
        /// 搜索用户数
        /// </summary>
        [XmlElement("search_uv")]
        public long SearchUv { get; set; }

        /// <summary>
        /// 搜索用户趋势
        /// </summary>
        [XmlElement("search_uv_trend")]
        public string SearchUvTrend { get; set; }

        /// <summary>
        /// 火炬手服装数
        /// </summary>
        [XmlElement("torchbearer_clothing_cnt")]
        public long TorchbearerClothingCnt { get; set; }
    }
}
