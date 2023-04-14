using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityShopInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityShopInfo : AopObject
    {
        /// <summary>
        /// 纬度，浮点型,小数点后最多保留6位
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，浮点型, 小数点后最多保留6位。
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 支付宝侧蚂蚁店铺 id。
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称。
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店类型 PAYMENT_SHOP 支付门店 REAL_SHOP 代运营商业关系门店
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }
    }
}
