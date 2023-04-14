using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarRentalStoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarRentalStoreInfo : AopObject
    {
        /// <summary>
        /// 门店营业时间
        /// </summary>
        [XmlElement("business_hours")]
        public BusinessHoursInfo BusinessHours { get; set; }

        /// <summary>
        /// 支付宝门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店地址信息
        /// </summary>
        [XmlElement("store_address_info")]
        public StoreAddressInfo StoreAddressInfo { get; set; }

        /// <summary>
        /// 门店城市
        /// </summary>
        [XmlElement("store_city")]
        public string StoreCity { get; set; }

        /// <summary>
        /// 门店扩展字段，key：store_marking，value：pre_authorization
        /// </summary>
        [XmlArray("store_extra_info")]
        [XmlArrayItem("extra_info")]
        public List<ExtraInfo> StoreExtraInfo { get; set; }

        /// <summary>
        /// 商家门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店电话 支持固话或者个人用户手机号
        /// </summary>
        [XmlElement("store_phone")]
        public string StorePhone { get; set; }
    }
}
