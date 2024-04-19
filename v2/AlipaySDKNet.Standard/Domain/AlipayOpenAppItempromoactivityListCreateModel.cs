using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityListCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItempromoactivityListCreateModel : AopObject
    {
        /// <summary>
        /// 批量创建商品营销活动记录
        /// </summary>
        [XmlArray("item_attr_list")]
        [XmlArrayItem("promo_activity_item_attr_request")]
        public List<PromoActivityItemAttrRequest> ItemAttrList { get; set; }

        /// <summary>
        /// 营销活动类型
        /// </summary>
        [XmlElement("promotion_type")]
        public string PromotionType { get; set; }
    }
}
