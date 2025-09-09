using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportEbikerentalStoreSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportEbikerentalStoreSyncModel : AopObject
    {
        /// <summary>
        /// 营业时间
        /// </summary>
        [XmlElement("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 门店所在城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 门店所在城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 其他支持还车的门店id集合
        /// </summary>
        [XmlArray("other_return_store_ids")]
        [XmlArrayItem("string")]
        public List<string> OtherReturnStoreIds { get; set; }

        /// <summary>
        /// 门店所在省份编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门店所在省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 服务商
        /// </summary>
        [XmlElement("service_provider")]
        public string ServiceProvider { get; set; }

        /// <summary>
        /// 正常服务：in_service 暂停服务：stop_service
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 门店详细地址
        /// </summary>
        [XmlElement("store_address")]
        public string StoreAddress { get; set; }

        /// <summary>
        /// 门店联系方式
        /// </summary>
        [XmlElement("store_contact")]
        public string StoreContact { get; set; }

        /// <summary>
        /// 门店车辆配置标签集合
        /// </summary>
        [XmlElement("store_ebike_config_tags")]
        public string StoreEbikeConfigTags { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 店铺门头照
        /// </summary>
        [XmlElement("store_image_url")]
        public string StoreImageUrl { get; set; }

        /// <summary>
        /// 门店具体位置经纬度坐标
        /// </summary>
        [XmlElement("store_location_coordinates")]
        public string StoreLocationCoordinates { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 门店服务标签集合
        /// </summary>
        [XmlElement("store_service_tags")]
        public string StoreServiceTags { get; set; }

        /// <summary>
        /// Y：支持多店还车 N：不支持多店还车
        /// </summary>
        [XmlElement("support_multiple_stores_return_flag")]
        public string SupportMultipleStoresReturnFlag { get; set; }

        /// <summary>
        /// 数据同步类型
        /// </summary>
        [XmlElement("sync_type")]
        public string SyncType { get; set; }
    }
}
