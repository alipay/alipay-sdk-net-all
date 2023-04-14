using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MemberCardPayEffectiveShopRule Data Structure.
    /// </summary>
    [Serializable]
    public class MemberCardPayEffectiveShopRule : AopObject
    {
        /// <summary>
        /// 线下店id列表，列表最大长度5000
        /// </summary>
        [XmlArray("shop_ids")]
        [XmlArrayItem("string")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
