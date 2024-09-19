using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRoomApartmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentRoomApartmentInfo : AopObject
    {
        /// <summary>
        /// 公寓的设施列表
        /// </summary>
        [XmlArray("apartment_equipment_info")]
        [XmlArrayItem("string")]
        public List<string> ApartmentEquipmentInfo { get; set; }

        /// <summary>
        /// 公寓的介绍
        /// </summary>
        [XmlElement("apartment_introduce")]
        public string ApartmentIntroduce { get; set; }

        /// <summary>
        /// 公寓名称
        /// </summary>
        [XmlElement("apartment_name")]
        public string ApartmentName { get; set; }

        /// <summary>
        /// 公寓相关的图片信息
        /// </summary>
        [XmlElement("apartment_pic_info")]
        public ApartmentPicInfo ApartmentPicInfo { get; set; }

        /// <summary>
        /// 公寓的地址信息
        /// </summary>
        [XmlElement("area_address_info")]
        public AreaAddressInfo AreaAddressInfo { get; set; }

        /// <summary>
        /// 公寓联系人信息
        /// </summary>
        [XmlArray("contact_info_list")]
        [XmlArrayItem("apartment_contact_info")]
        public List<ApartmentContactInfo> ContactInfoList { get; set; }
    }
}
