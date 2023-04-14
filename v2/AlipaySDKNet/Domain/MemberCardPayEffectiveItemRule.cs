using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardPayEffectiveItemRule Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardPayEffectiveItemRule : AopObject
    {
        /// <summary>
        /// 统一支付下单传递进来的商品编号，最大列表长度10000
        /// </summary>
        [XmlArray("exclude_item_ids")]
        [XmlArrayItem("string")]
        public List<string> ExcludeItemIds { get; set; }

        /// <summary>
        /// 统一支付下单传递进来的商品编号，最大列表长度10000
        /// </summary>
        [XmlArray("item_ids")]
        [XmlArrayItem("string")]
        public List<string> ItemIds { get; set; }
    }
}
