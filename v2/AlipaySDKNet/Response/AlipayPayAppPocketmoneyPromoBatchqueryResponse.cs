using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayPayAppPocketmoneyPromoBatchqueryResponse.
    /// </summary>
    public class AlipayPayAppPocketmoneyPromoBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 奖品列表
        /// </summary>
        [XmlArray("prize_list")]
        [XmlArrayItem("watch_promo_prize_detail")]
        public List<WatchPromoPrizeDetail> PrizeList { get; set; }
    }
}
