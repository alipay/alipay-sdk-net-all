using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRentroomAreaModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRentroomAreaModifyModel : AopObject
    {
        /// <summary>
        /// 修改的公寓信息
        /// </summary>
        [XmlElement("apartment_info")]
        public RentRoomApartmentInfo ApartmentInfo { get; set; }

        /// <summary>
        /// 平台生成的小区ID，在小区信息提报接口返回
        /// </summary>
        [XmlElement("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 用于区分小区类型
        /// </summary>
        [XmlElement("area_type")]
        public string AreaType { get; set; }

        /// <summary>
        /// 修改的小区信息
        /// </summary>
        [XmlElement("community_info")]
        public RentRoomCommunityInfo CommunityInfo { get; set; }

        /// <summary>
        /// 商户侧自定义小区ID,用于校验小区信息是否唯一。
        /// </summary>
        [XmlElement("out_area_id")]
        public string OutAreaId { get; set; }
    }
}
