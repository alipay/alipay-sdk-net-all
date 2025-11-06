using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandDigitalgroupShopQueryResponse.
    /// </summary>
    public class AntMerchantExpandDigitalgroupShopQueryResponse : AopResponse
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店经营时间
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [XmlElement("category_final")]
        public string CategoryFinal { get; set; }

        /// <summary>
        /// 餐饮
        /// </summary>
        [XmlElement("category_one")]
        public string CategoryOne { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 店铺联系电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 数字化门店ID
        /// </summary>
        [XmlElement("digital_poi_id")]
        public string DigitalPoiId { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 高德门店名称
        /// </summary>
        [XmlElement("g_name")]
        public string GName { get; set; }

        /// <summary>
        /// 高德门店ID
        /// </summary>
        [XmlElement("g_shopid")]
        public string GShopid { get; set; }

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
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 门店经营状态
        /// </summary>
        [XmlElement("shop_business_status")]
        public string ShopBusinessStatus { get; set; }

        /// <summary>
        /// 门店状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
