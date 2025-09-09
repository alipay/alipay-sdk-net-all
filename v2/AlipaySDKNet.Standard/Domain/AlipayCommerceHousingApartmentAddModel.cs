using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingApartmentAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingApartmentAddModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("accommodation")]
        [XmlArrayItem("string")]
        public List<string> Accommodation { get; set; }

        /// <summary>
        /// 如：高教路与文一西路交叉口西南(淘宝城对面)，小区详细地址，与小区字段中的地址关联 
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
        /// VR地址 
        /// </summary>
        [XmlElement("apartment_vr")]
        public string ApartmentVr { get; set; }

        /// <summary>
        /// 卫生间数量
        /// </summary>
        [XmlElement("bath_room")]
        public string BathRoom { get; set; }

        /// <summary>
        /// 居室，1居，2居，3居等 
        /// </summary>
        [XmlElement("bed_room")]
        public string BedRoom { get; set; }

        /// <summary>
        /// 商圈：未来科技城 
        /// </summary>
        [XmlElement("business_district")]
        public string BusinessDistrict { get; set; }

        /// <summary>
        /// 城市code 
        /// </summary>
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 建筑年代
        /// </summary>
        [XmlElement("construction_year")]
        public string ConstructionYear { get; set; }

        /// <summary>
        /// 张三 
        /// </summary>
        [XmlElement("contact_person")]
        public string ContactPerson { get; set; }

        /// <summary>
        /// 15288888888 
        /// </summary>
        [XmlElement("contact_person_phone")]
        public string ContactPersonPhone { get; set; }

        /// <summary>
        /// 经纪人备案证明图片 
        /// </summary>
        [XmlElement("contact_persons_photo")]
        public string ContactPersonsPhoto { get; set; }

        /// <summary>
        /// 区县code
        /// </summary>
        [XmlElement("district_code")]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 梯户比例，例：一梯两户 
        /// </summary>
        [XmlElement("elevator_to_unit_ratio")]
        public string ElevatorToUnitRatio { get; set; }

        /// <summary>
        /// 房源唯一编码 
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 楼层区间，例：5-8层 
        /// </summary>
        [XmlElement("floor_end")]
        public string FloorEnd { get; set; }

        /// <summary>
        /// 楼层区间，例：5-8层 
        /// </summary>
        [XmlElement("floor_start")]
        public string FloorStart { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("house_label")]
        [XmlArrayItem("string")]
        public List<string> HouseLabel { get; set; }

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
        /// (该字段已删除) 当前字段已废弃(业务删除,后续不再需要)
        /// </summary>
        [XmlElement("housing_type")]
        public string HousingType { get; set; }

        /// <summary>
        /// (该字段已删除) 当前字段已废弃(业务删除,后续不再需要)
        /// </summary>
        [XmlElement("intentional_application")]
        public string IntentionalApplication { get; set; }

        /// <summary>
        /// 厨房数量
        /// </summary>
        [XmlElement("kitchen")]
        public string Kitchen { get; set; }

        /// <summary>
        /// 客厅数量
        /// </summary>
        [XmlElement("living_room")]
        public string LivingRoom { get; set; }

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
        /// 所有者身份证
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 所有者姓名
        /// </summary>
        [XmlElement("owner_name")]
        public string OwnerName { get; set; }

        /// <summary>
        /// 小程序详情跳转地址，例如：page=pages/af-home/index?myKey%3DmyValue
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

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
        /// VR地址 
        /// </summary>
        [XmlElement("property_title")]
        public string PropertyTitle { get; set; }

        /// <summary>
        /// 省code
        /// </summary>
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// (该字段已删除) 当前字段已废弃(业务删除,后续不再需要)
        /// </summary>
        [XmlElement("qualification_requirements")]
        public string QualificationRequirements { get; set; }

        /// <summary>
        /// 区间段，****元/月
        /// </summary>
        [XmlElement("rent_end")]
        public string RentEnd { get; set; }

        /// <summary>
        /// 区间段，****元/月起 
        /// </summary>
        [XmlElement("rent_start")]
        public string RentStart { get; set; }

        /// <summary>
        /// 租金单位(周/月/季度/年)
        /// </summary>
        [XmlElement("rent_unit")]
        public string RentUnit { get; set; }

        /// <summary>
        /// 房源所属平台，用于前端展示。 例如：泊寓等纳保机构、**安居集团 
        /// </summary>
        [XmlElement("source_company")]
        public string SourceCompany { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 使用面积，区间值 单位㎡，例：40~50 
        /// </summary>
        [XmlElement("usable_area_end")]
        public string UsableAreaEnd { get; set; }

        /// <summary>
        /// 使用面积，区间值 单位㎡，例：40~50 
        /// </summary>
        [XmlElement("usable_area_start")]
        public string UsableAreaStart { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        [XmlElement("verification_code")]
        public string VerificationCode { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("viewing_time")]
        [XmlArrayItem("string")]
        public List<string> ViewingTime { get; set; }
    }
}
