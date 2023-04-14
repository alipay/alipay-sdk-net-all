using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceOperationPromoterRankingQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationPromoterRankingQueryResponse : AopResponse
    {
        /// <summary>
        /// 排名信息
        /// </summary>
        [XmlElement("ranking_info")]
        public PointRankingInfo RankingInfo { get; set; }
    }
}
