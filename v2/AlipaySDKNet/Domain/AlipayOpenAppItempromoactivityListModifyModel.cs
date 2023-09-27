using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppItempromoactivityListModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppItempromoactivityListModifyModel : AopObject
    {
        /// <summary>
        /// 提报的属性信息
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
