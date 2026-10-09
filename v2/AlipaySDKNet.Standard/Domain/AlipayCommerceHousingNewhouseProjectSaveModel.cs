using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingNewhouseProjectSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingNewhouseProjectSaveModel : AopObject
    {
        /// <summary>
        /// 楼盘地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 楼盘别名
        /// </summary>
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 楼盘均价(元/平米)
        /// </summary>
        [XmlElement("avg_price")]
        public string AvgPrice { get; set; }

        /// <summary>
        /// 商圈
        /// </summary>
        [XmlElement("business_district")]
        public string BusinessDistrict { get; set; }

        /// <summary>
        /// 城市code
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [XmlElement("contact_person")]
        public string ContactPerson { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("contact_person_phone")]
        public string ContactPersonPhone { get; set; }

        /// <summary>
        /// 占地面积(平米)
        /// </summary>
        [XmlElement("cover_area")]
        public string CoverArea { get; set; }

        /// <summary>
        /// 开发公司
        /// </summary>
        [XmlElement("development_company")]
        public string DevelopmentCompany { get; set; }

        /// <summary>
        /// 区县code
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("estate_project_img")]
        [XmlArrayItem("string")]
        public List<string> EstateProjectImg { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("estate_project_label")]
        [XmlArrayItem("string")]
        public List<string> EstateProjectLabel { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("estate_project_video")]
        [XmlArrayItem("string")]
        public List<string> EstateProjectVideo { get; set; }

        /// <summary>
        /// 外部楼盘id
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 容积率
        /// </summary>
        [XmlElement("floor_area_ratio")]
        public string FloorAreaRatio { get; set; }

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
        /// 楼盘名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("presale_certificate")]
        [XmlArrayItem("string")]
        public List<string> PresaleCertificate { get; set; }

        /// <summary>
        /// 物业费(*元/月)
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
        /// 省code
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 装修
        /// </summary>
        [XmlElement("renovation")]
        public string Renovation { get; set; }

        /// <summary>
        /// 售楼处地址
        /// </summary>
        [XmlElement("sale_address")]
        public string SaleAddress { get; set; }

        /// <summary>
        /// 销售状态
        /// </summary>
        [XmlElement("sale_status")]
        public string SaleStatus { get; set; }

        /// <summary>
        /// 楼盘状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

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
    }
}
