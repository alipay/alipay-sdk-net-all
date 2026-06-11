using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLifeserviceRedemptionQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLifeserviceRedemptionQueryModel : AopObject
    {
        /// <summary>
        /// 兑换码
        /// </summary>
        [XmlElement("redemption_code")]
        public string RedemptionCode { get; set; }
    }
}
