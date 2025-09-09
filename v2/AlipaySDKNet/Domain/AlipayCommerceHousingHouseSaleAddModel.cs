using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceHousingHouseSaleAddModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceHousingHouseSaleAddModel : AopObject
    {
        /// <summary>
        /// 卫生间数量，单位：个
        /// </summary>
        [XmlElement("bath_room")]
        public string BathRoom { get; set; }

        /// <summary>
        /// 卧室数量，单位：个
        /// </summary>
        [XmlElement("bed_room")]
        public string BedRoom { get; set; }

        /// <summary>
        /// 建筑的描述
        /// </summary>
        [XmlElement("building_category")]
        public string BuildingCategory { get; set; }

        /// <summary>
        /// 小区ID(内部)
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 建筑面积单位㎡，例：90.55
        /// </summary>
        [XmlElement("constructed_area")]
        public string ConstructedArea { get; set; }

        /// <summary>
        /// 建筑年代
        /// </summary>
        [XmlElement("construction_year")]
        public string ConstructionYear { get; set; }

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
        /// 联系人备案照片
        /// </summary>
        [XmlElement("contact_persons_photo")]
        public string ContactPersonsPhoto { get; set; }

        /// <summary>
        /// 房屋现状，房屋现状（1-空房 2业主 3-租客住 4-其他）
        /// </summary>
        [XmlElement("current_condition_house")]
        public string CurrentConditionHouse { get; set; }

        /// <summary>
        /// 门牌号
        /// </summary>
        [XmlElement("doorplate_number")]
        public string DoorplateNumber { get; set; }

        /// <summary>
        /// 电梯，例：有、无
        /// </summary>
        [XmlElement("elevator")]
        public string Elevator { get; set; }

        /// <summary>
        /// （该字段废弃） 当前字段已废弃(枚举值过多，另加字段采用数字传输)
        /// </summary>
        [XmlElement("elevator_to_unit_ratio")]
        public string ElevatorToUnitRatio { get; set; }

        /// <summary>
        /// 外部房源ID
        /// </summary>
        [XmlElement("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 所在楼层
        /// </summary>
        [XmlElement("floor_level")]
        public string FloorLevel { get; set; }

        /// <summary>
        /// 楼层区间，例举：低楼层、高楼层、中楼层
        /// </summary>
        [XmlElement("floor_range")]
        public string FloorRange { get; set; }

        /// <summary>
        /// 房屋年限的描述
        /// </summary>
        [XmlElement("house_age")]
        public string HouseAge { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("house_label")]
        [XmlArrayItem("string")]
        public List<string> HouseLabel { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("house_pic")]
        [XmlArrayItem("string")]
        public List<string> HousePic { get; set; }

        /// <summary>
        /// 关联小程序ID
        /// </summary>
        [XmlElement("house_program_id")]
        public string HouseProgramId { get; set; }

        /// <summary>
        /// 房屋的描述
        /// </summary>
        [XmlElement("house_structure")]
        public string HouseStructure { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("house_video")]
        [XmlArrayItem("string")]
        public List<string> HouseVideo { get; set; }

        /// <summary>
        /// 房源VR链接
        /// </summary>
        [XmlElement("house_vr_url")]
        public string HouseVrUrl { get; set; }

        /// <summary>
        /// 房源类型
        /// </summary>
        [XmlElement("housing_type")]
        public string HousingType { get; set; }

        /// <summary>
        /// 套内面积，单位㎡，例：70.23
        /// </summary>
        [XmlElement("internal_area")]
        public string InternalArea { get; set; }

        /// <summary>
        /// 厨房数量
        /// </summary>
        [XmlElement("kitchen")]
        public string Kitchen { get; set; }

        /// <summary>
        /// 挂牌时间
        /// </summary>
        [XmlElement("listing_date")]
        public string ListingDate { get; set; }

        /// <summary>
        /// 客厅数量，单位：个
        /// </summary>
        [XmlElement("living_room")]
        public string LivingRoom { get; set; }

        /// <summary>
        /// 朝向，例：南北，列举：东、南、西、北、东南、东北、西南、西北、南北、东西
        /// </summary>
        [XmlElement("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// 其它信息
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
        /// 小程序跳转页面，例如：page=pages/af-home/index?myKey%3DmyValue
        /// </summary>
        [XmlElement("page")]
        public string Page { get; set; }

        /// <summary>
        /// 车位，是否带车位，列举：是，否
        /// </summary>
        [XmlElement("parking_space")]
        public string ParkingSpace { get; set; }

        /// <summary>
        /// 产权委托书：是否获得产权人委托（是/否）
        /// </summary>
        [XmlElement("power_of_attorney")]
        public string PowerOfAttorney { get; set; }

        /// <summary>
        /// 不动产产权号
        /// </summary>
        [XmlElement("property_code")]
        public string PropertyCode { get; set; }

        /// <summary>
        /// 房源描述
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
        /// 产权年限
        /// </summary>
        [XmlElement("property_right_year")]
        public string PropertyRightYear { get; set; }

        /// <summary>
        /// 产权
        /// </summary>
        [XmlElement("property_rights")]
        public string PropertyRights { get; set; }

        /// <summary>
        /// 房源标题
        /// </summary>
        [XmlElement("property_title")]
        public string PropertyTitle { get; set; }

        /// <summary>
        /// 装修情况
        /// </summary>
        [XmlElement("renovation")]
        public string Renovation { get; set; }

        /// <summary>
        /// 来源公司的描述
        /// </summary>
        [XmlElement("source_company")]
        public string SourceCompany { get; set; }

        /// <summary>
        /// 房源状态，上架，下架
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 是否唯一住房，列举：是，否
        /// </summary>
        [XmlElement("the_only_housing")]
        public string TheOnlyHousing { get; set; }

        /// <summary>
        /// 总楼层，单位：层
        /// </summary>
        [XmlElement("total_floors")]
        public string TotalFloors { get; set; }

        /// <summary>
        /// 总价,单位万/套，例：501
        /// </summary>
        [XmlElement("total_price")]
        public string TotalPrice { get; set; }

        /// <summary>
        /// 单价，单位元/平米，例：85565.8
        /// </summary>
        [XmlElement("unit_price")]
        public string UnitPrice { get; set; }

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
