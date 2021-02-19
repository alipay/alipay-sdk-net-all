using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingIotMerchantplanCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingIotMerchantplanCancelModel : AopObject
    {
        /// <summary>
        /// 商家活动ID
        /// </summary>
        [XmlElement("merchant_plan_id")]
        public string MerchantPlanId { get; set; }
    }
}
