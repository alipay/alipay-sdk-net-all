using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRentroomAreaCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRentroomAreaCreateModel : AopObject
    {
        /// <summary>
        /// 提报的公寓信息
        /// </summary>
        [XmlElement("apartment_info")]
        public RentRoomApartmentInfo ApartmentInfo { get; set; }

        /// <summary>
        /// 用于区分提报的小区类型
        /// </summary>
        [XmlElement("area_type")]
        public string AreaType { get; set; }

        /// <summary>
        /// 提报的小区信息
        /// </summary>
        [XmlElement("community_info")]
        public RentRoomCommunityInfo CommunityInfo { get; set; }

        /// <summary>
        /// 商户侧自定义小区ID,用于校验提报小区信息是否唯一。
        /// </summary>
        [XmlElement("out_area_id")]
        public string OutAreaId { get; set; }
    }
}
