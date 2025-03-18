using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingApartmentModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingApartmentModifyModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("accommodation")]
        [XmlArrayItem("string")]
        public List<string> Accommodation { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("apartment_facilities")]
        [XmlArrayItem("string")]
        public List<string> ApartmentFacilities { get; set; }

        /// <summary>
        /// 公寓id
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
        /// 居室，1居，2居，3居等 
        /// </summary>
        [XmlElement("bed_room")]
        public string BedRoom { get; set; }

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
        /// 梯户比例，例：一梯两户 
        /// </summary>
        [XmlElement("elevator_to_unit_ratio")]
        public string ElevatorToUnitRatio { get; set; }

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
        /// 房源类型
        /// </summary>
        [XmlElement("housing_type")]
        public string HousingType { get; set; }

        /// <summary>
        /// 政府申请页地址：HTTP:// 
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
        /// VR地址 
        /// </summary>
        [XmlElement("property_title")]
        public string PropertyTitle { get; set; }

        /// <summary>
        /// 户籍等，描述文字 
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
        /// null
        /// </summary>
        [XmlArray("viewing_time")]
        [XmlArrayItem("string")]
        public List<string> ViewingTime { get; set; }
    }
}
