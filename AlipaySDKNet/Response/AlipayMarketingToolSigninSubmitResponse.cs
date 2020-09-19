using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingToolSigninSubmitResponse.
    /// </summary>
    public class AlipayMarketingToolSigninSubmitResponse : AopResponse
    {
        /// <summary>
        /// 发奖单据。
        /// </summary>
        [XmlArray("prize_orders")]
        [XmlArrayItem("prize_order_v_o")]
        public List<PrizeOrderVO> PrizeOrders { get; set; }
    }
}
