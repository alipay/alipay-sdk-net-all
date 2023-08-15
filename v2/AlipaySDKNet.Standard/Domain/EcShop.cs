using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EcShop Data Structure.
    /// </summary>
    [Serializable]
    public class EcShop : AopObject
    {
        /// <summary>
        /// 门店地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 门店品牌id
        /// </summary>
        [XmlElement("brand_id")]
        public string BrandId { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 门店距离，单位km
        /// </summary>
        [XmlElement("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        [XmlElement("district_id")]
        public string DistrictId { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [XmlElement("district_name")]
        public string DistrictName { get; set; }

        /// <summary>
        /// 企业码门店id
        /// </summary>
        [XmlElement("ec_shop_id")]
        public string EcShopId { get; set; }

        /// <summary>
        /// 费用类型子类
        /// </summary>
        [XmlElement("expense_type_sub_category")]
        public string ExpenseTypeSubCategory { get; set; }

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
        /// 一级mcc类目编码
        /// </summary>
        [XmlElement("mcc_code_1")]
        public string MccCode1 { get; set; }

        /// <summary>
        /// 二级mcc类目编码
        /// </summary>
        [XmlElement("mcc_code_2")]
        public string MccCode2 { get; set; }

        /// <summary>
        /// 一级mcc类目名称
        /// </summary>
        [XmlElement("mcc_name_1")]
        public string MccName1 { get; set; }

        /// <summary>
        /// 二级mcc类目名称
        /// </summary>
        [XmlElement("mcc_name_2")]
        public string MccName2 { get; set; }

        /// <summary>
        /// 门头照地址
        /// </summary>
        [XmlElement("outdoor_img_url")]
        public string OutdoorImgUrl { get; set; }

        /// <summary>
        /// 门店联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// poiId
        /// </summary>
        [XmlElement("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        [XmlElement("province_id")]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店产品类型,不传默认3
        /// </summary>
        [XmlElement("shop_product")]
        public string ShopProduct { get; set; }

        /// <summary>
        /// 门店收单身份信息
        /// </summary>
        [XmlElement("shop_trade_info_list")]
        public TradeIdentityInfo ShopTradeInfoList { get; set; }
    }
}
