using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingActivityDeductConsultResponse.
    /// </summary>
    public class AlipayMarketingActivityDeductConsultResponse : AopResponse
    {
        /// <summary>
        /// 最优券叠加总优惠金额，单位为元
        /// </summary>
        [XmlElement("optimal_total_promo_amount")]
        public string OptimalTotalPromoAmount { get; set; }
    }
}
