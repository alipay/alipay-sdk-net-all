using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntfortuneEquityInstpointPrizeQueryResponse.
    /// </summary>
    public class AntfortuneEquityInstpointPrizeQueryResponse : AopResponse
    {
        /// <summary>
        /// 积分可兑换奖品列表
        /// </summary>
        [XmlArray("prize_info")]
        [XmlArrayItem("point_prize_info")]
        public List<PointPrizeInfo> PrizeInfo { get; set; }

        /// <summary>
        /// 可兑换奖品总数
        /// </summary>
        [XmlElement("total_count")]
        public string TotalCount { get; set; }
    }
}
