using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideOrderModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiServindustryPromoIntelligentguideOrderModel : AopObject
    {
        /// <summary>
        /// 枚举类型，目前仅支持半年(HALF_YEAR)和一年(ONE_YEAR)，使用前先确认是否有相对应的份额
        /// </summary>
        [XmlElement("range_type")]
        public string RangeType { get; set; }

        /// <summary>
        /// 口碑侧门店shopId
        /// </summary>
        [XmlArray("shop_id")]
        [XmlArrayItem("string")]
        public List<string> ShopId { get; set; }
    }
}
