using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityRoomDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityRoomDeleteModel : AopObject
    {
        /// <summary>
        /// 小区短名, 创建小区时生成
        /// </summary>
        [XmlElement("community_short_name")]
        public string CommunityShortName { get; set; }

        /// <summary>
        /// ISV外部房间号,创建后以支付宝内部房间号为准
        /// </summary>
        [XmlElement("out_room_id")]
        public string OutRoomId { get; set; }

        /// <summary>
        /// 支付宝房间id
        /// </summary>
        [XmlElement("room_id")]
        public string RoomId { get; set; }
    }
}
