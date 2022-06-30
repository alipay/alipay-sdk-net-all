using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportPromotionRecommendQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportPromotionRecommendQueryModel : AopObject
    {
        /// <summary>
        /// 金额，只支持两位小数点的正数
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }
    }
}
