using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityListDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItempromoactivityListDeleteModel : AopObject
    {
        /// <summary>
        /// 商品及其属性列表
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("promo_activity_item_request")]
        public List<PromoActivityItemRequest> ItemList { get; set; }

        /// <summary>
        /// 营销活动类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }
    }
}
