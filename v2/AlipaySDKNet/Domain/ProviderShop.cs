using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ProviderShop Data Structure.
    /// </summary>
    [Serializable]
    public class ProviderShop : AopObject
    {
        /// <summary>
        /// 门店营业时间
        /// </summary>
        [XmlElement("business_hours")]
        public string BusinessHours { get; set; }

        /// <summary>
        /// 商家门店营业周期
        /// </summary>
        [XmlElement("business_weeks")]
        public string BusinessWeeks { get; set; }

        /// <summary>
        /// 商家门店详细地址
        /// </summary>
        [XmlElement("detail_address")]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 门店区域
        /// </summary>
        [XmlElement("shop_area")]
        public string ShopArea { get; set; }

        /// <summary>
        /// 商家门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店电话
        /// </summary>
        [XmlElement("shop_phone_num")]
        public string ShopPhoneNum { get; set; }
    }
}
