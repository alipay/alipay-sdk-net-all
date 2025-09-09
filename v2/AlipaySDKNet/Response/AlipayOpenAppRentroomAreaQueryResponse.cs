using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppRentroomAreaQueryResponse.
    /// </summary>
    public class AlipayOpenAppRentroomAreaQueryResponse : AopResponse
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
    }
}
