using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ApartmentModelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ApartmentModelDTO : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("accommodation")]
        [XmlArrayItem("string")]
        public List<string> Accommodation { get; set; }

        /// <summary>
        /// 公寓地址
        /// </summary>
        [XmlElement("apartment_address")]
        public string ApartmentAddress { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("apartment_facilities")]
        [XmlArrayItem("string")]
        public List<string> ApartmentFacilities { get; set; }

        /// <summary>
        /// 房源唯一编码
        /// </summary>
        [XmlElement("apartment_id")]
        public string ApartmentId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("apartment_img")]
        [XmlArrayItem("string")]
        public List<string> ApartmentImg { get; set; }

        /// <summary>
        /// 泊寓**店，**安居集团**项目
        /// </summary>
        [XmlElement("apartment_name")]
        public string ApartmentName { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("apartment_services")]
        [XmlArrayItem("string")]
        public List<string> ApartmentServices { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("apartment_video")]
        [XmlArrayItem("string")]
        public List<string> ApartmentVideo { get; set; }

        /// <summary>
        /// 公寓vr地址
        /// </summary>
        [XmlElement("apartment_vr")]
        public string ApartmentVr { get; set; }

        /// <summary>
        /// 居室数量
        /// </summary>
        [XmlElement("bed_room")]
        public string BedRoom { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [XmlElement("business_district")]
        public string BusinessDistrict { get; set; }

        /// <summary>
        /// 城市编码
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
        /// 联系人备案照片(文件id)
        /// </summary>
        [XmlElement("contact_persons_photo")]
        public string ContactPersonsPhoto { get; set; }

        /// <summary>
        /// 区县编码
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 梯户比例，例：一梯两户
        /// </summary>
        [XmlElement("elevator_to_unit_ratio")]
        public string ElevatorToUnitRatio { get; set; }

        /// <summary>
        /// 外部房源ID
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 楼层区间-结束值,例：5-8层
        /// </summary>
        [XmlElement("floor_end")]
        public string FloorEnd { get; set; }

        /// <summary>
        /// 楼层区间-起始值,例：5-8层
        /// </summary>
        [XmlElement("floor_start")]
        public string FloorStart { get; set; }

        /// <summary>
        /// 对房源特色的简短描述
        /// </summary>
        [XmlElement("house_label")]
        public string HouseLabel { get; set; }

        /// <summary>
        /// 关联小程序ID
        /// </summary>
        [XmlElement("house_program_id")]
        public string HouseProgramId { get; set; }

        /// <summary>
        /// 房屋结构
        /// </summary>
        [XmlElement("house_structure")]
        public string HouseStructure { get; set; }

        /// <summary>
        /// 房源类型
        /// </summary>
        [XmlElement("housing_type")]
        public string HousingType { get; set; }

        /// <summary>
        /// 意向申请
        /// </summary>
        [XmlElement("intentional_application")]
        public string IntentionalApplication { get; set; }

        /// <summary>
        /// 朝向
        /// </summary>
        [XmlElement("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// 其他信息
        /// </summary>
        [XmlElement("other")]
        public string Other { get; set; }

        /// <summary>
        /// 户型介绍
        /// </summary>
        [XmlElement("property_description")]
        public string PropertyDescription { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("property_features")]
        [XmlArrayItem("string")]
        public List<string> PropertyFeatures { get; set; }

        /// <summary>
        /// 房源标题
        /// </summary>
        [XmlElement("property_title")]
        public string PropertyTitle { get; set; }

        /// <summary>
        /// 省编码
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 户籍等，描述文字
        /// </summary>
        [XmlElement("qualification_requirements")]
        public string QualificationRequirements { get; set; }

        /// <summary>
        /// 租金区间段-结束值(元)
        /// </summary>
        [XmlElement("rent_end")]
        public string RentEnd { get; set; }

        /// <summary>
        /// 租金区间段-起始值(元)
        /// </summary>
        [XmlElement("rent_start")]
        public string RentStart { get; set; }

        /// <summary>
        /// 租金单位
        /// </summary>
        [XmlElement("rent_unit")]
        public string RentUnit { get; set; }

        /// <summary>
        /// 房源所属平台，用于前端展示。
        /// </summary>
        [XmlElement("source_company")]
        public string SourceCompany { get; set; }

        /// <summary>
        /// 公寓状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 使用面积区间段-结束值(平方米)
        /// </summary>
        [XmlElement("usable_area_end")]
        public string UsableAreaEnd { get; set; }

        /// <summary>
        /// 使用面积区间-起始值(平方米)
        /// </summary>
        [XmlElement("usable_area_start")]
        public string UsableAreaStart { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("viewing_time")]
        [XmlArrayItem("string")]
        public List<string> ViewingTime { get; set; }
    }
}
