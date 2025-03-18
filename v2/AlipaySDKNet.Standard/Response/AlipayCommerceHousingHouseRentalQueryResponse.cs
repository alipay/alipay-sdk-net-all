using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceHousingHouseRentalQueryResponse.
    /// </summary>
    public class AlipayCommerceHousingHouseRentalQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("accommodation")]
        [XmlArrayItem("string")]
        public List<string> Accommodation { get; set; }

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
        /// 入住时间
        /// </summary>
        [XmlElement("check_in_time")]
        public string CheckInTime { get; set; }

        /// <summary>
        /// 小区ID(内部)
        /// </summary>
        [XmlElement("community_id")]
        public string CommunityId { get; set; }

        /// <summary>
        /// 建筑面积，单位㎡，例：90.55
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
        /// 房屋现状
        /// </summary>
        [XmlElement("current_condition_house")]
        public string CurrentConditionHouse { get; set; }

        /// <summary>
        /// 押金，单位：元
        /// </summary>
        [XmlElement("deposit")]
        public string Deposit { get; set; }

        /// <summary>
        /// 门牌号
        /// </summary>
        [XmlElement("doorplate_number")]
        public string DoorplateNumber { get; set; }

        /// <summary>
        /// 电梯
        /// </summary>
        [XmlElement("elevator")]
        public string Elevator { get; set; }

        /// <summary>
        /// 梯户比，楼梯和户数的比值，如一梯两户：ONE_ELEVATOR_TWO_HOUSEHOLDS
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
        /// 楼层区间，单位默认层
        /// </summary>
        [XmlElement("floor_range")]
        public string FloorRange { get; set; }

        /// <summary>
        /// 是否独卫
        /// </summary>
        [XmlElement("has_private_bathroom")]
        public string HasPrivateBathroom { get; set; }

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
        /// 房源id
        /// </summary>
        [XmlElement("housing_id")]
        public string HousingId { get; set; }

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
        /// 厨房数量，单位：个
        /// </summary>
        [XmlElement("kitchen")]
        public string Kitchen { get; set; }

        /// <summary>
        /// 挂牌时间，时间格式如下：2023-10-01
        /// </summary>
        [XmlElement("listing_date")]
        public string ListingDate { get; set; }

        /// <summary>
        /// 客厅数量，单位：个
        /// </summary>
        [XmlElement("living_room")]
        public string LivingRoom { get; set; }

        /// <summary>
        /// 朝向
        /// </summary>
        [XmlElement("orientation")]
        public string Orientation { get; set; }

        /// <summary>
        /// 其他
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
        /// 车位
        /// </summary>
        [XmlElement("parking_space")]
        public string ParkingSpace { get; set; }

        /// <summary>
        /// 付款方式
        /// </summary>
        [XmlElement("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// 产权委托书
        /// </summary>
        [XmlElement("power_of_attorney")]
        public string PowerOfAttorney { get; set; }

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
        /// 单位元/月，例：5000
        /// </summary>
        [XmlElement("rent")]
        public string Rent { get; set; }

        /// <summary>
        /// 租金单位，月，周，季度，年
        /// </summary>
        [XmlElement("rent_unit")]
        public string RentUnit { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("rental_requirements")]
        [XmlArrayItem("string")]
        public List<string> RentalRequirements { get; set; }

        /// <summary>
        /// 出租房间描述
        /// </summary>
        [XmlElement("rented_room")]
        public string RentedRoom { get; set; }

        /// <summary>
        /// 租金类型
        /// </summary>
        [XmlElement("renting_type")]
        public string RentingType { get; set; }

        /// <summary>
        ///  来源公司的描述
        /// </summary>
        [XmlElement("source_company")]
        public string SourceCompany { get; set; }

        /// <summary>
        /// 房源状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 总楼层
        /// </summary>
        [XmlElement("total_floors")]
        public string TotalFloors { get; set; }

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
