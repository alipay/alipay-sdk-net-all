using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMarketingIotMerchantplanCreateormodifyResponse.
    /// </summary>
    public class AlipayMarketingIotMerchantplanCreateormodifyResponse : AopResponse
    {
        /// <summary>
        /// 商家活动ID
        /// </summary>
        [XmlElement("merchant_plan_id")]
        public string MerchantPlanId { get; set; }
    }
}
