using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RentRoomCommunityInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RentRoomCommunityInfo : AopObject
    {
        /// <summary>
        /// 包含小区的位置信息，经纬度、省市区编码、详情地址。
        /// </summary>
        [XmlElement("area_address_info")]
        public AreaAddressInfo AreaAddressInfo { get; set; }

        /// <summary>
        /// 用于补充小区的一些基本信息。
        /// </summary>
        [XmlElement("community_basic_info")]
        public CommunityBasicInfo CommunityBasicInfo { get; set; }

        /// <summary>
        /// 小区内的设施
        /// </summary>
        [XmlArray("community_equipment_info")]
        [XmlArrayItem("string")]
        public List<string> CommunityEquipmentInfo { get; set; }

        /// <summary>
        /// 小区的基本介绍
        /// </summary>
        [XmlElement("community_introduce")]
        public string CommunityIntroduce { get; set; }

        /// <summary>
        /// 小区的名称
        /// </summary>
        [XmlElement("community_name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// 包含小区的各类图片信息，大门图片、内部环境图片、停车设施图片、娱乐活动图片。
        /// </summary>
        [XmlElement("community_pic_info")]
        public CommunityPicInfo CommunityPicInfo { get; set; }
    }
}
