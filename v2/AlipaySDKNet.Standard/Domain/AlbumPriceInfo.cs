using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlbumPriceInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AlbumPriceInfo : AopObject
    {
        /// <summary>
        /// 已废弃。营销活动实际价格填写在promo_info中的discount_price
        /// </summary>
        [XmlElement("actual_price")]
        public string ActualPrice { get; set; }

        /// <summary>
        /// 仅面向专辑购买时无法通过专辑ID发起的场景，无相关需求可不填。
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 专辑原价。单位元，最多两位小数。收费专辑必填。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 销售方式：ALBUM（专辑整本售卖）、SINGLE_SOUND（单集售卖）； 收费专辑必填。
        /// </summary>
        [XmlElement("sell_type")]
        public string SellType { get; set; }
    }
}
