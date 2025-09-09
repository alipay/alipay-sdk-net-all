using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPocketmoneyPromoConsultResponse.
    /// </summary>
    public class AlipayPayAppPocketmoneyPromoConsultResponse : AopResponse
    {
        /// <summary>
        /// 奖品详情
        /// </summary>
        [XmlElement("prize_detail")]
        public WatchPromoPrizeDetail PrizeDetail { get; set; }
    }
}
