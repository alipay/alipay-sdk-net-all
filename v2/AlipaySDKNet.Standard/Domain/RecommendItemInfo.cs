using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RecommendItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendItemInfo : AopObject
    {
        /// <summary>
        /// 用户要对自己的手机号进行充值的面额
        /// </summary>
        [XmlElement("face")]
        public string Face { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 当前面额的价格为50元
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }
    }
}
