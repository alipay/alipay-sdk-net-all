using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CommunityModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class CommunityModelDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("apartment_facilities")]
        [XmlArrayItem("string")]
        public List<string> ApartmentFacilities { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("apartment_services")]
        [XmlArrayItem("string")]
        public List<string> ApartmentServices { get; set; }

        /// <summary>
        /// 小区均价，单位，***元/平米
        /// </summary>
        [XmlElement("avg_price")]
        public string AvgPrice { get; set; }

        /// <summary>
        /// 商圈
        /// </summary>
        [XmlElement("business_district")]
        public string BusinessDistrict { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 是否封闭
        /// </summary>
        [XmlElement("closed_community")]
        public string ClosedCommunity { get; set; }

        /// <summary>
        /// 小区地址
        /// </summary>
        [XmlElement("community_address")]
        public string CommunityAddress { get; set; }

        /// <summary>
        /// 小区别名
        /// </summary>
        [XmlElement("community_alias")]
        public string CommunityAlias { get; set; }

        /// <summary>
        /// 小区id
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("community_img")]
        [XmlArrayItem("string")]
        public List<string> CommunityImg { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("community_label")]
        [XmlArrayItem("string")]
        public List<string> CommunityLabel { get; set; }

        /// <summary>
        /// 小区名称
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 小区评价
        /// </summary>
        [XmlElement("community_reviews")]
        public string CommunityReviews { get; set; }

        /// <summary>
        /// 小区状态(生效：TAKE_EFFECT 失效：INVALID)
        /// </summary>
        [XmlElement("community_status")]
        public string CommunityStatus { get; set; }

        /// <summary>
        /// 小区类型，默认类型COMMUNITY
        /// </summary>
        [XmlElement("community_type")]
        public string CommunityType { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("community_video")]
        [XmlArrayItem("string")]
        public List<string> CommunityVideo { get; set; }

        /// <summary>
        /// 建筑年代
        /// </summary>
        [XmlElement("construction_year")]
        public string ConstructionYear { get; set; }

        /// <summary>
        /// 关联联系人
        /// </summary>
        [XmlElement("contact_person")]
        public string ContactPerson { get; set; }

        /// <summary>
        /// 关联联系人电话
        /// </summary>
        [XmlElement("contact_person_phone")]
        public string ContactPersonPhone { get; set; }

        /// <summary>
        /// 开发公司
        /// </summary>
        [XmlElement("development_company")]
        public string DevelopmentCompany { get; set; }

        /// <summary>
        /// 商圈
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 用电类型
        /// </summary>
        [XmlElement("electricity_type")]
        public string ElectricityType { get; set; }

        /// <summary>
        /// 外部小区编码
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 容积率
        /// </summary>
        [XmlElement("floor_area_ratio")]
        public string FloorAreaRatio { get; set; }

        /// <summary>
        /// 燃气费，单位：**元/立方米
        /// </summary>
        [XmlElement("gas_fee")]
        public string GasFee { get; set; }

        /// <summary>
        /// 绿化率
        /// </summary>
        [XmlElement("greenery_ratio")]
        public string GreeneryRatio { get; set; }

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
        /// 人车分流
        /// </summary>
        [XmlElement("pedestrian_vehicle_separation")]
        public string PedestrianVehicleSeparation { get; set; }

        /// <summary>
        /// 物业公司
        /// </summary>
        [XmlElement("property_management_company")]
        public string PropertyManagementCompany { get; set; }

        /// <summary>
        /// 物业费，单位，**元/月/平米
        /// </summary>
        [XmlElement("property_management_fee")]
        public string PropertyManagementFee { get; set; }

        /// <summary>
        /// 产权年限
        /// </summary>
        [XmlElement("property_right_year")]
        public string PropertyRightYear { get; set; }

        /// <summary>
        /// 物业类型
        /// </summary>
        [XmlElement("property_type")]
        public string PropertyType { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 总栋数
        /// </summary>
        [XmlElement("sum_buildings")]
        public string SumBuildings { get; set; }

        /// <summary>
        /// 总户数
        /// </summary>
        [XmlElement("sum_units")]
        public string SumUnits { get; set; }

        /// <summary>
        /// 供给公司
        /// </summary>
        [XmlElement("supply_company")]
        public string SupplyCompany { get; set; }

        /// <summary>
        /// 车户比，单位：个
        /// </summary>
        [XmlElement("vehicle_unit_ratio")]
        public string VehicleUnitRatio { get; set; }

        /// <summary>
        /// 用水类型
        /// </summary>
        [XmlElement("water_type")]
        public string WaterType { get; set; }
    }
}
