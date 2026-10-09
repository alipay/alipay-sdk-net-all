using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataMdaDigitalpayQueryResponse.
    /// </summary>
    public class AlipayDataMdaDigitalpayQueryResponse : AopResponse
    {
        /// <summary>
        /// 亚运村交易笔数
        /// </summary>
        [XmlElement("asian_village_trd_cnt")]
        public long AsianVillageTrdCnt { get; set; }

        /// <summary>
        /// 主媒体中心交易笔数
        /// </summary>
        [XmlElement("mmc_trd_cnt")]
        public long MmcTrdCnt { get; set; }

        /// <summary>
        /// 总交易笔数
        /// </summary>
        [XmlElement("total_trd_cnt")]
        public long TotalTrdCnt { get; set; }

        /// <summary>
        /// 近7天交易趋势
        /// </summary>
        [XmlElement("trd_cnt_trend")]
        public string TrdCntTrend { get; set; }

        /// <summary>
        /// 竞赛场馆交易笔数
        /// </summary>
        [XmlElement("venue_trd_cnt")]
        public long VenueTrdCnt { get; set; }
    }
}
