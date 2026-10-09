using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PromoActivityItemAttrRequest Data Structure.
    /// </summary>
    [Serializable]
    public class PromoActivityItemAttrRequest : AopObject
    {
        /// <summary>
        /// 属性列表
        /// </summary>
        [XmlArray("activity_attr_list")]
        [XmlArrayItem("promo_activity_attr_request")]
        public List<PromoActivityAttrRequest> ActivityAttrList { get; set; }

        /// <summary>
        /// 支付宝平台侧商品ID，是支付宝平台侧商品的唯一标识，后续与平台交互，需要使用该 ID，建议持久化。该字段特殊可选，与out_item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商家侧商品ID，要求 APPID 下全局唯一。该字段特殊可选，与item_id不能同时为空，优先使用item_id。
        /// </summary>
        [XmlElement("out_item_id")]
        public string OutItemId { get; set; }
    }
}
