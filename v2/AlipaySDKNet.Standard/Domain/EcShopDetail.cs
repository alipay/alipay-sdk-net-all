using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcShopDetail Data Structure.
    /// </summary>
    [Serializable]
    public class EcShopDetail : AopObject
    {
        /// <summary>
        /// 门店准确度等级，可选值：HIGH - 高；MIDDLE - 中；LOW - 低
        /// </summary>
        [XmlElement("accuracy_level")]
        public string AccuracyLevel { get; set; }

        /// <summary>
        /// 门店参与的营销活动列表
        /// </summary>
        [XmlArray("activity_info_list")]
        [XmlArrayItem("ec_activity_info")]
        public List<EcActivityInfo> ActivityInfoList { get; set; }

        /// <summary>
        /// 企业码门店所在位置的城市编码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 企业码门店所属位置的城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 企业码门店所属位置的地区编码
        /// </summary>
        [XmlElement("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 企业码门店所属位置的地区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 企业码门店是否有营业执照，可选值： true - 是； false - 否
        /// </summary>
        [XmlElement("has_legal_cert_no")]
        public bool HasLegalCertNo { get; set; }

        /// <summary>
        /// 企业码是否有门头照，可选值：true - 是；false - 否
        /// </summary>
        [XmlElement("has_out_door_pic")]
        public bool HasOutDoorPic { get; set; }

        /// <summary>
        /// 企业码门店所属纬度，单位是度
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 企业码门店所属经度，单位是度
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 企业码门店所属经营类目
        /// </summary>
        [XmlArray("mcc_list")]
        [XmlArrayItem("ec_mcc_info")]
        public List<EcMccInfo> MccList { get; set; }

        /// <summary>
        /// 企业码门店所属位置的高德POIID
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 企业码门店所在位置的省份编码
        /// </summary>
        [XmlElement("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 企业码门店所在位置的省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 企业码所属门店地址
        /// </summary>
        [XmlElement("shop_address")]
        public string ShopAddress { get; set; }

        /// <summary>
        /// 企业码门店别名
        /// </summary>
        [XmlElement("shop_alias")]
        public string ShopAlias { get; set; }

        /// <summary>
        /// 企业码门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 企业码门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 企业码门店类型，可选值： 餐饮门店 - MEAL； 理赔医院 - HOSPITAL
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 企业码门店是否支持开票，可选值：true - 是；false - 否
        /// </summary>
        [XmlElement("support_invoice")]
        public bool SupportInvoice { get; set; }

        /// <summary>
        /// 企业码门店的收单身份信息，来源支付宝账号信息
        /// </summary>
        [XmlArray("trade_identity_info_list")]
        [XmlArrayItem("ec_trade_identity_info")]
        public List<EcTradeIdentityInfo> TradeIdentityInfoList { get; set; }

        /// <summary>
        /// 门店商圈信息
        /// </summary>
        [XmlElement("trading_area_info")]
        public EcTradingAreaInfo TradingAreaInfo { get; set; }
    }
}
