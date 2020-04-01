using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPromoIntelligentguideConsultModel : AopObject
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 口碑shopId
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
