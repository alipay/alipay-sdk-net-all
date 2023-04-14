using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityGoodsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityGoodsInfo : AopObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }

        /// <summary>
        /// 活动单品类型。 枚举值: AVAILABLE可用单品 UNAVAILABLE不可用单品
        /// </summary>
        [XmlElement("goods_use_type")]
        public string GoodsUseType { get; set; }
    }
}
